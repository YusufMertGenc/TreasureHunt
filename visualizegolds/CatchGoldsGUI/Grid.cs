using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGoldsGUI
{
    public class Grid
    {
        private int size;
        private char[,] grid;
        private char[,] hidedGrid;

        public Grid(int size)
        { 
            this.size = size;
            grid = new char[size, size];
            hidedGrid = new char[size, size];
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = '★';
                    hidedGrid[i, j] = '★';
                }
            }
        }

        public void ElementDeploy(int numberOfElements)
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfElements; i++)
            {
                grid[rand.Next(size), rand.Next(size)] = 'F';

                int tempPlaceX = rand.Next(size);
                int tempPlaceY = rand.Next(size);
                grid[tempPlaceX, tempPlaceY] = 'I';

                int randomPlacement = rand.Next(2);

                if (randomPlacement == 0)
                {
                    if (tempPlaceX == size - 1)
                    {
                        grid[tempPlaceX - 1, tempPlaceY] = 'I';
                    }
                    else
                    {
                        grid[tempPlaceX + 1, tempPlaceY] = 'I';
                    }
                }
                else if (randomPlacement == 1)
                {
                    if (tempPlaceY == size - 1)
                    {
                        grid[tempPlaceX, tempPlaceY - 1] = 'I';
                    }
                    else
                    {
                        grid[tempPlaceX, tempPlaceY + 1] = 'I';
                    }
                }
                else
                {
                    if (tempPlaceX == 0 && tempPlaceY == 0)
                    {
                        grid[tempPlaceX + 1, tempPlaceY + 1] = 'I';
                    }
                    else if (tempPlaceX == size && tempPlaceY == 0)
                    {
                        grid[tempPlaceX - 1, tempPlaceY + 1] = 'I';
                    }
                    else if (tempPlaceX == 0 && tempPlaceY == size)
                    {
                        grid[tempPlaceX + 1, tempPlaceY - 1] = 'I';
                    }
                    else if (tempPlaceX == size && tempPlaceY == size)
                    {
                        grid[tempPlaceX - 1, tempPlaceY - 1] = 'I';
                    }
                }

                grid[rand.Next(size), rand.Next(size)] = 'S';

                if (i % 2 == 0)
                {
                    int randomPlacement1 = rand.Next(2);

                    int coordinateX = rand.Next(size);
                    int coordinateY = rand.Next(size);

                    grid[coordinateX, coordinateY] = 'B';

                    if (randomPlacement1 == 1)
                    {
                        if (coordinateX == 0)
                        {
                            grid[coordinateX + 1, coordinateY] = 'B';
                            grid[coordinateX + 2, coordinateY] = 'B';
                        }
                        else if (coordinateX == size - 1)
                        {
                            grid[coordinateX - 1, coordinateY] = 'B';
                            grid[coordinateX - 2, coordinateY] = 'B';
                        }
                        else
                        {
                            grid[coordinateX - 1, coordinateY] = 'B';
                            grid[coordinateX + 1, coordinateY] = 'B';
                        }
                    }
                    else if (randomPlacement1 == 0)
                    {
                        if (coordinateY == 0)
                        {
                            grid[coordinateX, coordinateY + 1] = 'B';
                            grid[coordinateX, coordinateY + 2] = 'B';
                        }
                        else if (coordinateY == size - 1)
                        {
                            grid[coordinateX, coordinateY - 1] = 'B';
                            grid[coordinateX, coordinateY - 2] = 'B';
                        }
                        else
                        {
                            grid[coordinateX, coordinateY - 1] = 'B';
                            grid[coordinateX, coordinateY + 1] = 'B';
                        }
                    }
                }

                grid[rand.Next(size), rand.Next(size)] = 'W';
                grid[rand.Next(size), rand.Next(size)] = 'G';
            }
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

        public char Choice(int x, int y) => grid[x, y];

        public void HidedGrid(int x, int y, char foundChar)
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
        public char GetGridValue(int x, int y) => hidedGrid[x, y];
    }
}
