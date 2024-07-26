namespace CatchGoldsGUI
{
    public class Player
    {
        private int score;
        private int goldCount;
        private int health;
        private readonly int boardSize;

        public Player(int boardSize)
        {
            this.boardSize = boardSize;
            this.health = 2 * boardSize;
            score = 0;
            this.goldCount = 0;
        }

        public void GoldCounter()
        {
            goldCount++;
            score += 100;
            if (goldCount % 3 == 0 && goldCount != 0)
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
        public int GetGoldCount()
        {
            return goldCount;
        }
        public void SetGoldCount(int goldCount)
        {
            this.goldCount = goldCount;
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
    }
}
