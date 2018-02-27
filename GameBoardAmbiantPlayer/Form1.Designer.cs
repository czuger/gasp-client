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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chemin
            // 
            this.Chemin.Enabled = false;
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pathName
            // 
            this.pathName.AutoSize = true;
            this.pathName.Location = new System.Drawing.Point(26, 45);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(56, 13);
            this.pathName.TabIndex = 3;
            this.pathName.Text = "pathName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serverConnection);
            this.groupBox2.Location = new System.Drawing.Point(13, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reseau";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // serverConnection
            // 
            this.serverConnection.AutoSize = true;
            this.serverConnection.Location = new System.Drawing.Point(7, 20);
            this.serverConnection.Name = "serverConnection";
            this.serverConnection.Size = new System.Drawing.Size(126, 13);
            this.serverConnection.TabIndex = 0;
            this.serverConnection.Text = "Connection au serveur ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Chemin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pathName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label serverConnection;
    }
}

