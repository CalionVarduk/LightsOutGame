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
    public partial class FormattedUpDown : NumericUpDown
    {
        public FormattedUpDown()
        {
            InitializeComponent();
        }

        protected override void UpdateEditText()
        {
            Text = String.Format("{0:0.0} %", Value);
            //base.UpdateEditText();
        }
    }
}
