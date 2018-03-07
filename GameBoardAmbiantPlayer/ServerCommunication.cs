using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace GameBoardAmbiantPlayer
{
    class ServerCommunication
    {
        IPHostEntry ipHostInfo = Dns.GetHostEntry("vps39194.ovh.net");
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Form1 front_end;
        Socket connection;
        private const int server_port=6664;
        private const string send_data = "SET";
        private const string get_music = "GMU";

        public ServerCommunication(Form1 _front_end = null)
        {
            ipAddress = ipHostInfo.AddressList[0];
            front_end = _front_end;
        }

        public string SendData( string json )
        {            
            EstablishConnection(send_data);
            SendString(json);
            string hash = RecieveHash();
            EndCommunication();
            return hash;
        }

        private void EstablishConnection(string socket_usage)
        {
            remoteEP = new IPEndPoint(ipAddress, server_port);
            // Create a TCP/IP  socket.  
            connection = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            connection.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            connection.Connect(remoteEP);
            SendString(socket_usage);
        }

        private void EndCommunication()
        {
            connection.Close();
        }

        private void SendString( string data )
        {
            byte[] buffer = new byte[4096];
            buffer = Encoding.UTF8.GetBytes(data);
            connection.Send(buffer);
        }

        public string RecieveHash()
        {
            byte[] buffer = new byte[4096];
            connection.Receive(buffer);
            string hash = Encoding.UTF8.GetString(buffer);
            return hash;
        }
    }
}
