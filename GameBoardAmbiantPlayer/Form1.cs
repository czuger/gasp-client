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
        AppParams app_params = new AppParams();

        public Form1()
        {
            InitializeComponent();
            app_params.ReadOrCreateParams();

            //pathName.Text = "sounds/";

            //Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            //socket_thread = new ConnectionSocket(this);
            //serverConnection.Text = socket_thread.StartThread();
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

                CommandLink.Text = app_params.SetFolders(pathName.Text);
            }
        }

        // This delegate enables asynchronous calls for setting  
        // the text property on a TextBox control.  
        delegate void StringArgReturningVoidDelegate(string text);

        // This method demonstrates a pattern for making thread-safe  
        // calls on a Windows Forms control.   
        //  
        // If the calling thread is different from the thread that  
        // created the TextBox control, this method creates a  
        // StringArgReturningVoidDelegate and calls itself asynchronously using the  
        // Invoke method.  
        //  
        // If the calling thread is the same as the thread that created  
        // the TextBox control, the Text property is set directly.   

        public void SetServerConnectionText(string text)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.serverConnection.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetServerConnectionText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.serverConnection.Text = text;
            }
        }

        public void SetCurrentSongText(string text)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.CurrentSong.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetCurrentSongText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.CurrentSong.Text = text;
            }
        }

        private void SendLinkClick(object sender, EventArgs e)
        {
            Debug.WriteLine(Email.Text);
            CommandLink.Text = app_params.SetEmail(Email.Text);
        }
    }
}
