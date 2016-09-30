namespace LightsOutGame
{
    partial class SettingsForm
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.InactiveLabel = new System.Windows.Forms.Label();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.HighlightLabel = new System.Windows.Forms.Label();
            this.HighlightActiveLabel = new System.Windows.Forms.Label();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.InactivePanel = new System.Windows.Forms.Panel();
            this.HighlightPanel = new System.Windows.Forms.Panel();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.HighlightActivePanel = new System.Windows.Forms.Panel();
            this.HighlightInactiveLabel = new System.Windows.Forms.Label();
            this.HighlightInactivePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Azure;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(148, 145);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AutoSize = true;
            this.ActiveLabel.Location = new System.Drawing.Point(12, 19);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(90, 13);
            this.ActiveLabel.TabIndex = 1;
            this.ActiveLabel.Text = "Active Light Color";
            // 
            // InactiveLabel
            // 
            this.InactiveLabel.AutoSize = true;
            this.InactiveLabel.Location = new System.Drawing.Point(12, 38);
            this.InactiveLabel.Name = "InactiveLabel";
            this.InactiveLabel.Size = new System.Drawing.Size(98, 13);
            this.InactiveLabel.TabIndex = 2;
            this.InactiveLabel.Text = "Inactive Light Color";
            // 
            // BorderLabel
            // 
            this.BorderLabel.AutoSize = true;
            this.BorderLabel.Location = new System.Drawing.Point(12, 57);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(65, 13);
            this.BorderLabel.TabIndex = 3;
            this.BorderLabel.Text = "Border Color";
            // 
            // HighlightLabel
            // 
            this.HighlightLabel.AutoSize = true;
            this.HighlightLabel.Location = new System.Drawing.Point(12, 76);
            this.HighlightLabel.Name = "HighlightLabel";
            this.HighlightLabel.Size = new System.Drawing.Size(75, 13);
            this.HighlightLabel.TabIndex = 4;
            this.HighlightLabel.Text = "Highlight Color";
            // 
            // HighlightActiveLabel
            // 
            this.HighlightActiveLabel.AutoSize = true;
            this.HighlightActiveLabel.Location = new System.Drawing.Point(12, 95);
            this.HighlightActiveLabel.Name = "HighlightActiveLabel";
            this.HighlightActiveLabel.Size = new System.Drawing.Size(146, 13);
            this.HighlightActiveLabel.TabIndex = 5;
            this.HighlightActiveLabel.Text = "Highlighted Active Light Color";
            // 
            // ActivePanel
            // 
            this.ActivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActivePanel.Location = new System.Drawing.Point(203, 12);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(20, 20);
            this.ActivePanel.TabIndex = 6;
            this.ActivePanel.BackColorChanged += new System.EventHandler(this.ActivePanel_BackColorChanged);
            this.ActivePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActivePanel_MouseClick);
            // 
            // InactivePanel
            // 
            this.InactivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InactivePanel.Location = new System.Drawing.Point(203, 31);
            this.InactivePanel.Name = "InactivePanel";
            this.InactivePanel.Size = new System.Drawing.Size(20, 20);
            this.InactivePanel.TabIndex = 7;
            this.InactivePanel.BackColorChanged += new System.EventHandler(this.InactivePanel_BackColorChanged);
            this.InactivePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InactivePanel_MouseClick);
            // 
            // HighlightPanel
            // 
            this.HighlightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighlightPanel.Location = new System.Drawing.Point(203, 69);
            this.HighlightPanel.Name = "HighlightPanel";
            this.HighlightPanel.Size = new System.Drawing.Size(20, 20);
            this.HighlightPanel.TabIndex = 7;
            this.HighlightPanel.BackColorChanged += new System.EventHandler(this.HighlightPanel_BackColorChanged);
            this.HighlightPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HighlightPanel_MouseClick);
            // 
            // BorderPanel
            // 
            this.BorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderPanel.Location = new System.Drawing.Point(203, 50);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(20, 20);
            this.BorderPanel.TabIndex = 7;
            this.BorderPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseClick);
            // 
            // HighlightActivePanel
            // 
            this.HighlightActivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighlightActivePanel.Location = new System.Drawing.Point(203, 88);
            this.HighlightActivePanel.Name = "HighlightActivePanel";
            this.HighlightActivePanel.Size = new System.Drawing.Size(20, 20);
            this.HighlightActivePanel.TabIndex = 7;
            this.HighlightActivePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HighlightActivePanel_Paint);
            // 
            // HighlightInactiveLabel
            // 
            this.HighlightInactiveLabel.AutoSize = true;
            this.HighlightInactiveLabel.Location = new System.Drawing.Point(12, 114);
            this.HighlightInactiveLabel.Name = "HighlightInactiveLabel";
            this.HighlightInactiveLabel.Size = new System.Drawing.Size(154, 13);
            this.HighlightInactiveLabel.TabIndex = 8;
            this.HighlightInactiveLabel.Text = "Highlighted Inactive Light Color";
            // 
            // HighlightInactivePanel
            // 
            this.HighlightInactivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighlightInactivePanel.Location = new System.Drawing.Point(203, 107);
            this.HighlightInactivePanel.Name = "HighlightInactivePanel";
            this.HighlightInactivePanel.Size = new System.Drawing.Size(20, 20);
            this.HighlightInactivePanel.TabIndex = 8;
            this.HighlightInactivePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HighlightInactivePanel_Paint);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(235, 180);
            this.Controls.Add(this.HighlightInactivePanel);
            this.Controls.Add(this.HighlightInactiveLabel);
            this.Controls.Add(this.HighlightActivePanel);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.HighlightPanel);
            this.Controls.Add(this.InactivePanel);
            this.Controls.Add(this.ActivePanel);
            this.Controls.Add(this.HighlightActiveLabel);
            this.Controls.Add(this.HighlightLabel);
            this.Controls.Add(this.BorderLabel);
            this.Controls.Add(this.InactiveLabel);
            this.Controls.Add(this.ActiveLabel);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.Label InactiveLabel;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.Label HighlightLabel;
        private System.Windows.Forms.Label HighlightActiveLabel;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Panel InactivePanel;
        private System.Windows.Forms.Panel HighlightPanel;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Panel HighlightActivePanel;
        private System.Windows.Forms.Label HighlightInactiveLabel;
        private System.Windows.Forms.Panel HighlightInactivePanel;
    }
}