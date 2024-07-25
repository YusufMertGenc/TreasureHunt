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
            int sizeOfTheBoard = 5;
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
            if (comboBox1X.SelectedIndex != -1 && comboBox1Y.SelectedIndex != -1 &&
                comboBox2X.SelectedIndex != -1 && comboBox2Y.SelectedIndex != -1)
            {
                int x1 = int.Parse(comboBox1X.SelectedItem.ToString());
                int y1 = int.Parse(comboBox1Y.SelectedItem.ToString());
                int x2 = int.Parse(comboBox2X.SelectedItem.ToString());
                int y2 = int.Parse(comboBox2Y.SelectedItem.ToString());
                // Process player1's choice
                ProcessChoice(player1, x1, y1);
                // Process player2's choice
                ProcessChoice(player2, x2, y2);

                UpdateGridDisplay();
                UpdatePlayerStats();
                round++;

                if (player1.GetHealth() <= 0 || player2.GetHealth() <= 0 || round >= 12)
                {
                    EndGame();
                }
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
                        grid.HidedGrid(x, y, 'E');
                        MessageBox.Show("You found Nothing! Unlucky :(");
                        break;
                    }
            }
        }

        private void UpdatePlayerStats()
        {
            RoundNumber.Text = $"Round {round+1}/12";
            lblPlayer1Health.Text = $"Player 1 Health: {player1.GetHealth()}";
            lblPlayer1Score.Text = $"Player 1 Score: {player1.GetScore()}";
            lblPlayer2Health.Text = $"Player 2 Health: {player2.GetHealth()}";
            lblPlayer2Score.Text = $"Player 2 Score: {player2.GetScore()}";
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

       

        
    }
}
