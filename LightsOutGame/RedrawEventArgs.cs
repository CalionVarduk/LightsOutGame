using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOutGame
{
    public class RedrawEventArgs : EventArgs
    {
        public bool PerformRedraw { get; set; }

        public RedrawEventArgs(bool performRedraw)
        {
            PerformRedraw = performRedraw;
        }
    }

    public delegate void RedrawEventHandler(object sender, RedrawEventArgs e);
}
