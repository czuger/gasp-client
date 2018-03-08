namespace GameBoardAmbiantPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Chemin = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serverConnection = new System.Windows.Forms.Label();
            this.Playing = new System.Windows.Forms.GroupBox();
            this.CurrentSong = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SendLink = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CommandLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Playing.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chemin
            // 
            this.Chemin.Location = new System.Drawing.Point(19, 19);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(75, 23);
            this.Chemin.TabIndex = 1;
            this.Chemin.Text = "Chemin";
            this.Chemin.UseVisualStyleBackColor = true;
            this.Chemin.Click += new System.EventHandler(this.Path_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pathName);
            this.groupBox1.Controls.Add(this.Chemin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musiques";
            // 
            // pathName
            // 
            this.pathName.AutoSize = true;
            this.pathName.Location = new System.Drawing.Point(26, 45);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(88, 13);
            this.pathName.TabIndex = 3;
            this.pathName.Text = "No selected path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serverConnection);
            this.groupBox2.Location = new System.Drawing.Point(13, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reseau";
            // 
            // serverConnection
            // 
            this.serverConnection.AutoSize = true;
            this.serverConnection.Location = new System.Drawing.Point(15, 16);
            this.serverConnection.Name = "serverConnection";
            this.serverConnection.Size = new System.Drawing.Size(109, 13);
            this.serverConnection.TabIndex = 0;
            this.serverConnection.Text = "No server connection";
            // 
            // Playing
            // 
            this.Playing.Controls.Add(this.CurrentSong);
            this.Playing.Location = new System.Drawing.Point(13, 195);
            this.Playing.Name = "Playing";
            this.Playing.Size = new System.Drawing.Size(533, 57);
            this.Playing.TabIndex = 4;
            this.Playing.TabStop = false;
            this.Playing.Text = "Playing";
            // 
            // CurrentSong
            // 
            this.CurrentSong.AutoSize = true;
            this.CurrentSong.Location = new System.Drawing.Point(15, 26);
            this.CurrentSong.Name = "CurrentSong";
            this.CurrentSong.Size = new System.Drawing.Size(67, 13);
            this.CurrentSong.TabIndex = 0;
            this.CurrentSong.Text = "Current song";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SendLink);
            this.groupBox3.Controls.Add(this.Email);
            this.groupBox3.Location = new System.Drawing.Point(13, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email";
            // 
            // SendLink
            // 
            this.SendLink.Location = new System.Drawing.Point(452, 19);
            this.SendLink.Name = "SendLink";
            this.SendLink.Size = new System.Drawing.Size(75, 23);
            this.SendLink.TabIndex = 1;
            this.SendLink.Text = "Send link";
            this.SendLink.UseVisualStyleBackColor = true;
            this.SendLink.Click += new System.EventHandler(this.SendLinkClick);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(6, 19);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(439, 20);
            this.Email.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CommandLink);
            this.groupBox4.Location = new System.Drawing.Point(13, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Command link";
            // 
            // CommandLink
            // 
            this.CommandLink.AutoSize = true;
            this.CommandLink.Location = new System.Drawing.Point(15, 16);
            this.CommandLink.Name = "CommandLink";
            this.CommandLink.Size = new System.Drawing.Size(40, 13);
            this.CommandLink.TabIndex = 1;
            this.CommandLink.TabStop = true;
            this.CommandLink.Text = "No link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 325);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Playing);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gameboard Ambiant Sound Plalyer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Playing.ResumeLayout(false);
            this.Playing.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Chemin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pathName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label serverConnection;
        private System.Windows.Forms.GroupBox Playing;
        private System.Windows.Forms.Label CurrentSong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SendLink;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel CommandLink;
    }
}

