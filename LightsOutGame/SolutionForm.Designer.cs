namespace LightsOutGame
{
    partial class SolutionForm
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
            this.SolLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MovesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MovesValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HighlightStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HighlightValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomValStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolLabel
            // 
            this.SolLabel.AutoSize = true;
            this.SolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SolLabel.Location = new System.Drawing.Point(10, 10);
            this.SolLabel.Name = "SolLabel";
            this.SolLabel.Size = new System.Drawing.Size(271, 18);
            this.SolLabel.TabIndex = 0;
            this.SolLabel.Text = "Clicking blue cells will solve your puzzle!";
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.StatusStrip.TabIndex = 1;
            // 
            // MovesStatusLabel
            // 
            this.MovesStatusLabel.Name = "MovesStatusLabel";
            this.MovesStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.MovesStatusLabel.Text = "Moves:";
            // 
            // MovesValStatusLabel
            // 
            this.MovesValStatusLabel.AutoSize = false;
            this.MovesValStatusLabel.Name = "MovesValStatusLabel";
            this.MovesValStatusLabel.Size = new System.Drawing.Size(70, 17);
            this.MovesValStatusLabel.Text = "0";
            this.MovesValStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.StatusSplit.Size = new System.Drawing.Size(72, 17);
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
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SolLabel);
            this.Name = "SolutionForm";
            this.Text = "Solution";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SolLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MovesStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel MovesValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HighlightStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HighlightValStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusSplit;
        private System.Windows.Forms.ToolStripStatusLabel ZoomStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ZoomValStatusLabel;
    }
}