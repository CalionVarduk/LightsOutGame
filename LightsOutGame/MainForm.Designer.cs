namespace LightsOutGame
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.GameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRandomGameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEditorGameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadGameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.TimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LightsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LightsValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MovesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MovesValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HighlightStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HighlightValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenuButton,
            this.EditorMenuButton,
            this.SettingsMenuButton,
            this.AboutMenuButton});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip.TabIndex = 1;
            // 
            // GameMenuButton
            // 
            this.GameMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRandomGameMenuButton,
            this.NewEditorGameMenuButton,
            this.LoadGameMenuButton,
            this.SaveGameMenuButton});
            this.GameMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GameMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GameMenuButton.Name = "GameMenuButton";
            this.GameMenuButton.Size = new System.Drawing.Size(59, 20);
            this.GameMenuButton.Text = "Game...";
            // 
            // NewRandomGameMenuButton
            // 
            this.NewRandomGameMenuButton.BackColor = System.Drawing.SystemColors.Control;
            this.NewRandomGameMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewRandomGameMenuButton.Name = "NewRandomGameMenuButton";
            this.NewRandomGameMenuButton.Size = new System.Drawing.Size(156, 22);
            this.NewRandomGameMenuButton.Text = "New (Random)";
            this.NewRandomGameMenuButton.Click += new System.EventHandler(this.NewRandomGameMenuButton_Click);
            // 
            // NewEditorGameMenuButton
            // 
            this.NewEditorGameMenuButton.Name = "NewEditorGameMenuButton";
            this.NewEditorGameMenuButton.Size = new System.Drawing.Size(156, 22);
            this.NewEditorGameMenuButton.Text = "New (Premade)";
            this.NewEditorGameMenuButton.Click += new System.EventHandler(this.NewEditorGameMenuButton_Click);
            // 
            // LoadGameMenuButton
            // 
            this.LoadGameMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadGameMenuButton.Name = "LoadGameMenuButton";
            this.LoadGameMenuButton.Size = new System.Drawing.Size(156, 22);
            this.LoadGameMenuButton.Text = "Load";
            this.LoadGameMenuButton.Click += new System.EventHandler(this.LoadGameMenuButton_Click);
            // 
            // SaveGameMenuButton
            // 
            this.SaveGameMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveGameMenuButton.Name = "SaveGameMenuButton";
            this.SaveGameMenuButton.Size = new System.Drawing.Size(156, 22);
            this.SaveGameMenuButton.Text = "Save";
            this.SaveGameMenuButton.Click += new System.EventHandler(this.SaveGameMenuButton_Click);
            // 
            // EditorMenuButton
            // 
            this.EditorMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditorMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorMenuButton.Name = "EditorMenuButton";
            this.EditorMenuButton.Size = new System.Drawing.Size(80, 20);
            this.EditorMenuButton.Text = "Level Editor";
            this.EditorMenuButton.Click += new System.EventHandler(this.EditorMenuButton_Click);
            // 
            // SettingsMenuButton
            // 
            this.SettingsMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingsMenuButton.Name = "SettingsMenuButton";
            this.SettingsMenuButton.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenuButton.Text = "Settings";
            this.SettingsMenuButton.Click += new System.EventHandler(this.SettingsMenuButton_Click);
            // 
            // AboutMenuButton
            // 
            this.AboutMenuButton.Name = "AboutMenuButton";
            this.AboutMenuButton.Size = new System.Drawing.Size(52, 20);
            this.AboutMenuButton.Text = "About";
            this.AboutMenuButton.Click += new System.EventHandler(this.AboutMenuButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStatusLabel,
            this.TimeValStatusLabel,
            this.LightsStatusLabel,
            this.LightsValStatusLabel,
            this.MovesStatusLabel,
            this.MovesValStatusLabel,
            this.HighlightStatusLabel,
            this.HighlightValStatusLabel,
            this.StatusSplit,
            this.ZoomStatusLabel,
            this.ZoomValStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 240);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(284, 22);
            this.StatusStrip.TabIndex = 2;
            // 
            // TimeStatusLabel
            // 
            this.TimeStatusLabel.Name = "TimeStatusLabel";
            this.TimeStatusLabel.Size = new System.Drawing.Size(37, 17);
            this.TimeStatusLabel.Text = "Time:";
            this.TimeStatusLabel.Visible = false;
            // 
            // TimeValStatusLabel
            // 
            this.TimeValStatusLabel.AutoSize = false;
            this.TimeValStatusLabel.Name = "TimeValStatusLabel";
            this.TimeValStatusLabel.Size = new System.Drawing.Size(100, 17);
            this.TimeValStatusLabel.Text = "0";
            this.TimeValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeValStatusLabel.Visible = false;
            // 
            // LightsStatusLabel
            // 
            this.LightsStatusLabel.Name = "LightsStatusLabel";
            this.LightsStatusLabel.Size = new System.Drawing.Size(58, 17);
            this.LightsStatusLabel.Text = "Lights Lit:";
            this.LightsStatusLabel.Visible = false;
            // 
            // LightsValStatusLabel
            // 
            this.LightsValStatusLabel.AutoSize = false;
            this.LightsValStatusLabel.Name = "LightsValStatusLabel";
            this.LightsValStatusLabel.Size = new System.Drawing.Size(100, 17);
            this.LightsValStatusLabel.Text = "0/0";
            this.LightsValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightsValStatusLabel.Visible = false;
            // 
            // MovesStatusLabel
            // 
            this.MovesStatusLabel.Name = "MovesStatusLabel";
            this.MovesStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.MovesStatusLabel.Text = "Moves:";
            this.MovesStatusLabel.Visible = false;
            // 
            // MovesValStatusLabel
            // 
            this.MovesValStatusLabel.AutoSize = false;
            this.MovesValStatusLabel.Name = "MovesValStatusLabel";
            this.MovesValStatusLabel.Size = new System.Drawing.Size(70, 17);
            this.MovesValStatusLabel.Text = "0";
            this.MovesValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MovesValStatusLabel.Visible = false;
            // 
            // HighlightStatusLabel
            // 
            this.HighlightStatusLabel.Name = "HighlightStatusLabel";
            this.HighlightStatusLabel.Size = new System.Drawing.Size(90, 17);
            this.HighlightStatusLabel.Text = "[Row, Column]:";
            this.HighlightStatusLabel.Visible = false;
            // 
            // HighlightValStatusLabel
            // 
            this.HighlightValStatusLabel.Name = "HighlightValStatusLabel";
            this.HighlightValStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.HighlightValStatusLabel.Text = "[0, 0]";
            this.HighlightValStatusLabel.Visible = false;
            // 
            // StatusSplit
            // 
            this.StatusSplit.Name = "StatusSplit";
            this.StatusSplit.Size = new System.Drawing.Size(187, 17);
            this.StatusSplit.Spring = true;
            // 
            // ZoomStatusLabel
            // 
            this.ZoomStatusLabel.Name = "ZoomStatusLabel";
            this.ZoomStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.ZoomStatusLabel.Text = "Zoom:";
            // 
            // ZoomValStatusLabel
            // 
            this.ZoomValStatusLabel.AutoSize = false;
            this.ZoomValStatusLabel.Name = "ZoomValStatusLabel";
            this.ZoomValStatusLabel.Size = new System.Drawing.Size(40, 17);
            this.ZoomValStatusLabel.Text = "x1";
            this.ZoomValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Lights Out!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GameMenuButton;
        private System.Windows.Forms.ToolStripMenuItem NewRandomGameMenuButton;
        private System.Windows.Forms.ToolStripMenuItem LoadGameMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SaveGameMenuButton;
        private System.Windows.Forms.ToolStripMenuItem EditorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TimeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LightsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LightsValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusSplit;
        private System.Windows.Forms.ToolStripStatusLabel ZoomStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ZoomValStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem NewEditorGameMenuButton;
        private System.Windows.Forms.ToolStripStatusLabel MovesStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel MovesValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HighlightStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HighlightValStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuButton;
    }
}

