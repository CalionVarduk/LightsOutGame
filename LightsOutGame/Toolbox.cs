using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOutGame
{
    public static class Toolbox
    {
        public static bool GameSaved { get; set; }
        public static bool LevelSaved { get; set; }

        static Toolbox()
        {
            GameSaved = true;
            LevelSaved = true;
        }

        public static void ShowSecondaryForm(Form form)
        {
            if (!form.Visible)
                form.Show();
            else
            {
                form.Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        public static void UpdateHighlightLabel(CellsController cells, ToolStripStatusLabel title, ToolStripStatusLabel label)
        {
            if (cells.View.IsAnyCellSelected)
            {
                label.Text = "[" + (cells.View.SelectedCell.Y + 1).ToString() + ", " + (cells.View.SelectedCell.X + 1).ToString() + "]";
                title.Visible = true;
                label.Visible = true;
            }
            else
            {
                title.Visible = false;
                label.Visible = false;
            }
        }
    }
}
