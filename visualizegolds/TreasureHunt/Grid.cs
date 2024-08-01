using System;

namespace TreasureHuntGUI
{
    public class Grid
    {
        private readonly int rows;
        private readonly int cols;
        private readonly int size;
        private readonly string[,] grid;
        private readonly string[,] hidedGrid;

        public Grid(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            grid = new string[rows, cols];
            hidedGrid = new string[rows, cols];
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = "★";
                    hidedGrid[i, j] = "★";
                }
            }
        }

        public void ElementDeploy(int numberOfElements)
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfElements; i++)
            {
                grid[rand.Next(rows), rand.Next(cols)] = "🍖";

                grid[rand.Next(rows), rand.Next(cols)] = "🌳";

                grid[rand.Next(rows), rand.Next(cols)] = "🐻";

                grid[rand.Next(rows), rand.Next(cols)] = "💊";

                grid[rand.Next(rows), rand.Next(cols)] = "🐺";

            }

            for (int i = 0; i < 6; i++)
                grid[rand.Next(rows), rand.Next(cols)] = "💰";
        }

        public void Display()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public string Choice(int x, int y) => grid[x, y];

        public void HidedGrid(int x, int y, string foundChar)
        {
            hidedGrid[x, y] = foundChar;
        }

        public void DisplayCurrentGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(hidedGrid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int GetRows() => rows;
        public int GetCols() => cols;
        public string GetGridValue(int x, int y) => hidedGrid[x, y];
    }
}
