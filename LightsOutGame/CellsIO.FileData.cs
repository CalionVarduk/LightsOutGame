using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LightsOutGame
{
    public static partial class CellsIO
    {
        private class FileData
        {
            public static int GameHeaderLength { get { return gameSignature.Length + 37; } }
            public static int LevelHeaderLength { get { return levelSignature.Length + 25; } }

            public int HeaderLength { get { return Signature.Length + 25 + (IsGameData ? 12 : 0); } }
            public int FileLength { get { return HeaderLength + CellCount; } }

            public bool IsGameData { get { return MovesPerformed.HasValue; } }
            public bool IsLevelData { get { return !IsGameData; } }

            public byte[] Signature { get; private set; }
            public bool DiagonalNeighbourMode { get; private set; }
            public int RowCount { get; private set; }
            public int ColumnCount { get; private set; }
            public int CellCount { get; private set; }
            public int CellsActive { get; private set; }
            public int CellsInactive { get; private set; }
            public int CellsDisabled { get; private set; }
            public int? MovesPerformed { get; private set; }
            public long? ElapsedMs { get; private set; }
            public Cells Cells { get; private set; }

            public static FileData CreateGameSave(Cells cells, int movesPerformed, long elapsedMs)
            {
                FileData fd = new FileData(cells);
                
                fd.Signature = gameSignature;
                fd.DiagonalNeighbourMode = cells.DiagonalNeighbourMode;
                fd.MovesPerformed = movesPerformed;
                fd.ElapsedMs = elapsedMs;

                return fd;
            }

            public static FileData CreateLevelSave(Cells cells, bool diagonalNeighbourMode)
            {
                FileData fd = new FileData(cells);

                fd.Signature = levelSignature;
                fd.DiagonalNeighbourMode = diagonalNeighbourMode;

                return fd;
            }

            public static FileData CreateGameLoad(BinaryReader br)
            {
                FileData fd = new FileData();
                
                if (!fd.LoadHeaderCoreData(br, gameSignature, GameHeaderLength)) return null;
                if (!fd.LoadGameHeaderAdditionalData(br)) return null;
                if (!fd.LoadCellsData(br)) return null;

                return fd;
            }

            public static FileData CreateLevelLoad(BinaryReader br)
            {
                FileData fd = new FileData();

                if (!fd.LoadHeaderCoreData(br, levelSignature, LevelHeaderLength)) return null;
                if (!fd.LoadCellsData(br)) return null;

                return fd;
            }

            public void WriteToFile(BinaryWriter bw)
            {
                bw.Write(Signature);
                bw.Write(DiagonalNeighbourMode);
                bw.Write(RowCount);
                bw.Write(ColumnCount);
                bw.Write(CellCount);
                bw.Write(CellsActive);
                bw.Write(CellsInactive);
                bw.Write(CellsDisabled);

                if (IsGameData)
                {
                    bw.Write(MovesPerformed.Value);
                    bw.Write(ElapsedMs.Value);
                }

                for (int i = 0; i < RowCount; ++i)
                    for (int j = 0; j < ColumnCount; ++j)
                        bw.Write((byte)Cells[i, j]);
            }

            private bool LoadHeaderCoreData(BinaryReader br, byte[] signature, int headerLength)
            {
                if (br.BaseStream.Length < headerLength) return false;
                if (!SignatureCheck(br, signature)) return false;

                DiagonalNeighbourMode = br.ReadBoolean();
                RowCount = br.ReadInt32();
                ColumnCount = br.ReadInt32();
                CellCount = br.ReadInt32();
                if (RowCount * ColumnCount != CellCount) return false;
                if (br.BaseStream.Length != headerLength + CellCount) return false;

                CellsActive = br.ReadInt32();
                CellsInactive = br.ReadInt32();
                CellsDisabled = br.ReadInt32();
                if (CellsActive + CellsInactive + CellsDisabled != CellCount) return false;

                return true;
            }

            private bool LoadGameHeaderAdditionalData(BinaryReader br)
            {
                MovesPerformed = br.ReadInt32();
                ElapsedMs = br.ReadInt64();
                return (MovesPerformed >= 0 && ElapsedMs >= 0);
            }

            private bool SignatureCheck(BinaryReader br, byte[] signature)
            {
                for (int i = 0; i < signature.Length; ++i)
                    if (br.ReadByte() != signature[i]) return false;
                return true;
            }

            private bool LoadCellsData(BinaryReader br)
            {
                Cells = new Cells(RowCount, ColumnCount);

                int active = 0;
                int disabled = 0;
                CellType[,] values = new CellType[RowCount, ColumnCount];

                for (int i = 0; i < RowCount; ++i)
                {
                    for (int j = 0; j < ColumnCount; ++j)
                    {
                        values[i, j] = (CellType)br.ReadByte();
                        if (values[i, j] == CellType.Active) ++active;
                        else if (values[i, j] == CellType.Disabled) ++disabled;
                    }
                }

                if (active != CellsActive || disabled != CellsDisabled) return false;

                Cells.Initialize(values, DiagonalNeighbourMode);
                return true;
            }

            private FileData()
            {

            }

            private FileData(Cells cells)
            {
                RowCount = cells.RowCount;
                ColumnCount = cells.ColumnCount;
                CellCount = RowCount * ColumnCount;
                CellsActive = cells.CellsActive;
                CellsInactive = cells.CellsInactive;
                CellsDisabled = cells.CellsDisabled;
                Cells = cells;
            }
        }
    }
}