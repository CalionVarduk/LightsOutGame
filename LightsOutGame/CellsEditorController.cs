using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LightsOutGame
{
    public class CellsEditorController : CellsController
    {
        private CellType chosenType;
        public CellType ChosenType
        {
            get { return chosenType; }
            set
            {
                if(chosenType != value)
                {
                    chosenType = value;
                    OnChosenTypeChanged(EventArgs.Empty);
                }
            }
        }

        public event EventHandler ChosenTypeChanged;

        public CellsEditorController() : base()
        {
            chosenType = CellType.Inactive;
        }

        public void Resize(int rowCount, int columnCount)
        {
            int rCountOld = Model.RowCount;
            int cCountOld = Model.ColumnCount;

            CellType[,] oldValues = new CellType[rCountOld, cCountOld];
            for (int i = 0; i < rCountOld; ++i)
                for (int j = 0; j < cCountOld; ++j)
                    oldValues[i, j] = Model[i, j];

            int rLimit = Math.Min(rCountOld, rowCount);
            int cLimit = Math.Min(cCountOld, columnCount);

            Cells model = new Cells(rowCount, columnCount);
            for (int i = 0; i < rLimit; ++i)
                for (int j = 0; j < cLimit; ++j)
                    model[i, j] = oldValues[i, j];

            View.SelectedCell = new Point(-1, -1);
            Model = model;
        }

        protected virtual void OnChosenTypeChanged(EventArgs e)
        {
            if (ChosenTypeChanged != null) ChosenTypeChanged(this, e);
        }

        protected override void OnCellClicked(RedrawEventArgs e)
        {
            if (Model[view.SelectedCell.Y, view.SelectedCell.X] == chosenType) e.PerformRedraw = false;
            else Model[view.SelectedCell.Y, view.SelectedCell.X] = chosenType;

            base.OnCellClicked(e);
        }
    }
}
