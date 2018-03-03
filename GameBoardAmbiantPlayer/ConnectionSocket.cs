using System;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

public class ConnectionSocket
{
    // private Object m_lock = new Object();                       // Lock to protect counter increment 
    // private Queue<string> m_queue = new Queue<string>();
    string serverConnectionOutupt = null;
    // Déclaration du thread
    Thread myThread = null;
    GameBoardAmbiantPlayer.Form1 front_end = null;

    public ConnectionSocket(GameBoardAmbiantPlayer.Form1 _front_end)
    {
        front_end = _front_end;
    }

    public string StartThread()
    {
        // Instanciation du thread, on spécifie dans le 
        // délégué ThreadStart le nom de la méthode qui
        // sera exécutée lorsque l'on appele la méthode
        // Start() de notre thread.
        myThread = new Thread(new ThreadStart(ThreadLoop));

        // Lancement du thread
        // myThread.IsBackground = true;
        myThread.Start();

//        while (serverConnectionOutupt == null)
//        {
//            Thread.Sleep(500);
//        }

        return serverConnectionOutupt;
    }

    // C'est ici qu'il faudra faire notre travail.
    public void ThreadLoop()
    {
        IPHostEntry ipHostInfo = Dns.GetHostEntry("vps39194.ovh.net");
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 6664);
        BackgroundPlayer player_thread = null;
        // Create a TCP/IP  socket.  
        Socket reader = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        reader.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
        reader.Connect(remoteEP);

        // serverConnectionOutupt = "Connecté au serveur";
        //cc.Text = "toto";
        front_end.SetServerConnectionText("Connecté au serveur");

        while (Thread.CurrentThread.IsAlive)
        {
            byte[] buffer = new byte[1024];
            reader.Receive(buffer);
            string sPlaylist = Encoding.Default.GetString(buffer);
            Debug.WriteLine("sPlaylist = " + sPlaylist);
            JArray oPlaylist = JArray.Parse(sPlaylist);
            Debug.WriteLine("oPlaylist = " + oPlaylist);

            if(player_thread != null)
            {
                player_thread.interrupt_play = true;
            }
          
            player_thread = new BackgroundPlayer( "sounds/", oPlaylist, front_end );
        }
    }
}
