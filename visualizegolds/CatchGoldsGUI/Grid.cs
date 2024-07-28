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

                int tempPlaceX = rand.Next(size);
                int tempPlaceY = rand.Next(size);
                grid[tempPlaceX, tempPlaceY] = "🌳";

                int randomPlacement = rand.Next(2);

                if (randomPlacement == 0)
                {
                    if (tempPlaceX == size - 1)
                    {
                        grid[tempPlaceX - 1, tempPlaceY] = "🌳";
                    }
                    else
                    {
                        grid[tempPlaceX + 1, tempPlaceY] = "🌳";
                    }
                }
                else if (randomPlacement == 1)
                {
                    if (tempPlaceY == size - 1)
                    {
                        grid[tempPlaceX, tempPlaceY - 1] = "🌳";
                    }
                    else
                    {
                        grid[tempPlaceX, tempPlaceY + 1] = "🌳";
                    }
                }
                else
                {
                    if (tempPlaceX == 0 && tempPlaceY == 0)
                    {
                        grid[tempPlaceX + 1, tempPlaceY + 1] = "🌳";
                    }
                    else if (tempPlaceX == size && tempPlaceY == 0)
                    {
                        grid[tempPlaceX - 1, tempPlaceY + 1] = "🌳";
                    }
                    else if (tempPlaceX == 0 && tempPlaceY == size)
                    {
                        grid[tempPlaceX + 1, tempPlaceY - 1] = "🌳";
                    }
                    else if (tempPlaceX == size && tempPlaceY == size)
                    {
                        grid[tempPlaceX - 1, tempPlaceY - 1] = "🌳";
                    }
                }

                grid[rand.Next(size), rand.Next(size)] = "💊";

                if (i % 2 == 0)
                {
                    int randomPlacement1 = rand.Next(2);

                    int coordinateX = rand.Next(size);
                    int coordinateY = rand.Next(size);

                    grid[coordinateX, coordinateY] = "🐻";

                    if (randomPlacement1 == 1)
                    {
                        if (coordinateX == 0)
                        {
                            grid[coordinateX + 1, coordinateY] = "🐻";
                            grid[coordinateX + 2, coordinateY] = "🐻";
                        }
                        else if (coordinateX == size - 1)
                        {
                            grid[coordinateX - 1, coordinateY] = "🐻";
                            grid[coordinateX - 2, coordinateY] = "🐻";
                        }
                        else
                        {
                            grid[coordinateX - 1, coordinateY] = "🐻";
                            grid[coordinateX + 1, coordinateY] = "🐻";
                        }
                    }
                    else if (randomPlacement1 == 0)
                    {
                        if (coordinateY == 0)
                        {
                            grid[coordinateX, coordinateY + 1] = "🐻";
                            grid[coordinateX, coordinateY + 2] = "🐻";
                        }
                        else if (coordinateY == size - 1)
                        {
                            grid[coordinateX, coordinateY - 1] = "🐻";
                            grid[coordinateX, coordinateY - 2] = "🐻";
                        }
                        else
                        {
                            grid[coordinateX, coordinateY - 1] = "🐻";
                            grid[coordinateX, coordinateY + 1] = "🐻";
                        }
                    }
                }

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
