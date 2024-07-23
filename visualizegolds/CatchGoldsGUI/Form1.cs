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

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            int sizeOfTheBoard = 5; // Example size, you can make this dynamic
            grid = new Grid(sizeOfTheBoard);
            player1 = new Player(sizeOfTheBoard);
            player2 = new Player(sizeOfTheBoard);
            round = 0;

            grid.ElementDeploy(2 * sizeOfTheBoard * sizeOfTheBoard / 25);
            UpdateGridDisplay();
        }

        private void UpdateGridDisplay()
        {
            dataGridView1.RowCount = grid.GetSize();
            dataGridView1.ColumnCount = grid.GetSize();
            for (int i = 0; i < grid.GetSize(); i++)
            {
                for (int j = 0; j < grid.GetSize(); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = grid.GetGridValue(i, j);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtXPlayer1.Text, out int x1) && int.TryParse(txtYPlayer1.Text, out int y1) &&
                int.TryParse(txtXPlayer2.Text, out int x2) && int.TryParse(txtYPlayer2.Text, out int y2))
            {
                // Process player1's choice
                ProcessChoice(player1, x1, y1);
                // Process player2's choice
                ProcessChoice(player2, x2, y2);

                UpdateGridDisplay();
                UpdatePlayerStats();
                round++;
            }
            else
            {
                MessageBox.Show("Invalid coordinates entered. Please enter valid numbers.");
            }
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
                        MessageBox.Show("You found Nothing! Unlucky :(");
                        break;
                    }
            }
        }

        private void UpdatePlayerStats()
        {
            lblPlayer1Health.Text = $"Player 1 Health: {player1.GetHealth()}";
            lblPlayer1Score.Text = $"Player 1 Score: {player1.GetScore()}";
            lblPlayer2Health.Text = $"Player 2 Health: {player2.GetHealth()}";
            lblPlayer2Score.Text = $"Player 2 Score: {player2.GetScore()}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed
        }
    }
}
