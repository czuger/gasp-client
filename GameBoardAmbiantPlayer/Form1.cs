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
using System.Diagnostics;
using Newtonsoft.Json;

namespace GameBoardAmbiantPlayer
{
    // Use https://github.com/naudio/NAudio
 
    public partial class Form1 : Form
    {
        ConnectionSocket socket_thread = null;
        //private Object m_lock = new Object();                       // Lock to protect counter increment 
        //private Queue<string> m_queue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
            pathName.Text = "sounds/";

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            socket_thread = new ConnectionSocket();
            serverConnection.Text = socket_thread.StartThread();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
