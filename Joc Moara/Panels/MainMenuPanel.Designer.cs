
namespace Joc_Moara
{
    partial class MainMenuPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.joinButton = new System.Windows.Forms.Button();
            this.hostButton = new System.Windows.Forms.Button();
            this.exitBotton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.exitBotton);
            this.panel1.Controls.Add(this.joinButton);
            this.panel1.Controls.Add(this.hostButton);
            this.panel1.Location = new System.Drawing.Point(200, 220);
            this.panel1.Margin = new System.Windows.Forms.Padding(200, 220, 200, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 360);
            this.panel1.TabIndex = 0;
            // 
            // joinButton
            // 
            this.joinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.joinButton.Location = new System.Drawing.Point(0, 130);
            this.joinButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(400, 100);
            this.joinButton.TabIndex = 0;
            this.joinButton.Text = "Join Game";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // hostButton
            // 
            this.hostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostButton.Location = new System.Drawing.Point(0, 0);
            this.hostButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(400, 100);
            this.hostButton.TabIndex = 0;
            this.hostButton.Text = "Host Game";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // exitBotton
            // 
            this.exitBotton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBotton.Location = new System.Drawing.Point(0, 260);
            this.exitBotton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.exitBotton.Name = "exitBotton";
            this.exitBotton.Size = new System.Drawing.Size(400, 100);
            this.exitBotton.TabIndex = 0;
            this.exitBotton.Text = "Exit Game";
            this.exitBotton.UseVisualStyleBackColor = true;
            this.exitBotton.Click += new System.EventHandler(this.exitBotton_Click);
            // 
            // MainMenuPanel
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel1);
            this.Name = "MainMenuPanel";
            this.Size = new System.Drawing.Size(800, 800);
            this.Load += new System.EventHandler(this.MainMenuPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Button exitBotton;
    }
}
