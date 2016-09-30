using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;

namespace LightsOutGame
{
    public abstract class CellsController
    {
        protected CellsView view;
        public CellsView View
        {
            get { return view; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (view != value)
                {
                    UnsubscribeView();
                    view = value;
                    SubscribeView();
                }
            }
        }

        public Cells Model
        {
            get { return view.Model; }
            set { view.Model = value; }
        }

        private float minZoom;
        private float maxZoom;

        public float MinZoomLevel { get { return minZoom * 0.0625f; } }
        public float MaxZoomLevel { get { return maxZoom * 0.0625f; } }
        public float ZoomLevel { get { return view.CellSize * 0.0625f; } }

        private PictureBox InternalViewBox
        {
            get { return (PictureBox)view.GetType().GetField("box", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(view); }
        }

        public event EventHandler ZoomLevelChanged;
        public event RedrawEventHandler CellClicked;
        public event EventHandler SelectedCellChanged
        {
            add { view.SelectedCellChanged += value; }
            remove { view.SelectedCellChanged -= value; }
        }

        protected CellsController()
        {
            minZoom = 4;
            maxZoom = 96;

            view = new CellsView();
            SubscribeView();
        }

        public void ZoomIn()
        {
            if (view.CellSize < maxZoom)
            {
                view.SelectedCell = new Point(-1, -1);
                view.CellSize += 2;
                OnZoomLevelChanged(EventArgs.Empty);
            }
        }

        public void ZoomOut()
        {
            if (view.CellSize > minZoom)
            {
                view.SelectedCell = new Point(-1, -1);
                view.CellSize -= 2;
                OnZoomLevelChanged(EventArgs.Empty);
            }
        }

        protected virtual void OnZoomLevelChanged(EventArgs e)
        {
            if (ZoomLevelChanged != null) ZoomLevelChanged(this, e);
        }

        protected virtual void OnCellClicked(RedrawEventArgs e)
        {
            if (CellClicked != null) CellClicked(this, e);
        }

        private void SubscribeView()
        {
            PictureBox box = InternalViewBox;
            box.MouseDown += Event_ViewMouseDown;
            box.MouseMove += Event_ViewMouseMove;
            box.MouseLeave += Event_ViewMouseLeave;
        }

        private void UnsubscribeView()
        {
            PictureBox box = InternalViewBox;
            box.MouseDown -= Event_ViewMouseDown;
            box.MouseMove -= Event_ViewMouseMove;
            box.MouseLeave -= Event_ViewMouseLeave;
        }

        private void Event_ViewMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && view.IsAnyCellSelected)
            {
                RedrawEventArgs re = new RedrawEventArgs(true);
                OnCellClicked(re);
                if (re.PerformRedraw) view.Redraw();
            }
        }

        private void Event_ViewMouseMove(object sender, MouseEventArgs e)
        {
            view.SelectedCell = (e.X > 0 && e.Y > 0) ? new Point(e.X / view.CellSize, e.Y / view.CellSize) : new Point(-1, -1);
        }

        private void Event_ViewMouseLeave(object sender, EventArgs e)
        {
            view.SelectedCell = new Point(-1, -1);
        }
    }
}
