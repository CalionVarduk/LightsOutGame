using System;

namespace LightsOutGame
{
    public enum CellType { Active, Inactive, Disabled }

    public class Cells
    {
        private CellType[,] cells;
        public CellType this[int row, int column]
        {
            get { return cells[row, column]; }
            set
            {
                if(cells[row, column] != value)
                {
                    if(cells[row, column] == CellType.Inactive)
                    {
                        if (value == CellType.Active) ++CellsActive;
                        else ++CellsDisabled;
                    }
                    else if(cells[row, column] == CellType.Active)
                    {
                        --CellsActive;
                        if (value == CellType.Disabled) ++CellsDisabled;
                    }
                    else
                    {
                        --CellsDisabled;
                        if (value == CellType.Active) ++CellsActive;
                    }
                    cells[row, column] = value;
                }
            }
        }

        public bool DiagonalNeighbourMode { get; private set; }
        public int CellsActive { get; private set; }
        public int CellsInactive { get { return CellsEnabled - CellsActive; } }
        public int CellsDisabled { get; private set; }
        public int CellsEnabled { get { return CellCount - CellsDisabled; } }

        public int RowCount { get { return cells.GetLength(0); } }
        public int ColumnCount { get { return cells.GetLength(1); } }
        public int CellCount { get { return cells.Length; } }

        public Cells(int rows, int columns)
        {
            cells = new CellType[rows, columns];

            CellsActive = CellCount;
            CellsDisabled = 0;
            DiagonalNeighbourMode = false;
        }

        public Cells Clone()
        {
            Cells clone = (Cells)MemberwiseClone();

            clone.cells = new CellType[RowCount, ColumnCount];
            for (int i = 0; i < RowCount; ++i)
                for (int j = 0; j < ColumnCount; ++j)
                    clone.cells[i, j] = cells[i, j];

            return clone;
        }

        public void Initialize(CellType[,] startValues, bool diagonalNeighbourMode)
        {
            int rCount = RowCount;
            int cCount = ColumnCount;

            if (rCount != startValues.GetLength(0) || cCount != startValues.GetLength(1))
                throw new ArgumentException("startValues array has wrong row and/or column count.");

            CellsActive = 0;
            CellsDisabled = 0;

            for (int i = 0; i < rCount; ++i)
            {
                for (int j = 0; j < cCount; ++j)
                {
                    cells[i, j] = startValues[i, j];
                    if (cells[i, j] == CellType.Active) ++CellsActive;
                    else if (cells[i, j] == CellType.Disabled) ++CellsDisabled;
                }
            }

            DiagonalNeighbourMode = diagonalNeighbourMode;
        }

        public void FlipCell(int row, int column)
        {
            if (cells[row, column] != CellType.Disabled)
            {
                if (DiagonalNeighbourMode) FlipCellDiagonalMode(row, column);
                else FlipCellNormalMode(row, column);
            }
        }

        private void FlipCellDiagonalMode(int r, int c)
        {
            SwapCell(r, c);

            if (--c >= 0) SwapCell(r, c);
            if (--r >= 0 && c >= 0) SwapCell(r, c);

            ++c;
            if (r >= 0) SwapCell(r, c);
            if (++c < ColumnCount && r >= 0) SwapCell(r, c);

            ++r;
            if (c < ColumnCount) SwapCell(r, c);
            if (++r < RowCount && c < ColumnCount) SwapCell(r, c);

            --c;
            if (r < RowCount) SwapCell(r, c);
            if (--c >= 0 && r < RowCount) SwapCell(r, c);
        }

        private void FlipCellNormalMode(int r, int c)
        {
            SwapCell(r, c);

            if (--c >= 0) SwapCell(r, c);

            ++c;
            if (--r >= 0) SwapCell(r, c);

            ++r;
            if (++c < ColumnCount) SwapCell(r, c);

            --c;
            if (++r < RowCount) SwapCell(r, c);
        }

        private void SwapCell(int r, int c)
        {
            if (cells[r, c] != CellType.Disabled)
            {
                if (cells[r, c] == CellType.Active)
                {
                    cells[r, c] = CellType.Inactive;
                    --CellsActive;
                }
                else
                {
                    cells[r, c] = CellType.Active;
                    ++CellsActive;
                }
            }
        }
    }
}
