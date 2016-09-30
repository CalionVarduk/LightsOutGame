namespace LightsOutGame
{
    partial class LevelEditorForm
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
            this.LoadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LightsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LightsValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActiveStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActiveValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.InactiveStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.InactiveValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisabledStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisabledValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HighlightStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HighlightValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColumnsLabel = new System.Windows.Forms.Label();
            this.ColumnsBox = new System.Windows.Forms.NumericUpDown();
            this.RowsBox = new System.Windows.Forms.NumericUpDown();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeValLabel = new System.Windows.Forms.Label();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.InactivePanel = new System.Windows.Forms.Panel();
            this.DisabledPanel = new System.Windows.Forms.Panel();
            this.DiagonalModeBox = new System.Windows.Forms.CheckBox();
            this.SolutionMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadMenuButton,
            this.SaveMenuButton,
            this.SolutionMenuButton});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // LoadMenuButton
            // 
            this.LoadMenuButton.Name = "LoadMenuButton";
            this.LoadMenuButton.Size = new System.Drawing.Size(75, 20);
            this.LoadMenuButton.Text = "Load Level";
            this.LoadMenuButton.Click += new System.EventHandler(this.LoadMenuButton_Click);
            // 
            // SaveMenuButton
            // 
            this.SaveMenuButton.Name = "SaveMenuButton";
            this.SaveMenuButton.Size = new System.Drawing.Size(73, 20);
            this.SaveMenuButton.Text = "Save Level";
            this.SaveMenuButton.Click += new System.EventHandler(this.SaveMenuButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightsStatusLabel,
            this.LightsValStatusLabel,
            this.ActiveStatusLabel,
            this.ActiveValStatusLabel,
            this.InactiveStatusLabel,
            this.InactiveValStatusLabel,
            this.DisabledStatusLabel,
            this.DisabledValStatusLabel,
            this.HighlightStatusLabel,
            this.HighlightValStatusLabel,
            this.StatusSplit,
            this.ZoomStatusLabel,
            this.ZoomValStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 240);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(284, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LightsStatusLabel
            // 
            this.LightsStatusLabel.Name = "LightsStatusLabel";
            this.LightsStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.LightsStatusLabel.Text = "Lights:";
            // 
            // LightsValStatusLabel
            // 
            this.LightsValStatusLabel.AutoSize = false;
            this.LightsValStatusLabel.Name = "LightsValStatusLabel";
            this.LightsValStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.LightsValStatusLabel.Text = "0";
            this.LightsValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActiveStatusLabel
            // 
            this.ActiveStatusLabel.Name = "ActiveStatusLabel";
            this.ActiveStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.ActiveStatusLabel.Text = "Active:";
            // 
            // ActiveValStatusLabel
            // 
            this.ActiveValStatusLabel.AutoSize = false;
            this.ActiveValStatusLabel.Name = "ActiveValStatusLabel";
            this.ActiveValStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.ActiveValStatusLabel.Text = "0";
            this.ActiveValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InactiveStatusLabel
            // 
            this.InactiveStatusLabel.Name = "InactiveStatusLabel";
            this.InactiveStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.InactiveStatusLabel.Text = "Inactive:";
            // 
            // InactiveValStatusLabel
            // 
            this.InactiveValStatusLabel.AutoSize = false;
            this.InactiveValStatusLabel.Name = "InactiveValStatusLabel";
            this.InactiveValStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.InactiveValStatusLabel.Text = "0";
            this.InactiveValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisabledStatusLabel
            // 
            this.DisabledStatusLabel.Name = "DisabledStatusLabel";
            this.DisabledStatusLabel.Size = new System.Drawing.Size(55, 17);
            this.DisabledStatusLabel.Text = "Disabled:";
            // 
            // DisabledValStatusLabel
            // 
            this.DisabledValStatusLabel.AutoSize = false;
            this.DisabledValStatusLabel.Name = "DisabledValStatusLabel";
            this.DisabledValStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.DisabledValStatusLabel.Text = "0";
            this.DisabledValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.HighlightValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HighlightValStatusLabel.Visible = false;
            // 
            // StatusSplit
            // 
            this.StatusSplit.Name = "StatusSplit";
            this.StatusSplit.Size = new System.Drawing.Size(1, 17);
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
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(12, 31);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(37, 13);
            this.RowsLabel.TabIndex = 2;
            this.RowsLabel.Text = "Rows:";
            // 
            // ColumnsLabel
            // 
            this.ColumnsLabel.AutoSize = true;
            this.ColumnsLabel.Location = new System.Drawing.Point(122, 31);
            this.ColumnsLabel.Name = "ColumnsLabel";
            this.ColumnsLabel.Size = new System.Drawing.Size(50, 13);
            this.ColumnsLabel.TabIndex = 3;
            this.ColumnsLabel.Text = "Columns:";
            // 
            // ColumnsBox
            // 
            this.ColumnsBox.Location = new System.Drawing.Point(178, 29);
            this.ColumnsBox.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ColumnsBox.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColumnsBox.Name = "ColumnsBox";
            this.ColumnsBox.Size = new System.Drawing.Size(50, 20);
            this.ColumnsBox.TabIndex = 2;
            this.ColumnsBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ColumnsBox.ValueChanged += new System.EventHandler(this.ColumnsBox_ValueChanged);
            this.ColumnsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            // 
            // RowsBox
            // 
            this.RowsBox.Location = new System.Drawing.Point(55, 29);
            this.RowsBox.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.RowsBox.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowsBox.Name = "RowsBox";
            this.RowsBox.Size = new System.Drawing.Size(50, 20);
            this.RowsBox.TabIndex = 1;
            this.RowsBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RowsBox.ValueChanged += new System.EventHandler(this.RowsBox_ValueChanged);
            this.RowsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(249, 31);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(105, 13);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Selected Light Type:";
            // 
            // TypeValLabel
            // 
            this.TypeValLabel.AutoSize = true;
            this.TypeValLabel.Location = new System.Drawing.Point(360, 31);
            this.TypeValLabel.Name = "TypeValLabel";
            this.TypeValLabel.Size = new System.Drawing.Size(45, 13);
            this.TypeValLabel.TabIndex = 5;
            this.TypeValLabel.Text = "Inactive";
            // 
            // ActivePanel
            // 
            this.ActivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActivePanel.Location = new System.Drawing.Point(426, 29);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(20, 20);
            this.ActivePanel.TabIndex = 6;
            this.ActivePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ActivePanel_MouseDown);
            // 
            // InactivePanel
            // 
            this.InactivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InactivePanel.Location = new System.Drawing.Point(452, 29);
            this.InactivePanel.Name = "InactivePanel";
            this.InactivePanel.Size = new System.Drawing.Size(20, 20);
            this.InactivePanel.TabIndex = 7;
            this.InactivePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InactivePanel_MouseDown);
            // 
            // DisabledPanel
            // 
            this.DisabledPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisabledPanel.Location = new System.Drawing.Point(478, 29);
            this.DisabledPanel.Name = "DisabledPanel";
            this.DisabledPanel.Size = new System.Drawing.Size(20, 20);
            this.DisabledPanel.TabIndex = 7;
            this.DisabledPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisabledPanel_MouseDown);
            // 
            // DiagonalModeBox
            // 
            this.DiagonalModeBox.AutoSize = true;
            this.DiagonalModeBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiagonalModeBox.Location = new System.Drawing.Point(525, 31);
            this.DiagonalModeBox.Name = "DiagonalModeBox";
            this.DiagonalModeBox.Size = new System.Drawing.Size(167, 17);
            this.DiagonalModeBox.TabIndex = 8;
            this.DiagonalModeBox.TabStop = false;
            this.DiagonalModeBox.Text = "Diagonal Neighbour Mode On";
            this.DiagonalModeBox.UseVisualStyleBackColor = true;
            this.DiagonalModeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.DiagonalModeBox.CheckedChanged += new System.EventHandler(this.DiagonalModeBox_CheckedChanged);
            // 
            // SolutionMenuButton
            // 
            this.SolutionMenuButton.Name = "SolutionMenuButton";
            this.SolutionMenuButton.Size = new System.Drawing.Size(95, 20);
            this.SolutionMenuButton.Text = "Show Solution";
            this.SolutionMenuButton.Click += new System.EventHandler(this.SolutionMenuButton_Click);
            // 
            // LevelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DiagonalModeBox);
            this.Controls.Add(this.DisabledPanel);
            this.Controls.Add(this.InactivePanel);
            this.Controls.Add(this.ActivePanel);
            this.Controls.Add(this.TypeValLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.RowsBox);
            this.Controls.Add(this.ColumnsBox);
            this.Controls.Add(this.ColumnsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "LevelEditorForm";
            this.Text = "Level Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuButton;
        private System.Windows.Forms.ToolStripStatusLabel LightsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LightsValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ActiveStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ActiveValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel InactiveStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel InactiveValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DisabledStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DisabledValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HighlightStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HighlightValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusSplit;
        private System.Windows.Forms.ToolStripStatusLabel ZoomStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ZoomValStatusLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label ColumnsLabel;
        private System.Windows.Forms.NumericUpDown ColumnsBox;
        private System.Windows.Forms.NumericUpDown RowsBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TypeValLabel;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Panel InactivePanel;
        private System.Windows.Forms.Panel DisabledPanel;
        private System.Windows.Forms.CheckBox DiagonalModeBox;
        private System.Windows.Forms.ToolStripMenuItem SolutionMenuButton;
    }
}