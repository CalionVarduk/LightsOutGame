namespace LightsOutGame
{
    partial class RandomModelCreator
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
            this.DiagonalModeBox = new System.Windows.Forms.CheckBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RowsBox = new System.Windows.Forms.NumericUpDown();
            this.ColumnsBox = new System.Windows.Forms.NumericUpDown();
            this.ActiveBox = new LightsOutGame.FormattedUpDown();
            this.InactiveBox = new LightsOutGame.FormattedUpDown();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColumnsLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.InactiveLabel = new System.Windows.Forms.Label();
            this.DisabledLabel = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.DisabledBox = new System.Windows.Forms.TextBox();
            this.RandomSizeButton = new System.Windows.Forms.Button();
            this.RandomChanceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RowsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InactiveBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagonalModeBox
            // 
            this.DiagonalModeBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiagonalModeBox.Location = new System.Drawing.Point(12, 12);
            this.DiagonalModeBox.Name = "DiagonalModeBox";
            this.DiagonalModeBox.Size = new System.Drawing.Size(276, 24);
            this.DiagonalModeBox.TabIndex = 0;
            this.DiagonalModeBox.TabStop = false;
            this.DiagonalModeBox.Text = "Diagonal Neighbour Mode On";
            this.DiagonalModeBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Azure;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(223, 192);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(65, 23);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RowsBox
            // 
            this.RowsBox.BackColor = System.Drawing.Color.White;
            this.RowsBox.Location = new System.Drawing.Point(168, 42);
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
            this.RowsBox.Size = new System.Drawing.Size(120, 20);
            this.RowsBox.TabIndex = 1;
            this.RowsBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RowsBox.ValueChanged += new System.EventHandler(this.RowsBox_ValueChanged);
            // 
            // ColumnsBox
            // 
            this.ColumnsBox.BackColor = System.Drawing.Color.White;
            this.ColumnsBox.Location = new System.Drawing.Point(168, 61);
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
            this.ColumnsBox.Size = new System.Drawing.Size(120, 20);
            this.ColumnsBox.TabIndex = 2;
            this.ColumnsBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ColumnsBox.ValueChanged += new System.EventHandler(this.ColumnsBox_ValueChanged);
            // 
            // ActiveBox
            // 
            this.ActiveBox.DecimalPlaces = 1;
            this.ActiveBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ActiveBox.Location = new System.Drawing.Point(168, 115);
            this.ActiveBox.Name = "ActiveBox";
            this.ActiveBox.Size = new System.Drawing.Size(120, 20);
            this.ActiveBox.TabIndex = 3;
            this.ActiveBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ActiveBox.ValueChanged += new System.EventHandler(this.ActiveBox_ValueChanged);
            // 
            // InactiveBox
            // 
            this.InactiveBox.DecimalPlaces = 1;
            this.InactiveBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.InactiveBox.Location = new System.Drawing.Point(168, 134);
            this.InactiveBox.Name = "InactiveBox";
            this.InactiveBox.Size = new System.Drawing.Size(120, 20);
            this.InactiveBox.TabIndex = 4;
            this.InactiveBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.InactiveBox.ValueChanged += new System.EventHandler(this.InactiveBox_ValueChanged);
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(12, 44);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(34, 13);
            this.RowsLabel.TabIndex = 7;
            this.RowsLabel.Text = "Rows";
            // 
            // ColumnsLabel
            // 
            this.ColumnsLabel.AutoSize = true;
            this.ColumnsLabel.Location = new System.Drawing.Point(12, 63);
            this.ColumnsLabel.Name = "ColumnsLabel";
            this.ColumnsLabel.Size = new System.Drawing.Size(47, 13);
            this.ColumnsLabel.TabIndex = 8;
            this.ColumnsLabel.Text = "Columns";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(12, 84);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(66, 13);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "Lights Count";
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AutoSize = true;
            this.ActiveLabel.Location = new System.Drawing.Point(9, 117);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(103, 13);
            this.ActiveLabel.TabIndex = 10;
            this.ActiveLabel.Text = "Active Light Chance";
            // 
            // InactiveLabel
            // 
            this.InactiveLabel.AutoSize = true;
            this.InactiveLabel.Location = new System.Drawing.Point(9, 136);
            this.InactiveLabel.Name = "InactiveLabel";
            this.InactiveLabel.Size = new System.Drawing.Size(111, 13);
            this.InactiveLabel.TabIndex = 11;
            this.InactiveLabel.Text = "Inactive Light Chance";
            // 
            // DisabledLabel
            // 
            this.DisabledLabel.AutoSize = true;
            this.DisabledLabel.Location = new System.Drawing.Point(9, 157);
            this.DisabledLabel.Name = "DisabledLabel";
            this.DisabledLabel.Size = new System.Drawing.Size(114, 13);
            this.DisabledLabel.TabIndex = 12;
            this.DisabledLabel.Text = "Disabled Light Chance";
            // 
            // SizeBox
            // 
            this.SizeBox.BackColor = System.Drawing.Color.White;
            this.SizeBox.Location = new System.Drawing.Point(168, 81);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.ReadOnly = true;
            this.SizeBox.Size = new System.Drawing.Size(120, 20);
            this.SizeBox.TabIndex = 5;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "25";
            // 
            // DisabledBox
            // 
            this.DisabledBox.BackColor = System.Drawing.Color.White;
            this.DisabledBox.Location = new System.Drawing.Point(168, 154);
            this.DisabledBox.Name = "DisabledBox";
            this.DisabledBox.ReadOnly = true;
            this.DisabledBox.Size = new System.Drawing.Size(120, 20);
            this.DisabledBox.TabIndex = 6;
            this.DisabledBox.TabStop = false;
            this.DisabledBox.Text = "0.0 %";
            // 
            // RandomSizeButton
            // 
            this.RandomSizeButton.BackColor = System.Drawing.Color.Cornsilk;
            this.RandomSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomSizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RandomSizeButton.Location = new System.Drawing.Point(12, 192);
            this.RandomSizeButton.Name = "RandomSizeButton";
            this.RandomSizeButton.Size = new System.Drawing.Size(90, 23);
            this.RandomSizeButton.TabIndex = 5;
            this.RandomSizeButton.Text = "Random Size";
            this.RandomSizeButton.UseVisualStyleBackColor = false;
            this.RandomSizeButton.Click += new System.EventHandler(this.RandomSizeButton_Click);
            // 
            // RandomChanceButton
            // 
            this.RandomChanceButton.BackColor = System.Drawing.Color.Cornsilk;
            this.RandomChanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomChanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomChanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RandomChanceButton.Location = new System.Drawing.Point(108, 192);
            this.RandomChanceButton.Name = "RandomChanceButton";
            this.RandomChanceButton.Size = new System.Drawing.Size(90, 23);
            this.RandomChanceButton.TabIndex = 6;
            this.RandomChanceButton.Text = "Random Chance";
            this.RandomChanceButton.UseVisualStyleBackColor = false;
            this.RandomChanceButton.Click += new System.EventHandler(this.RandomChanceButton_Click);
            // 
            // RandomGameCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(300, 227);
            this.Controls.Add(this.RandomChanceButton);
            this.Controls.Add(this.RandomSizeButton);
            this.Controls.Add(this.DisabledBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.DisabledLabel);
            this.Controls.Add(this.InactiveLabel);
            this.Controls.Add(this.ActiveLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ColumnsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.InactiveBox);
            this.Controls.Add(this.ActiveBox);
            this.Controls.Add(this.ColumnsBox);
            this.Controls.Add(this.RowsBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DiagonalModeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RandomGameCreator";
            this.Text = "Random Game Creator";
            ((System.ComponentModel.ISupportInitialize)(this.RowsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InactiveBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DiagonalModeBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.NumericUpDown RowsBox;
        private System.Windows.Forms.NumericUpDown ColumnsBox;
        private FormattedUpDown ActiveBox;
        private FormattedUpDown InactiveBox;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label ColumnsLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.Label InactiveLabel;
        private System.Windows.Forms.Label DisabledLabel;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.TextBox DisabledBox;
        private System.Windows.Forms.Button RandomSizeButton;
        private System.Windows.Forms.Button RandomChanceButton;
    }
}