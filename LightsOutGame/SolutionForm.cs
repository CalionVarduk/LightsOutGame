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
    public partial class SolutionForm : Form
    {
        private CellsEditorController Cells;
        private Solver Solver;
        public bool HasSolution { get { return Solver.HasSolution; } }
        public bool IsSolving { get { return Solver.IsWorking; } }

        public event EventHandler SolvingEnded
        {
            add { Solver.SolvingEnded += value; }
            remove { Solver.SolvingEnded -= value; }
        }

        public SolutionForm()
        {
            InitializeComponent();
            try { Icon = new System.Drawing.Icon("..\\..\\Bulb.ico"); } catch (Exception) { }

            Solver = new Solver();
            Solver.SolvingStarted += Event_SolvingStarted;
            Solver.SolvingEnded += Event_SolvingEnded;

            Cells = new CellsEditorController();
            Cells.View.ActiveCellColor = Color.DodgerBlue;
            Cells.View.InactiveCellColor = Color.WhiteSmoke;
            Cells.View.MousedOverFilterColor = Color.Silver;
            Cells.View.Location = new Point(0, SolLabel.Bottom + 10);
            Cells.View.Parent = this;
            Cells.ZoomLevelChanged += Event_ZoomChanged;
            Cells.SelectedCellChanged += Event_SelectionChanged;

            ClientSize = new Size(750, 500);
            MinimumSize = Size;
        }

        public void Solve(Cells puzzle, bool diagonalNeighbourMode)
        {
            if (Solver.IsWorking) MessageBox.Show("Solving already in progress.", "Solving Info");
            else
            {
                Solver.DiagonalNeighbourMode = diagonalNeighbourMode;
                Solver.Puzzle = puzzle;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SolLabel.Left = (ClientSize.Width >> 1) - (SolLabel.Width >> 1);
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

        private void Event_SelectionChanged(object sender, EventArgs e)
        {
            Toolbox.UpdateHighlightLabel(Cells, HighlightStatusLabel, HighlightValStatusLabel);
            if (Cells.View.IsAnyCellSelected)
                Cells.ChosenType = Cells.Model[Cells.View.SelectedCell.Y, Cells.View.SelectedCell.X];
        }

        private void Event_SolvingStarted(object sender, EventArgs e)
        {
            Cells.Model = new Cells(0, 0);

            SolLabel.Text = "Solving...";
            SolLabel.Left = (ClientSize.Width >> 1) - (SolLabel.Width >> 1);
            SolLabel.Refresh();

            MovesStatusLabel.Visible = false;
            MovesValStatusLabel.Visible = false;
        }

        private void Event_SolvingEnded(object sender, EventArgs e)
        {
            if (Solver.HasSolution)
            {
                SolLabel.Text = "Clicking blue cells will solve your puzzle! (Solving time: " + Solver.TimeTaken.ToString("N0") + " ms)";
                SolLabel.Left = (ClientSize.Width >> 1) - (SolLabel.Width >> 1);
                SolLabel.Refresh();

                MovesValStatusLabel.Text = Solver.Solution.CellsActive.ToString();
                MovesStatusLabel.Visible = true;
                MovesValStatusLabel.Visible = true;

                Cells.Model = Solver.Solution;
            }
            else
            {
                SolLabel.Text = "Your puzzle has no solution!";
                SolLabel.Left = (ClientSize.Width >> 1) - (SolLabel.Width >> 1);
                SolLabel.Refresh();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Hide();
        }
    }
}
