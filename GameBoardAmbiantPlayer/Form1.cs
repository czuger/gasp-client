using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace GameBoardAmbiantPlayer
{
    // Use https://github.com/naudio/NAudio

    public partial class Form1 : Form
    {
        private static string forest = "../../sounds/Forest/";
        private static string battle = "../../sounds/battle/";
        BackgroundPlayer player_thread = null;

        private void Battle_Click(object sender, EventArgs e)
        {
            player_thread.interrupt_play = true;
            var files = Directory.GetFiles(battle);
            player_thread = new BackgroundPlayer(battle, files);
        }

        public Form1()
        {
            InitializeComponent();
            var files = Directory.GetFiles(forest);
            //player_thread = new BackgroundPlayer(forest, files);

            IPHostEntry ipHostInfo = Dns.GetHostEntry("vps39194.ovh.net");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 6664);

            // Create a TCP/IP  socket.  
            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Debug.Write(sender);
            sender.Connect(remoteEP);
        }
    }
}
