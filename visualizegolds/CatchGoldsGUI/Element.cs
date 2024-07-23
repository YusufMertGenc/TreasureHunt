using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchGoldsGUI
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
            int effect = player.GetBoardSize() / 6;
            player.AdjustHealth(effect);
        }
    }

    public class Wood : Element
    {
        public Wood(int size) : base(size) { }
        public override void Effect(Player player)
        {
            int effect = player.GetBoardSize() / 8;
            player.AdjustHealth(effect);
        }
    }

    public class MedicalSupplies : Element
    {
        public MedicalSupplies(int size) : base(size) { }
        public override void Effect(Player player)
        {
            int effect = player.GetBoardSize() / 4;
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
            int effect = -player.GetBoardSize() / 4;
            player.AdjustHealth(effect);
        }
    }

    public class Bear : WildAnimals
    {
        public Bear(int size) : base(size, 'B', 'D') { }
        public override void Effect(Player player)
        {
            int effect = -player.GetBoardSize() / 2;
            player.AdjustHealth(effect);
        }
    }

    public class Gold : Element
    {
        public Gold() : base() { }
        public override void Effect(Player player)
        {
            player.GoldCounter();
        }
    }

}
