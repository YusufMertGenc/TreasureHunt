using System;

namespace CatchGoldsGUI
{
    public class Grid
    {
        private readonly int size;
        private readonly string[,] grid;
        private readonly string[,] hidedGrid;

        public Grid(int size)
        {
            this.size = size;
            grid = new string[size, size];
            hidedGrid = new string[size, size];
            InitializeGrid();
        }

        private void InitializeGrid()
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
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
                grid[rand.Next(size), rand.Next(size)] = "🍖";

                
                grid[rand.Next(size), rand.Next(size)] = "🌳";

                grid[rand.Next(size), rand.Next(size)] = "🐻";

                grid[rand.Next(size), rand.Next(size)] = "💊";

               

                grid[rand.Next(size), rand.Next(size)] = "🐺";
                
            }

            for (int i = 0; i < 6; i++)
                grid[rand.Next(size), rand.Next(size)] = "🥇";


        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
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
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(hidedGrid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public int GetSize() => size;
        public string GetGridValue(int x, int y) => hidedGrid[x, y];
    }




}
