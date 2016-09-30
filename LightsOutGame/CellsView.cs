using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace LightsOutGame
{
    public class CellsView : Panel
    {
        private Cells model;
        public Cells Model
        {
            get { return model; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if(model != value)
                {
                    prevSelectedCell = new Point(-1, -1);
                    if (prevSelectedCell != selectedCell)
                    {
                        selectedCell = prevSelectedCell;
                        OnSelectedCellChanged(EventArgs.Empty);
                    }
                    
                    model = value;
                    ResizeToFit();
                }
            }
        }

        private int cellSize;
        public int CellSize
        {
            get { return cellSize; }
            set
            {
                if (value < 3) value = 3;
                if(cellSize != value)
                {
                    cellSize = value;
                    ResizeToFit();
                }
            }
        }

        private SolidBrush activeCellBrush;
        public Color ActiveCellColor
        {
            get { return activeCellBrush.Color; }
            set { activeCellBrush.Color = Color.FromArgb(255, value); }
        }

        private SolidBrush inactiveCellBrush;
        public Color InactiveCellColor
        {
            get { return inactiveCellBrush.Color; }
            set { inactiveCellBrush.Color = Color.FromArgb(255, value); }
        }

        private SolidBrush mousedOverFilter;
        public Color MousedOverFilterColor
        {
            get { return Color.FromArgb(255, mousedOverFilter.Color); }
            set { mousedOverFilter.Color = Color.FromArgb(100, value); }
        }

        private Pen cellBorderPen;
        public Color CellBorderColor
        {
            get { return cellBorderPen.Color; }
            set { cellBorderPen.Color = Color.FromArgb(255, value); }
        }

        private PictureBox box;
        private Graphics graphics;

        private Point prevSelectedCell;
        private Point selectedCell;
        public Point SelectedCell
        {
            get { return selectedCell; }
            set
            {
                if (value.X < 0 || value.X >= model.ColumnCount || value.Y < 0 || value.Y >= model.RowCount)
                    value = new Point(-1, -1);

                if (selectedCell != value)
                {
                    selectedCell = value;
                    UpdateDraw();
                    OnSelectedCellChanged(EventArgs.Empty);
                }
            }
        }

        public bool IsAnyCellSelected { get { return selectedCell.X >= 0; } }

        public event EventHandler SelectedCellChanged;

        public CellsView() : base()
        {
            BorderStyle = BorderStyle.None;
            BackColor = Color.Gray;
            AutoScroll = true;

            model = new Cells(0, 0);
            cellSize = 16;

            activeCellBrush = new SolidBrush(Color.Goldenrod);
            inactiveCellBrush = new SolidBrush(Color.Silver);
            mousedOverFilter = new SolidBrush(Color.FromArgb(100, Color.WhiteSmoke));
            cellBorderPen = new Pen(Color.Black, 1);

            box = new PictureBox();
            box.Location = Point.Empty;
            box.Size = Size.Empty;
            box.BorderStyle = BorderStyle.None;
            box.Parent = this;
            box.SizeChanged += Event_BoxSizeChanged;
            graphics = null;

            typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, box, new object[] { true });

            prevSelectedCell = new Point(-1, -1);
            SelectedCell = prevSelectedCell;
        }

        public void ResizeToFit()
        {
            box.Size = new Size(cellSize * model.ColumnCount + 1, cellSize * model.RowCount + 1);
            Redraw();
            MoveBoxToCenter();
        }

        public void Redraw()
        {
            int rCount = model.RowCount;
            int cCount = model.ColumnCount;

            int w = cellSize;
            int h = cellSize;
            int wm1 = w - 1;
            int hm1 = h - 1;

            for (int r = 0; r < rCount; ++r)
            {
                int y = r * h;
                int yp1 = y + 1;

                for (int c = 0; c < cCount; ++c)
                {
                    int x = c * w;
                    graphics.DrawRectangle(cellBorderPen, x, y, w, h);
                    graphics.FillRectangle(DetermineCellBrush(model[r, c]), x + 1, yp1, wm1, hm1);
                }
            }
            DrawMousedOverCell();
            box.Refresh();
        }

        public void UpdateDraw()
        {
            if(selectedCell != prevSelectedCell)
            {
                if (prevSelectedCell.X >= 0)
                {
                    Rectangle rect = new Rectangle(prevSelectedCell.X * cellSize + 1, prevSelectedCell.Y * cellSize + 1, cellSize - 1, cellSize - 1);
                    graphics.FillRectangle(DetermineCellBrush(model[prevSelectedCell.Y, prevSelectedCell.X]), rect);
                }
                prevSelectedCell = selectedCell;

                DrawMousedOverCell();
                box.Refresh();
            }
        }

        private void DrawMousedOverCell()
        {
            if (IsAnyCellSelected)
            {
                Rectangle rect = new Rectangle(selectedCell.X * cellSize + 1, selectedCell.Y * cellSize + 1, cellSize - 1, cellSize - 1);
                graphics.FillRectangle(mousedOverFilter, rect);
            }
        }

        private Brush DetermineCellBrush(CellType type)
        {
            return (type == CellType.Inactive) ? inactiveCellBrush : (type == CellType.Active) ? activeCellBrush : cellBorderPen.Brush;
        }

        protected virtual void OnSelectedCellChanged(EventArgs e)
        {
            if (SelectedCellChanged != null) SelectedCellChanged(this, e);
        }

        private void MoveBoxToCenter()
        {
            AutoScrollPosition = new Point(0, 0);
            box.Location = new Point((Width > box.Width) ? (Width >> 1) - (box.Width >> 1) : 0,
                                    (Height > box.Height) ? (Height >> 1) - (box.Height >> 1) : 0);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            MoveBoxToCenter();
        }

        private void Event_BoxSizeChanged(object sender, EventArgs e)
        {
            box.Image = new Bitmap(box.Width, box.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);  // an awful and temporary solution!!!
            graphics = Graphics.FromImage(box.Image);                                                           // for 40 x 40 cell matrix with x6 zoom
            GC.Collect();                                                                                       // the bmp will consist of 14 753 281 pixels! (around 56MB)
        }
    }
}
