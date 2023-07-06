using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_live
{
    public class GameLogic
    {
        public bool[,] CurrentCells { get; set; } = new bool[GlobalConfig.XSize, GlobalConfig.YSize];
        public bool[,] StartingCells { get; set; } = new bool[GlobalConfig.XSize, GlobalConfig.YSize];
        public int Generation { get; set; } = 0;
        public bool IsPaused { get; set; }

        public GameLogic(string? filePath = null)
        {
            if (filePath != null)
            {
                LoadGame(filePath);
            }
            IsPaused = true;
        }

        public void LoadGame(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                JsonConvert.PopulateObject(jsonData, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the object: " + ex.Message);
            }
        }

        public void SaveGame(string filePath)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(this);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the object: " + ex.Message);
            }
        }

        public void ChangeCellValue(int x, int y)
        {
            if (x >= GlobalConfig.XSize || y >= GlobalConfig.YSize)
            {
                return;
            }

            CurrentCells[x, y] = !CurrentCells[x, y];
        }

        public void StartGame()
        {
            if(Generation == 0)
            {
                StartingCells = (bool[,])CurrentCells.Clone();
            }
            IsPaused = false;
        }

        public void PauseGame()
        {
            IsPaused = true;
        }

        public void RestartGame()
        {
            IsPaused = true;
            CurrentCells = (bool[,])StartingCells.Clone();
            Generation = 0;
        }

        public void OneStep()
        {
            bool[,] newCells = new bool[GlobalConfig.XSize, GlobalConfig.YSize];

            for (int i = 0; i < CurrentCells.GetLength(0); i++)
            {
                for (int j = 0; j < CurrentCells.GetLength(1); j++)
                {
                    int neighbors = GetNumberOfNeighbors(i, j);

                    if (!CurrentCells[i,j] && neighbors == 3)
                    {
                        newCells[i, j] = true;
                    }
                    else if (CurrentCells[i, j] && (neighbors == 2 || neighbors == 3))
                    {
                        newCells[i, j] = true;
                    }
                    else
                    {
                        newCells[i, j] = false;
                    }
                }
            }

            CurrentCells = newCells;
            Generation++;
        }

        private int GetNumberOfNeighbors(int x, int y)
        {
            return (from i in Enumerable.Range(x - 1, 3)
                   from j in Enumerable.Range(y - 1, 3)
                   where i >= 0 && j >= 0 && i < CurrentCells.GetLength(0) && j < CurrentCells.GetLength(1) && (i != x || j != y) && CurrentCells[i, j] == true
                   select i).Count();
        }
    }
}
