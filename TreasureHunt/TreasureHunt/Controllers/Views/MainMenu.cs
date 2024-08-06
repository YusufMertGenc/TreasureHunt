using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreasureHuntGUI;

namespace TreasureHuntGUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameName_Click(object sender, EventArgs e)
        {

        }

        private void howtoPlay_Click(Object sender, EventArgs e)
        {
            string howToPlayText = "## How to Play: Treasure Hunt GUI\n\n" +
        "Welcome to Treasure Hunt GUI! This guide will help you understand how to play and enjoy the game.\n\n" +
        "### Objective\n" +
        "The goal of the game is to explore the grid, find treasures, and accumulate the highest score while maintaining your health. The game consists of 15 rounds, and the player with the highest score at the end wins.\n\n" +

        "### Game Elements\n" +
        "The grid contains various elements hidden in the cells:\n" +
        "- 🍖 Food: Increases health.\n" +
        "- 🌳 Wood: Increases health.\n" +
        "- 💊 Medical Supplies: Significantly increases health.\n" +
        "- 🐺 Wolf: Decreases health.\n" +
        "- 🐻 Bear: Significantly decreases health.\n" +
        "- 💰 Treasure: Increases score.\n" +
        "- 👹 Goblin: Prompts the player to make a choice that affects health or score.\n" +
        "- Empty: No effect.\n\n" +
        "### Gameplay\n" +
        "1. **Starting the Game**: Click the 'Play' button to start the game.\n" +
        "2. **Player Turns**:\n" +
        "   - Players take turns to select a cell on the grid by double-clicking on it.\n" +
        "   - Player 1 selects first, followed by Player 2.\n" +
        "   - Selected cells are marked with different colors for each player (Player 1: YellowGreen, Player 2: DarkCyan).\n" +
        "3. **Processing Choices**:\n" +
        "   - The selected cell reveals an element, and its effect is applied to the player who selected it.\n" +
        "   - Effects include health adjustments and score changes based on the revealed element.\n" +
        "4. **Health and Score**:\n" +
        "   - Each player starts with 20 health points.\n" +
        "   - Players gain or lose health and score points based on the elements they uncover.\n" +
        "   - If a player's health drops to 0, they are out of the game.\n" +
        "5. **Rounds and Endgame**:\n" +
        "   - The game progresses through 15 rounds.\n" +
        "   - The game ends if either player's health drops to 0 or after 15 rounds.\n" +
        "   - The player with the highest score at the end of the game wins.\n" +
        "   - In case of a tie, the game is declared a draw.\n\n" +

        "### Display and Stats\n" +
        "- The game board updates after each selection, showing the current state of the grid.\n" +
        "- Player stats (health and score) are displayed and updated in real-time.\n" +
        "- If a player's health is critically low (5 or less), their health stat turns red.\n\n" +
        "### Ending the Game\n" +
        "- A message will display the outcome of the game, announcing the winner or a draw.\n" +
        "- The game will then close.\n\n" +
        "Enjoy your adventure and may the best player win!";

            MessageBox.Show(howToPlayText, "How to Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
