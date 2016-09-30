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
    public partial class SettingsForm : Form
    {
        private CellsView[] cells;

        public event EventHandler Confirmed;

        public SettingsForm(CellsView[] views)
        {
            if (views == null || views.Length == 0) throw new ArgumentNullException();
            InitializeComponent();
            try { Icon = new System.Drawing.Icon("..\\..\\Bulb.ico"); } catch (Exception) { }
            
            cells = views;
            ActivePanel.BackColor = cells[0].ActiveCellColor;
            InactivePanel.BackColor = cells[0].InactiveCellColor;
            BorderPanel.BackColor = cells[0].CellBorderColor;
            HighlightPanel.BackColor = cells[0].MousedOverFilterColor;
        }

        protected virtual void OnConfirmed(EventArgs e)
        {
            if (Confirmed != null) Confirmed(this, e);
        }

        private void ActivePanel_MouseClick(object sender, MouseEventArgs e)
        {
            SetPanelBackColor(ActivePanel);
        }

        private void InactivePanel_MouseClick(object sender, MouseEventArgs e)
        {
            SetPanelBackColor(InactivePanel);
        }

        private void BorderPanel_MouseClick(object sender, MouseEventArgs e)
        {
            SetPanelBackColor(BorderPanel);
        }

        private void HighlightPanel_MouseClick(object sender, MouseEventArgs e)
        {
            SetPanelBackColor(HighlightPanel);
        }

        private void SetPanelBackColor(Panel panel)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    panel.BackColor = dialog.Color;
            }
        }

        private void ActivePanel_BackColorChanged(object sender, EventArgs e)
        {
            HighlightActivePanel.BackColor = ActivePanel.BackColor;
            HighlightActivePanel.Refresh();
        }

        private void InactivePanel_BackColorChanged(object sender, EventArgs e)
        {
            HighlightInactivePanel.BackColor = InactivePanel.BackColor;
            HighlightInactivePanel.Refresh();
        }

        private void HighlightPanel_BackColorChanged(object sender, EventArgs e)
        {
            HighlightActivePanel.Refresh();
            HighlightInactivePanel.Refresh();
        }

        private void HighlightActivePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, HighlightPanel.BackColor)), 0, 0, HighlightActivePanel.Width, HighlightActivePanel.Height);
        }

        private void HighlightInactivePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, HighlightPanel.BackColor)), 0, 0, HighlightInactivePanel.Width, HighlightInactivePanel.Height);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cells.Length; ++i)
            {
                cells[i].ActiveCellColor = ActivePanel.BackColor;
                cells[i].InactiveCellColor = InactivePanel.BackColor;
                cells[i].CellBorderColor = BorderPanel.BackColor;
                cells[i].MousedOverFilterColor = HighlightPanel.BackColor;
                cells[i].Redraw();
            }
            OnConfirmed(EventArgs.Empty);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Hide();
        }
    }
}
