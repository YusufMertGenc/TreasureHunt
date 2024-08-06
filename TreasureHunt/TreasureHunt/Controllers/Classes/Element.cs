using System.Windows.Forms;

namespace TreasureHuntGUI
{
    public abstract class Element
    {
        protected int size;
        protected char representBoard;
        protected char effect;

        public Element()
        {
            size = 0;
            representBoard = 'N';
            effect = 'N';
        }

        public Element(int size)
        {
            this.size = size;
        }

        public abstract void Effect(Player player);
    }

    public class Food : Element
    {
        public Food(int size) : base(size) { }
        public override void Effect(Player player)
        {
            int effect = 5;
            player.AdjustHealth(effect);
        }
    }

    public class Wood : Element
    {
        public Wood(int size) : base(size) { }
        public override void Effect(Player player)
        {
            int effect = 2;
            player.AdjustHealth(effect);
        }
    }

    public class MedicalSupplies : Element
    {
        public MedicalSupplies(int size) : base(size) { }
        public override void Effect(Player player)
        {
            int effect = 10;
            player.AdjustHealth(effect);
        }
    }

    public abstract class WildAnimals : Element
    {
        public WildAnimals(int size, char represent, char effect) : base(size)
        {
            this.representBoard = represent;
            this.effect = effect;
        }
    }

    public class Wolf : WildAnimals
    {
        public Wolf(int size) : base(size, 'W', 'D') { }
        public override void Effect(Player player)
        {
            int effect = -5;
            player.AdjustHealth(effect);
        }
    }

    public class Bear : WildAnimals
    {
        public Bear(int size) : base(size, 'B', 'D') { }
        public override void Effect(Player player)
        {
            int effect = -10;
            player.AdjustHealth(effect);
        }
    }

    public class Goblin : WildAnimals
    {
        public Goblin(int size) : base(size, 'G' , 'D') { }

        public override void Effect(Player player)
        {
            DialogResult result = MessageBox.Show("A goblin has appeared! Choose:\nYes: Lose 5 health\nNo: Lose 50 score", "Goblin Attack", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                player.AdjustHealth(-7);
            }
            else if (result == DialogResult.No)
            {
                player.SetScore(player.GetScore() - 50);
            }
        }
    }

    public class Treasure : Element
    {
        public Treasure() : base() { }
        public override void Effect(Player player)
        {
            player.TreasureCounter();
        }
    }
}
