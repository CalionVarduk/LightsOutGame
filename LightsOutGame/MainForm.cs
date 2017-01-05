using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LightsOutGame
{
    public partial class MainForm : Form
    {
        private CellsGameController Cells;
        private SettingsForm Settings;
        private LevelEditorForm LevelEditor;

        public MainForm()
        {
            InitializeComponent();
            try { Icon = new System.Drawing.Icon("..\\..\\Bulb.ico"); } catch (Exception) { }

            Cells = new CellsGameController();
            Cells.View.Location = new Point(0, MenuStrip.Height);
            Cells.View.Parent = this;
            Cells.ZoomLevelChanged += Event_ZoomChanged;
            Cells.CellClicked += Event_CellClicked;
            Cells.SelectedCellChanged += Event_SelectionChanged;
            Cells.TimerTick += Event_TimerTick;

            LevelEditor = new LevelEditorForm();
            Settings = new SettingsForm(new CellsView[] { Cells.View, LevelEditor.CellsEditorController.View });
            Settings.Confirmed += LevelEditor.UpdatePanelColors;

            ClientSize = new Size(750, 500);
            MinimumSize = Size;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(Cells != null) Cells.View.Size = new Size(ClientSize.Width, ClientSize.Height - StatusStrip.Height - Cells.View.Top);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus) Cells.ZoomIn();
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus) Cells.ZoomOut();
        }

        private void Event_ZoomChanged(object sender, EventArgs e)
        {
            ZoomValStatusLabel.Text = "x" + Cells.ZoomLevel.ToString();
            ZoomValStatusLabel.Invalidate();
        }

        private void Event_CellClicked(object sender, RedrawEventArgs e)
        {
            Toolbox.GameSaved = false;
            LightsValStatusLabel.Text = Cells.Model.CellsActive.ToString() + " / " + Cells.Model.CellsEnabled.ToString();
            MovesValStatusLabel.Text = Cells.MovesPerformed.ToString();
            LightsValStatusLabel.Invalidate();
            MovesValStatusLabel.Invalidate();

            if (Cells.GameWon)
            {
                UpdateTimeLabel();
                MessageBox.Show("Congratulations, you have won the game!", "Victory!");
            }
        }

        private void Event_TimerTick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }

        private void Event_SelectionChanged(object sender, EventArgs e)
        {
            Toolbox.UpdateHighlightLabel(Cells, HighlightStatusLabel, HighlightValStatusLabel);
        }

        private void UpdateTimeLabel()
        {
            long elapsed = Cells.ElapsedMs;
            int ms = (int)(elapsed % 1000);
            long s = elapsed / 1000;

            TimeValStatusLabel.Text = s.ToString() + "." + ms.ToString("000") + " s";
            TimeValStatusLabel.Invalidate();
        }

        private void NewRandomGameMenuButton_Click(object sender, EventArgs e)
        {
            using (RandomModelCreator creator = new RandomModelCreator())
            {
                if(creator.ShowDialog() == DialogResult.OK)
                {
                    Cells.EndGame();
                    Cells.Model = creator.Model;
                    InitializeNewGame(0, 0);
                }
            }
        }

        private void NewEditorGameMenuButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Lights Out Level File (.cvlolvl)|*" + CellsIO.EditorExtension })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cells model = null;
                    if (CellsIO.LoadLevelFromFile(ref model, dialog.FileName))
                    {
                        Cells.EndGame();
                        Cells.Model = model;
                        InitializeNewGame(0, 0);
                    }
                }
            }
        }

        private void LoadGameMenuButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Lights Out Game File (.cvlo)|*" + CellsIO.GameExtension })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cells model = null;
                    long ms = 0;
                    int moves = 0;

                    if (CellsIO.LoadGameFromFile(ref model, ref ms, ref moves, dialog.FileName))
                    {
                        Cells.EndGame();
                        Cells.Model = model;
                        InitializeNewGame(ms, moves);
                    }
                }
            }
        }

        private void InitializeNewGame(long msOffset, int movesOffset)
        {
            Toolbox.GameSaved = false;
            Cells.StartGame(msOffset, movesOffset);

            UpdateTimeLabel();
            Toolbox.UpdateHighlightLabel(Cells, HighlightStatusLabel, HighlightValStatusLabel);
            MovesValStatusLabel.Text = Cells.MovesPerformed.ToString();
            LightsValStatusLabel.Text = Cells.Model.CellsActive.ToString() + " / " + Cells.Model.CellsEnabled.ToString();

            TimeStatusLabel.Visible = true;
            TimeValStatusLabel.Visible = true;
            LightsStatusLabel.Visible = true;
            LightsValStatusLabel.Visible = true;
            MovesStatusLabel.Visible = true;
            MovesValStatusLabel.Visible = true;
        }

        private void SaveGameMenuButton_Click(object sender, EventArgs e)
        {
            long ms = Cells.ElapsedMs;

            using (SaveFileDialog dialog = new SaveFileDialog() { Filter = "Lights Out Game File (.cvlo)|*" + CellsIO.GameExtension })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (CellsIO.SaveGameToFile(Cells.Model, ms, Cells.MovesPerformed, dialog.FileName))
                        Toolbox.GameSaved = true;
                }
            }
        }

        private void EditorMenuButton_Click(object sender, EventArgs e)
        {
            Toolbox.ShowSecondaryForm(LevelEditor);
        }

        private void SettingsMenuButton_Click(object sender, EventArgs e)
        {
            Toolbox.ShowSecondaryForm(Settings);
        }

        private void AboutMenuButton_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Toolbox.GameSaved)
            {
                if(!Toolbox.LevelSaved)
                {
                    if (MessageBox.Show("The game state and Level Editor have some unsaved changes." + Environment.NewLine + "Do you want to close anyway?", "Close", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        e.Cancel = true;
                }
                else
                {
                    if (MessageBox.Show("The game state has some unsaved changes. Do you want to close anyway?", "Close", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        e.Cancel = true;
                }
            }
            else if (!Toolbox.LevelSaved)
            {
                if (MessageBox.Show("Level Editor has some unsaved changes. Do you want to close anyway?", "Close", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}
