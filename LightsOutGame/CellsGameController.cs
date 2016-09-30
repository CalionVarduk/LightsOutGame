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
    public class CellsGameController : CellsController
    {
        private Timer timer;
        private Stopwatch watch;
        private long msOffset;
        public long ElapsedMs { get { return msOffset + watch.ElapsedMilliseconds; } }

        public int MovesPerformed { get; private set; }
        public bool GameInProgress { get { return watch.IsRunning; } }
        public bool GameWon { get { return Model.CellsActive == 0; } }

        public event EventHandler TimerTick
        {
            add { timer.Tick += value; }
            remove { timer.Tick -= value; }
        }

        public CellsGameController() : base()
        {
            msOffset = 0;
            MovesPerformed = 0;

            watch = new Stopwatch();
            timer = new Timer();
            timer.Interval = 15;
        }

        public void StartGame(long msOffset, int movesOffset)
        {
            this.msOffset = (msOffset > 0) ? msOffset : 0;
            MovesPerformed = (movesOffset > 0) ? movesOffset : 0;
            watch.Restart();
            timer.Start();
        }

        public void EndGame()
        {
            timer.Stop();
            watch.Stop();
        }

        protected override void OnCellClicked(RedrawEventArgs e)
        {
            if (!GameWon && Model[view.SelectedCell.Y, view.SelectedCell.X] != CellType.Disabled)
            {
                Model.FlipCell(view.SelectedCell.Y, view.SelectedCell.X);
                ++MovesPerformed;

                if (GameWon)
                {
                    e.PerformRedraw = false;
                    EndGame();
                    view.Redraw();
                }
            }

            base.OnCellClicked(e);
        }
    }
}
