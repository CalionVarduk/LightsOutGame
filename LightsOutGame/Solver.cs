using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace LightsOutGame
{
    public class Solver
    {
        private Cells puzzle;
        public Cells Puzzle
        {
            get { return puzzle; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if(!IsWorking) 
                {
                    OnSolvingStarted(EventArgs.Empty);
                    if (puzzle != value || ArePuzzlesDifferent(value))
                    {
                        puzzle = value.Clone();
                        worker.RunWorkerAsync();
                    }
                    else OnSolvingEnded(EventArgs.Empty);
                }
            }
        }

        private bool prevDiagonalMode;
        public Cells Solution { get; private set; }
        public bool HasSolution { get; private set; }
        public bool DiagonalNeighbourMode { get; set; }
        public bool IsWorking { get { return worker.IsBusy; } }
        public long TimeTaken { get { return watch.ElapsedMilliseconds; } }

        private Stopwatch watch;
        private BackgroundWorker worker;
        private int rowCount;
        private int columnCount;
        private int matrixSize;
        private CellType[,] matrix;
        private CellType[] vector;

        public event EventHandler SolvingStarted;
        public event EventHandler SolvingEnded;

        public Solver()
        {
            watch = new Stopwatch();
            worker = new BackgroundWorker();
            worker.DoWork += Event_DoWork;
            worker.RunWorkerCompleted += Event_WorkCompleted;
        }

        protected virtual void OnSolvingStarted(EventArgs e)
        {
            if (SolvingStarted != null) SolvingStarted(this, e);
        }

        protected virtual void OnSolvingEnded(EventArgs e)
        {
            if (SolvingEnded != null) SolvingEnded(this, e);
        }

        private void Event_DoWork(object sender, DoWorkEventArgs e)
        {
            Solve();
        }

        private void Event_WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnSolvingEnded(EventArgs.Empty);
        }

        private void Solve()
        {
            PrepareBuffers();

            ObtainPuzzleVector();
            InsertVectorAt(matrixSize);

            for (int i = 0, k = 0; i < rowCount; ++i)
            {
                for (int j = 0; j < columnCount; ++j, ++k)
                {
                    ObtainCellVector(i, j);
                    InsertVectorAt(k);
                }
            }

            if (GaussianElimination())
            {
                HasSolution = true;
                CreateSolutionModel();
            }

            ClearBuffers();
        }

        private void PrepareBuffers()
        {
            watch.Restart();
            Solution = null;
            HasSolution = false;
            rowCount = puzzle.RowCount;
            columnCount = puzzle.ColumnCount;
            matrixSize = puzzle.CellCount;
            matrix = new CellType[matrixSize, matrixSize + 1];
            vector = new CellType[matrixSize];
        }

        private void ClearBuffers()
        {
            watch.Stop();
            prevDiagonalMode = DiagonalNeighbourMode;
            rowCount = columnCount = matrixSize = 0;
            matrix = null;
            vector = null;
        }

        private void ObtainPuzzleVector()
        {
            for (int i = 0, k = 0; i < rowCount; ++i)
                for (int j = 0; j < columnCount; ++j, ++k)
                    vector[k] = puzzle[i, j];
        }

        private void ObtainCellVector(int row, int column)
        {
            for (int i = 0; i < matrixSize; ++i)
                if(vector[i] != CellType.Disabled)
                    vector[i] = CellType.Inactive;

            if (puzzle[row, column] != CellType.Disabled)
            {
                int vIndex = columnCount * row + column;
                vector[vIndex] = CellType.Active;

                if (DiagonalNeighbourMode)
                {
                    --vIndex;
                    if (--column >= 0 && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    vIndex -= columnCount;
                    if (--row >= 0 && column >= 0 && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    ++column;
                    ++vIndex;
                    if (row >= 0 && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    ++vIndex;
                    if (++column < columnCount && row >= 0 && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    ++row;
                    vIndex += columnCount;
                    if (column < columnCount && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    vIndex += columnCount;
                    if (++row < rowCount && column < columnCount && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    --column;
                    --vIndex;
                    if (row < rowCount && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    --vIndex;
                    if (--column >= 0 && row < rowCount && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;
                }
                else
                {
                    --vIndex;
                    if (--column >= 0 && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    ++column;
                    vIndex -= (columnCount - 1);
                    if (--row >= 0 && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    ++row;
                    vIndex += (columnCount + 1);
                    if (++column < columnCount && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;

                    --column;
                    vIndex += (columnCount - 1);
                    if (++row < rowCount && puzzle[row, column] != CellType.Disabled)
                        vector[vIndex] = CellType.Active;
                }
            }
        }

        private void InsertVectorAt(int column)
        {
            for (int i = 0; i < matrixSize; ++i)
                matrix[i, column] = vector[i];
        }

        private bool GaussianElimination()
        {
            for(int i = 0; i < matrixSize; ++i)
            {
                if (SwapPivotRow(i))
                    for (int j = i + 1; j < matrixSize; ++j)
                        EliminateRowDown(i, j);
            }

            for (int i = matrixSize - 1; i >= 0; --i)
            {
                if (matrix[i, i] == CellType.Active)
                {
                    for (int j = i - 1; j >= 0; --j)
                        EliminateRowUp(i, j);
                }
                else if (matrix[i, matrixSize] == CellType.Active)
                    return false;
            }
            return true;
        }

        private bool SwapPivotRow(int row)
        {
            if (matrix[row, row] == CellType.Active) return true;
            if (matrix[row, row] == CellType.Disabled) return false;

            for (int i = row + 1; i < matrixSize; ++i)
            {
                if(matrix[i, row] == CellType.Active)
                {
                    for (int j = row; j <= matrixSize; ++j)
                    {
                        CellType t = matrix[i, j];
                        matrix[i, j] = matrix[row, j];
                        matrix[row, j] = t;
                    }
                    return true;
                }
            }
            return false;
        }

        private void EliminateRowDown(int pivot, int row)
        {
            if(matrix[row, pivot] == CellType.Active)
            {
                matrix[row, pivot] = CellType.Inactive;

                for(int i = pivot + 1; i <= matrixSize; ++i)
                    if(matrix[pivot, i] == CellType.Active)
                        matrix[row, i] = (matrix[row, i] == CellType.Active) ? CellType.Inactive : CellType.Active;
            }
        }

        private void EliminateRowUp(int pivot, int row)
        {
            if (matrix[row, pivot] == CellType.Active)
            {
                matrix[row, pivot] = CellType.Inactive;

                if(matrix[pivot, matrixSize] == CellType.Active)
                    matrix[row, matrixSize] = (matrix[row, matrixSize] == CellType.Active) ? CellType.Inactive : CellType.Active;
            }
        }

        private void CreateSolutionModel()
        {
            ExtractSolutionVector();
            Solution = new Cells(rowCount, columnCount);

            for (int i = 0, k = 0; i < rowCount; ++i)
                for (int j = 0; j < columnCount; ++j, ++k)
                    Solution[i, j] = vector[k];
        }

        private void ExtractSolutionVector()
        {
            for (int i = 0; i < matrixSize; ++i)
                vector[i] = matrix[i, matrixSize];
        }

        private bool ArePuzzlesDifferent(Cells newPuzzle)
        {
            int rows = puzzle.RowCount;
            int columns = puzzle.ColumnCount;
            if (rows != newPuzzle.RowCount || columns != newPuzzle.ColumnCount || prevDiagonalMode != DiagonalNeighbourMode)
                return true;

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns; ++j)
                    if (puzzle[i, j] != newPuzzle[i, j])
                        return true;

            return false;
        }
    }
}
