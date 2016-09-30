namespace LightsOutGame
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.LinkLabel();
            this.InfoLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitleLabel.Location = new System.Drawing.Point(25, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(223, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Lights Out!";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 55);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(259, 29);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author: Łukasz Furlepa";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GitHubLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GitHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GitHubLabel.Location = new System.Drawing.Point(68, 284);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(149, 22);
            this.GitHubLabel.TabIndex = 2;
            this.GitHubLabel.TabStop = true;
            this.GitHubLabel.Text = "Find me on GitHub!";
            this.GitHubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Event_LinkClicked);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 96);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(268, 219);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.TabStop = true;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            this.InfoLabel.UseCompatibleTextRendering = true;
            this.InfoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Event_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(291, 318);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.LinkLabel GitHubLabel;
        private System.Windows.Forms.LinkLabel InfoLabel;
    }
}