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
using Newtonsoft.Json;

namespace GameBoardAmbiantPlayer
{
    // Use https://github.com/naudio/NAudio
    // {"battle":["battle/battle01.mp3","battle/battle02.mp3","battle/battle03.mp3","battle/battle04.mp3","battle/battle05.mp3","battle/battle06.mp3"],"sounds":["sounds/Forest"],"Forest":["Forest/DayForest01.mp3","Forest/DayForest02.mp3","Forest/DayForest03.mp3","Forest/NightForest01.mp3","Forest/NightForest02.mp3","Forest/NightForest03.mp3","Forest/NightForest04.mp3"]}

    public partial class Form1 : Form
    {
        private static string forest = "../../sounds/Forest/";
        private static string battle = "../../sounds/battle/";
        BackgroundPlayer player_thread = null;

        private void Battle_Click(object sender, EventArgs e)
        {
            player_thread.interrupt_play = true;
            // var files = Directory.GetFiles(battle);
            // player_thread = new BackgroundPlayer(battle, files);

            var directories = Directory.GetDirectories("../../sounds");
            Debug.Write(JsonConvert.SerializeObject(directories));
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
            Socket reader = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Debug.Write(sender);
            reader.Connect(remoteEP);


        }
    }
}
