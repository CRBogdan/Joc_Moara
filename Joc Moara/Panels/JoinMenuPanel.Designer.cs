
namespace Joc_Moara
{
    partial class JoinMenuPanel
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
            this.adressText = new System.Windows.Forms.TextBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.adressText);
            this.panel1.Controls.Add(this.joinButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Location = new System.Drawing.Point(200, 220);
            this.panel1.Margin = new System.Windows.Forms.Padding(200, 220, 200, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 360);
            this.panel1.TabIndex = 2;
            // 
            // adressText
            // 
            this.adressText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adressText.Location = new System.Drawing.Point(0, 0);
            this.adressText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.adressText.MaximumSize = new System.Drawing.Size(400, 100);
            this.adressText.MinimumSize = new System.Drawing.Size(400, 100);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(400, 42);
            this.adressText.TabIndex = 4;
            this.adressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.joinButton.TabIndex = 3;
            this.joinButton.Text = "Join Game";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(0, 260);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(400, 100);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // JoinMenuPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel1);
            this.Name = "JoinMenuPanel";
            this.Size = new System.Drawing.Size(800, 800);
            this.Load += new System.EventHandler(this.JoinMenuPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox adressText;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
