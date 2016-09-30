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
    public partial class RandomModelCreator : Form
    {
        private Solver solver;
        private Random rng;
        private decimal disabledLightChance;

        public bool DiagonalNeighbourMode { get { return DiagonalModeBox.Checked; } }

        public int RowCount { get { return (int)RowsBox.Value; } }
        public int ColumnCount { get { return (int)ColumnsBox.Value; } }
        public int LightsCount { get { return RowCount * ColumnCount; } }

        public decimal ActiveLightChance { get { return ActiveBox.Value; } }
        public decimal InactiveLightChance { get { return InactiveBox.Value; } }
        public decimal DisabledLightChance { get { return disabledLightChance; } }
        public decimal EnabledLightChance { get { return ActiveLightChance + InactiveLightChance; } }

        public Cells Model { get; private set; }
        public bool IsModelCreated { get { return Model != null; } }

        public RandomModelCreator()
        {
            InitializeComponent();
            try { Icon = new System.Drawing.Icon("..\\..\\Bulb.ico"); } catch (Exception) { }
            
            DialogResult = DialogResult.Abort;
            Model = null;
            rng = new Random();
            disabledLightChance = 0;

            solver = new Solver();
            solver.SolvingEnded += Event_SolvingEnded;
        }

        private void RowsBox_ValueChanged(object sender, EventArgs e)
        {
            SizeBox.Text = LightsCount.ToString();
        }

        private void ColumnsBox_ValueChanged(object sender, EventArgs e)
        {
            SizeBox.Text = LightsCount.ToString();
        }

        private void ActiveBox_ValueChanged(object sender, EventArgs e)
        {
            FixChancePercentage(InactiveBox);
        }

        private void InactiveBox_ValueChanged(object sender, EventArgs e)
        {
            FixChancePercentage(ActiveBox);
        }

        private void FixChancePercentage(NumericUpDown otherUpDown)
        {
            decimal diff = 100m - EnabledLightChance - disabledLightChance;

            if (diff > 0)
            {
                disabledLightChance += diff;
                UpdateDisabledBoxText();
            }
            else if (diff < 0)
            {
                if (disabledLightChance >= -diff)
                {
                    disabledLightChance += diff;
                    UpdateDisabledBoxText();
                }
                else
                {
                    if (disabledLightChance > 0)
                    {
                        diff += disabledLightChance;
                        disabledLightChance = 0;
                        UpdateDisabledBoxText();
                    }
                    otherUpDown.Value += diff;
                }
            }
        }

        private void UpdateDisabledBoxText()
        {
            DisabledBox.Text = String.Format("{0:0.0} %", disabledLightChance);
        }

        private void RandomSizeButton_Click(object sender, EventArgs e)
        {
            RowsBox.Value = rng.Next((int)RowsBox.Minimum, (int)RowsBox.Maximum + 1);
            ColumnsBox.Value = rng.Next((int)ColumnsBox.Minimum, (int)ColumnsBox.Maximum + 1);
        }

        private void RandomChanceButton_Click(object sender, EventArgs e)
        {
            ActiveBox.Value = 0;
            InactiveBox.Value = 0;

            int active = rng.Next(0, 1001);
            int inactive = rng.Next(0, 1001);
            int disabled = rng.Next(0, 1001);
            decimal all = (active + inactive + disabled) * 0.01m;

            ActiveBox.Value = Math.Round(active / all, 1);
            InactiveBox.Value = Math.Round(inactive / all, 1);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ActiveLightChance == 0)
                MessageBox.Show("Active Light Chance must be greater than 0%.", "Game Creator Error");
            else
            {
                Cursor = Cursors.WaitCursor;
                CreateModel();
            }
        }

        private void CreateModel()
        {
            int firstInactive = (int)(ActiveLightChance * 10);
            int firstDisabled = firstInactive + (int)(InactiveLightChance * 10);

            int rCount = RowCount;
            int cCount = ColumnCount;

            CellType[,] values = new CellType[rCount, cCount];
            int activeCount = 0;

            while (activeCount == 0)
            {
                for (int i = 0; i < rCount; ++i)
                {
                    for (int j = 0; j < cCount; ++j)
                    {
                        int rand = rng.Next(0, 1000);

                        if (rand < firstInactive)
                        {
                            values[i, j] = CellType.Active;
                            ++activeCount;
                        }
                        else if (rand < firstDisabled)
                            values[i, j] = CellType.Inactive;
                        else
                            values[i, j] = CellType.Disabled;
                    }
                }
            }

            Model = new Cells(RowCount, ColumnCount);
            Model.Initialize(values, DiagonalNeighbourMode);
            solver.DiagonalNeighbourMode = DiagonalNeighbourMode;
            solver.Puzzle = Model;
        }

        private void Event_SolvingEnded(object sender, EventArgs e)
        {
            if (solver.HasSolution)
            {
                Cursor = Cursors.Default;
                DialogResult = DialogResult.OK;
                Close();
            }
            else CreateModel();
        }
    }
}
