using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOutGame
{
    public partial class LevelEditorForm : Form
    {
        private CellsEditorController Cells;
        public CellsEditorController CellsEditorController { get { return Cells; } }

        private bool saveFlag;
        private bool updateFlag;
        private Pen panelPen;
        private SolutionForm SolutionForm;

        public LevelEditorForm()
        {
            InitializeComponent();
            try { Icon = new System.Drawing.Icon("..\\..\\Bulb.ico"); } catch (Exception) { }
            updateFlag = true;
            saveFlag = false;
            panelPen = new Pen(Color.DodgerBlue, 4);

            SolutionForm = new SolutionForm();
            SolutionForm.SolvingEnded += Event_SolveSaveCheck;

            Cells = new CellsEditorController();
            Cells.Model = new Cells(5, 5);
            Cells.View.Location = new Point(0, MenuStrip.Height + 30);
            Cells.View.Parent = this;
            Cells.ZoomLevelChanged += Event_ZoomChanged;
            Cells.CellClicked += Event_CellClicked;
            Cells.SelectedCellChanged += Event_SelectionChanged;

            UpdatePanelColors(null, null);

            LightsValStatusLabel.Text = Cells.Model.CellCount.ToString();
            UpdateLightLabels();

            ClientSize = new Size(750, 500);
            MinimumSize = Size;
        }

        public void UpdatePanelColors(object sender, EventArgs e)
        {
            ActivePanel.BackColor = Cells.View.ActiveCellColor;
            InactivePanel.BackColor = Cells.View.InactiveCellColor;
            DisabledPanel.BackColor = Cells.View.CellBorderColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(Cells != null) Cells.View.Size = new Size(ClientSize.Width, ClientSize.Height - StatusStrip.Height - Cells.View.Top);
        }

        private void Event_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                Cells.ZoomIn();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                Cells.ZoomOut();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Event_ZoomChanged(object sender, EventArgs e)
        {
            ZoomValStatusLabel.Text = "x" + Cells.ZoomLevel.ToString();
            ZoomValStatusLabel.Invalidate();
        }

        private void Event_CellClicked(object sender, RedrawEventArgs e)
        {
            Toolbox.LevelSaved = false;
            UpdateLightLabels();
        }

        private void Event_SelectionChanged(object sender, EventArgs e)
        {
            Toolbox.UpdateHighlightLabel(Cells, HighlightStatusLabel, HighlightValStatusLabel);
        }

        private void UpdateLightLabels()
        {
            ActiveValStatusLabel.Text = Cells.Model.CellsActive.ToString();
            InactiveValStatusLabel.Text = Cells.Model.CellsInactive.ToString();
            DisabledValStatusLabel.Text = Cells.Model.CellsDisabled.ToString();
            ActiveValStatusLabel.Invalidate();
            InactiveValStatusLabel.Invalidate();
            DisabledValStatusLabel.Invalidate();
        }

        private void LoadMenuButton_Click(object sender, EventArgs e)
        {
            if (Toolbox.LevelSaved || UnsavedLoadMessage())
            {
                using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Lights Out Level File (.cvlolvl)|*" + CellsIO.EditorExtension })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Cells model = null;
                        if (CellsIO.LoadLevelFromFile(ref model, dialog.FileName))
                        {
                            updateFlag = false;
                            Toolbox.LevelSaved = true;
                            Cells.Model = model;
                            DiagonalModeBox.Checked = Cells.Model.DiagonalNeighbourMode;
                            UpdateLightLabels();
                            Toolbox.UpdateHighlightLabel(Cells, HighlightStatusLabel, HighlightValStatusLabel);
                            LightsValStatusLabel.Text = Cells.Model.CellCount.ToString();
                            LightsValStatusLabel.Invalidate();
                            RowsBox.Value = Cells.Model.RowCount;
                            ColumnsBox.Value = Cells.Model.ColumnCount;
                            updateFlag = true;
                        }
                    }
                }
            }
        }

        private bool UnsavedLoadMessage()
        {
            return MessageBox.Show("Current level has some unsaved changes. Do you want to continue anyway?", "Load Level", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            if (Cells.Model.CellsActive == 0)
                MessageBox.Show("Level must have at least one active light.", "Level Editor Error");
            else if (!Toolbox.LevelSaved)
            {
                Cursor = Cursors.WaitCursor;
                saveFlag = true;
                
                if (!SolutionForm.IsSolving)                                        // smells like race condition... is this weird solutionform on-save-update really necessary?
                    SolutionForm.Solve(Cells.Model, DiagonalModeBox.Checked);
            }
            else SaveLevel();
        }

        private void SaveLevel()
        {
            using (SaveFileDialog dialog = new SaveFileDialog() { Filter = "Lights Out Level File (.cvlolvl)|*" + CellsIO.EditorExtension })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (CellsIO.SaveLevelToFile(Cells.Model, DiagonalModeBox.Checked, dialog.FileName))
                        Toolbox.LevelSaved = true;
                }
            }
        }

        private void Event_SolveSaveCheck(object sender, EventArgs e)
        {
            if(saveFlag)
            {
                saveFlag = false;
                Cursor = Cursors.Default;

                if (SolutionForm.HasSolution)
                    SaveLevel();
                else MessageBox.Show("Your level must have a solution!", "Level Editor Error");
            }
        }

        private void SolutionMenuButton_Click(object sender, EventArgs e)
        {
            Toolbox.ShowSecondaryForm(SolutionForm);
            SolutionForm.Solve(Cells.Model, DiagonalModeBox.Checked);
        }

        private void RowsBox_ValueChanged(object sender, EventArgs e)
        {
            if (updateFlag) UpdateCellsCount();
        }

        private void ColumnsBox_ValueChanged(object sender, EventArgs e)
        {
            if (updateFlag) UpdateCellsCount();
        }

        private void UpdateCellsCount()
        {
            Toolbox.LevelSaved = false;
            Cells.Resize((int)RowsBox.Value, (int)ColumnsBox.Value);

            LightsValStatusLabel.Text = Cells.Model.CellCount.ToString();
            LightsValStatusLabel.Invalidate();
            UpdateLightLabels();
            Toolbox.UpdateHighlightLabel(Cells, HighlightStatusLabel, HighlightValStatusLabel);
        }

        private void ActivePanel_MouseDown(object sender, MouseEventArgs e)
        {
            Cells.ChosenType = CellType.Active;
            TypeValLabel.Text = "Active";
            TypeValLabel.Invalidate();
            Refresh();
        }

        private void InactivePanel_MouseDown(object sender, MouseEventArgs e)
        {
            Cells.ChosenType = CellType.Inactive;
            TypeValLabel.Text = "Inactive";
            TypeValLabel.Invalidate();
            Refresh();
        }

        private void DisabledPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Cells.ChosenType = CellType.Disabled;
            TypeValLabel.Text = "Disabled";
            TypeValLabel.Invalidate();
            Refresh();
        }

        private void DiagonalModeBox_CheckedChanged(object sender, EventArgs e)
        {
            Toolbox.LevelSaved = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if(Cells.ChosenType == CellType.Active)
                e.Graphics.DrawRectangle(panelPen, ActivePanel.Bounds);
            else if(Cells.ChosenType == CellType.Inactive)
                e.Graphics.DrawRectangle(panelPen, InactivePanel.Bounds);
            else
                e.Graphics.DrawRectangle(panelPen, DisabledPanel.Bounds);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SolutionForm.Hide();
            e.Cancel = true;
            Hide();
        }
    }
}
