using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Joc_Moara;
using System.Resources;

namespace Joc_Moara
{
    partial class gameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuPanel = new Joc_Moara.MainMenuPanel(this);
            this.hostMenuPanel = new Joc_Moara.HostMenuPanel(this);
            this.hostGamePanel = new Joc_Moara.HostGamePanel(this);
            this.joinMenuPanel = new Joc_Moara.JoinMenuPanel(this);
            this.joinGamePanel = new Joc_Moara.JoinGamePanel(this);
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(800, 800);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // hostMenuPanel
            // 
            this.hostMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.hostMenuPanel.Name = "hostMenuPanel";
            this.hostMenuPanel.Size = new System.Drawing.Size(800, 800);
            this.hostMenuPanel.TabIndex = 0;
            this.hostMenuPanel.Hide();
            // 
            // hostGamePanel
            // 
            this.hostGamePanel.Location = new System.Drawing.Point(0, 0);
            this.hostGamePanel.Name = "hostGamePanel";
            this.hostGamePanel.Size = new System.Drawing.Size(800, 800);
            this.hostGamePanel.TabIndex = 0;
            this.hostGamePanel.Hide();
            // 
            // joinMenuPanel
            // 
            this.joinMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.joinMenuPanel.Name = "joinMenuPanel";
            this.joinMenuPanel.Size = new System.Drawing.Size(800, 800);
            this.joinMenuPanel.Hide();
            // 
            // joinGamePanel
            // 
            this.joinGamePanel.Location = new System.Drawing.Point(0, 0);
            this.joinGamePanel.Name = "joinGamePanel";
            this.joinGamePanel.Size = new System.Drawing.Size(800, 800);
            this.joinGamePanel.Hide();
            // 
            // gameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.hostMenuPanel);
            this.Controls.Add(this.hostGamePanel);
            this.Controls.Add(this.joinMenuPanel);
            this.Controls.Add(this.joinGamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private HostMenuPanel hostMenuPanel;
        private MainMenuPanel mainMenuPanel;
        private HostGamePanel hostGamePanel;
        private JoinGamePanel joinGamePanel;
        private JoinMenuPanel joinMenuPanel;
    }
}

