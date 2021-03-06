﻿namespace LastFM_Now_Playing
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.getPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.lfmUserHelp = new System.Windows.Forms.Label();
            this.lfmUsername = new System.Windows.Forms.TextBox();
            this.startParse = new System.Windows.Forms.Button();
            this.parseStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.validity = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // getPath
            // 
            this.getPath.Location = new System.Drawing.Point(12, 30);
            this.getPath.Name = "getPath";
            this.getPath.Size = new System.Drawing.Size(113, 22);
            this.getPath.TabIndex = 0;
            this.getPath.Text = "Browse";
            this.getPath.UseVisualStyleBackColor = true;
            this.getPath.Click += new System.EventHandler(this.getPath_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(159, 30);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(234, 20);
            this.folderPath.TabIndex = 3;
            // 
            // lfmUserHelp
            // 
            this.lfmUserHelp.AutoSize = true;
            this.lfmUserHelp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lfmUserHelp.Location = new System.Drawing.Point(15, 78);
            this.lfmUserHelp.Name = "lfmUserHelp";
            this.lfmUserHelp.Size = new System.Drawing.Size(110, 15);
            this.lfmUserHelp.TabIndex = 2;
            this.lfmUserHelp.Text = "LastFM Username";
            // 
            // lfmUsername
            // 
            this.lfmUsername.Location = new System.Drawing.Point(159, 76);
            this.lfmUsername.MaxLength = 15;
            this.lfmUsername.Name = "lfmUsername";
            this.lfmUsername.Size = new System.Drawing.Size(234, 20);
            this.lfmUsername.TabIndex = 1;
            this.lfmUsername.TextChanged += new System.EventHandler(this.lfmUsername_TextChanged);
            // 
            // startParse
            // 
            this.startParse.Location = new System.Drawing.Point(30, 137);
            this.startParse.Name = "startParse";
            this.startParse.Size = new System.Drawing.Size(75, 23);
            this.startParse.TabIndex = 4;
            this.startParse.Text = "Start";
            this.startParse.UseVisualStyleBackColor = true;
            this.startParse.Click += new System.EventHandler(this.startParse_Click);
            // 
            // parseStatus
            // 
            this.parseStatus.AutoSize = true;
            this.parseStatus.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.parseStatus.Location = new System.Drawing.Point(188, 116);
            this.parseStatus.Name = "parseStatus";
            this.parseStatus.Size = new System.Drawing.Size(165, 32);
            this.parseStatus.TabIndex = 5;
            this.parseStatus.Text = "Not parsing";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // validity
            // 
            this.validity.AutoSize = true;
            this.validity.BackColor = System.Drawing.Color.White;
            this.validity.Location = new System.Drawing.Point(340, 79);
            this.validity.Name = "validity";
            this.validity.Size = new System.Drawing.Size(0, 13);
            this.validity.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Now playing...";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(346, 1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(51, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 172);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.validity);
            this.Controls.Add(this.parseStatus);
            this.Controls.Add(this.startParse);
            this.Controls.Add(this.lfmUsername);
            this.Controls.Add(this.lfmUserHelp);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.getPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Last.FM Now Playing";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Label lfmUserHelp;
        private System.Windows.Forms.TextBox lfmUsername;
        private System.Windows.Forms.Button startParse;
        private System.Windows.Forms.Label parseStatus;
        private System.Windows.Forms.Timer timer1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label validity;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbout;
    }
}

