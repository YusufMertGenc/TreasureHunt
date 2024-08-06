namespace TreasureHuntGUI
{
    public class Player
    {
        private int score;
        private int treasureCount;
        private int health;
        private readonly int boardSize;

        public Player(int boardSize)
        {
            this.boardSize = boardSize;
            this.health = 20;
            score = 0;
            this.treasureCount = 0;
        }

        public void TreasureCounter()
        {
            treasureCount++;
            score += 50;
            if (treasureCount % 3 == 0 && treasureCount != 0)
            {
                AdjustHealth(boardSize / 4);
            }
        }

        public void AdjustHealth(int adjust)
        {
            health += adjust;
        }

        public int GetScore()
        {
            return score;
        }
        public void SetScore(int score)
        {
            this.score = score;
        }
        public int GetTreasureCount()
        {
            return treasureCount;
        }
        public void SetGoldCount(int treasureCount)
        {
            this.treasureCount = treasureCount;
        }
        public int GetHealth()
        {
            return health;
        }
        public void SetHealth(int health)
        {
            this.health = health;
        }
        public int GetBoardSize()
        {
            return boardSize;
        }

        public bool HasMadeChoice { get; set; }
    }
}
