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
        public static string GameExtension { get; private set; }
        public static string EditorExtension { get; private set; }

        private static byte[] gameSignature;
        public static string GameSignature
        {
            get
            {
                string sig = new String((char)gameSignature[0], 1);
                sig += (char)gameSignature[1];
                sig += (char)gameSignature[2];
                sig += (char)gameSignature[3];
                return sig;
            }
        }

        private static byte[] levelSignature;
        public static string LevelSignature
        {
            get
            {
                string sig = new String((char)levelSignature[0], 1);
                sig += (char)levelSignature[1];
                sig += (char)levelSignature[2];
                sig += (char)levelSignature[3];
                sig += (char)levelSignature[4];
                sig += (char)levelSignature[5];
                sig += (char)levelSignature[6];
                return sig;
            }
        }

        static CellsIO()
        {
            GameExtension = ".cvlo";
            gameSignature = new byte[] { 67, 86, 76, 79 };

            EditorExtension = ".cvlolvl";
            levelSignature = new byte[] { 67, 86, 76, 79, 76, 86, 76 };
        }

        public static bool SaveGameToFile(Cells cells, long elapsedMs, int movesPerformed, string path)
        {
            FileData data = FileData.CreateGameSave(cells, movesPerformed, elapsedMs);
            return SaveDataToFile(data, path, "The game has been saved successfully!", "Save Game");
        }

        public static bool SaveLevelToFile(Cells cells, bool diagonalNeighbourMode, string path)
        {
            FileData data = FileData.CreateLevelSave(cells, diagonalNeighbourMode);
            return SaveDataToFile(data, path, "The level has been saved successfully!", "Save Level");
        }

        private static bool SaveDataToFile(FileData data, string path, string msg, string msgCaption)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        data.WriteToFile(bw);
                    }
                }

                MessageBox.Show(msg, msgCaption);
                return true;
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "IO Error"); }

            return false;
        }

        public static bool LoadGameFromFile(ref Cells cells, ref long elapsedMs, ref int movesPerformed, string path)
        {
            FileData data = null;
            if(LoadDataFromFile(ref data, path, true))
            {
                cells = data.Cells;
                elapsedMs = data.ElapsedMs.Value;
                movesPerformed = data.MovesPerformed.Value;
                return true;
            }
            return false;
        }

        public static bool LoadLevelFromFile(ref Cells cells, string path)
        {
            FileData data = null;
            if (LoadDataFromFile(ref data, path, false))
            {
                cells = data.Cells;
                return true;
            }
            return false;
        }

        private static bool LoadDataFromFile(ref FileData data, string path, bool gameData)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        data = (gameData) ? FileData.CreateGameLoad(br) : FileData.CreateLevelLoad(br);
                        if(data != null) return true;

                        MessageBox.Show("The file is incompatible.", "IO Error");
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "IO Error"); }

            return false;
        }
    }
}
