using System;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text;

public class ConnectionSocket
{
	public ConnectionSocket()
	{
        IPHostEntry ipHostInfo = Dns.GetHostEntry("vps39194.ovh.net");
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 6664);

        // Create a TCP/IP  socket.  
        Socket reader = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        reader.Connect(remoteEP);

        byte[] buffer = new byte[1024];

        while( true)
        {
            Debug.Write(reader.Receive(buffer));
            Debug.Write(Encoding.Default.GetString(buffer));
        }    
    }
}
