using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchGoldsGUI
{
    public partial class Form1 : Form
    {
        private Grid grid;
        private Player player1;
        private Player player2;
        private int round;

        private int player1X, player1Y, player2X, player2Y;
        private bool player1Turn = true;

        private List<(int, int)> player1Selections = new List<(int, int)>();
        private List<(int, int)> player2Selections = new List<(int, int)>();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            int sizeOfTheBoard = 5;
            grid = new Grid(sizeOfTheBoard);
            player1 = new Player(sizeOfTheBoard);
            player2 = new Player(sizeOfTheBoard);
            round = 0;
            
            grid.ElementDeploy(2*sizeOfTheBoard*sizeOfTheBoard/25);
            SetupDataGridView();
            UpdateGridDisplay();
        }

        private void SetupDataGridView()
        {
            
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.MultiSelect = false;
           dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

         
           
        }


        private void UpdateGridDisplay()
        {
            dataGridView1.RowCount = grid.GetSize();
            dataGridView1.ColumnCount = grid.GetSize();

            for (int i = 0; i < grid.GetSize(); i++)
            {
                for (int j = 0; j < grid.GetSize(); j++)
                {
                    UpdateCell(i, j);
                }
            }

            for (int j = 0; j < grid.GetSize(); j++)
            {
                dataGridView1.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[j].Width = dataGridView1.Width / grid.GetSize();
            }

            for (int i = 0; i < grid.GetSize(); i++)
            {
                dataGridView1.Rows[i].Height = dataGridView1.Height / grid.GetSize();
            }
        }

        private void UpdateCell(int i, int j)
        {
            dataGridView1.Rows[i].Cells[j].Value = grid.GetGridValue(i, j);

            if (player1Selections.Contains((i, j)))
            {
                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
            }
            else if (player2Selections.Contains((i, j)))
            {
                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.DarkCyan;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            // Process player1's choice
            ProcessChoice(player1, player1X, player1Y);
            // Process player2's choice
            ProcessChoice(player2, player2X, player2Y);

            UpdateCell(player1X, player1Y);
            UpdateCell(player2X, player2Y);
            UpdatePlayerStats();
            round++;

            if (player1.GetHealth() <= 0 || player2.GetHealth() <= 0 || round >= 12)
            {
                EndGame();
            }

            player1Turn = true; // Reset turn for next round



        }

 


        private void ProcessChoice(Player player, int x, int y)
        {
            char choice = grid.Choice(x, y);
            switch (choice)
            {
                case 'F':
                    {
                        Food food = new Food(player.GetBoardSize());
                        food.Effect(player);
                        grid.HidedGrid(x, y, 'F');
                        MessageBox.Show("You found Food! (this means your health will increase.)");
                        break;
                    }
                case 'I':
                    {
                        Wood wood = new Wood(player.GetBoardSize());
                        wood.Effect(player);
                        grid.HidedGrid(x, y, 'I');
                        MessageBox.Show("You found Wood! (this means your health will increase.)");
                        break;
                    }
                case 'S':
                    {
                        MedicalSupplies medic = new MedicalSupplies(player.GetBoardSize());
                        medic.Effect(player);
                        grid.HidedGrid(x, y, 'S');
                        MessageBox.Show("You found medical supplies! (this means your health will increase.)");
                        break;
                    }
                case 'W':
                    {
                        Wolf wolf = new Wolf(player.GetBoardSize());
                        wolf.Effect(player);
                        grid.HidedGrid(x, y, 'W');
                        MessageBox.Show("Ooops! You found a wolf!! (this means your health will decrease!)");
                        break;
                    }
                case 'B':
                    {
                        Bear bear = new Bear(player.GetBoardSize());
                        bear.Effect(player);
                        grid.HidedGrid(x, y, 'B');
                        MessageBox.Show("Ooops! You found a bear!! (this means your health will decrease!)");
                        break;
                    }
                case 'G':
                    {
                        Gold gold = new Gold();
                        gold.Effect(player);
                        grid.HidedGrid(x, y, 'G');
                        MessageBox.Show("You found GOLD!!! (this means your score will increase.)");
                        break;
                    }
                default:
                    {
                        grid.HidedGrid(x, y, 'E');
                        MessageBox.Show("You found Nothing! Unlucky :(");
                        break;
                    }
            }
        }

        private void UpdatePlayerStats()
        {
            RoundNumber.Text = $"Round {round+1}/12";
            Health1.Text = $"Player 1 Health: {player1.GetHealth()}";
            Score1.Text = $"Player 1 Score: {player1.GetScore()}";
            Health2.Text = $"Player 2 Health: {player2.GetHealth()}";
            Score2.Text = $"Player 2 Score: {player2.GetScore()}";
        }

        private void EndGame()
        {
            string message;
            if (player1.GetHealth() <= 0)
            {
                message = "Player 1 is dead. GAME OVER\n";
            }
            else if (player2.GetHealth() <= 0)
            {
                message = "Player 2 is dead. GAME OVER\n";
            }
            else
            {
                message = "Maximum rounds reached. GAME OVER\n";
            }

            if (player1.GetScore() > player2.GetScore())
            {
                message += "PLAYER 1 IS WON CONGRATS!!";
            }
            else if (player1.GetScore() < player2.GetScore())
            {
                message += "PLAYER 2 IS WON CONGRATS!!";
            }
            else
            {
                message += "DRAW ";
            }

            MessageBox.Show(message);

            
        }

        private void dataGridView1_CellClick(object senderi, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                

                if (player1Turn)
                {
                    player1X = e.RowIndex;
                    player1Y = e.ColumnIndex;
                    Xcoordinate1.Text = $"X: {player1X}";
                    YCoordinate1.Text = $"Y: {player1Y}";
                    player1Selections.Add((player1X, player1Y));
                    player1Turn = false; // Switch turn to player 2
                }
                else
                {
                    player2X = e.RowIndex;
                    player2Y = e.ColumnIndex;
                    XCoordinate2.Text = $"X: {player2X}";
                    YCoordinate2.Text = $"Y: {player2Y}";
                    player2Selections.Add((player2X, player2Y));
                    player1Turn = true; // Switch turn to player 1
                }
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Xcoordinate1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
