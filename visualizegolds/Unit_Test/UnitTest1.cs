using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreasureHuntGUI;

namespace TreasureHuntTests
{
    [TestClass]
    public class ElementTests
    {
        [TestMethod]
        public void FoodEffectIncreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            Food food = new Food(1);
            food.Effect(player);
            Assert.AreEqual(initialHealth + 5, player.GetHealth());
        }

        [TestMethod]
        public void WoodEffectIncreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            Wood wood = new Wood(1);
            wood.Effect(player);
            Assert.AreEqual(initialHealth + 2, player.GetHealth());
        }

        [TestMethod]
        public void MedicalSuppliesEffectIncreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            MedicalSupplies medic = new MedicalSupplies(1);
            medic.Effect(player);
            Assert.AreEqual(initialHealth + 10, player.GetHealth()); // Assuming the board size is 5
        }

        [TestMethod]
        public void WolfEffectDecreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            Wolf wolf = new Wolf(1);
            wolf.Effect(player);
            Assert.AreEqual(initialHealth - 5, player.GetHealth());
        }

        [TestMethod]
        public void BearEffectDecreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            Bear bear = new Bear(1);
            bear.Effect(player);
            Assert.AreEqual(initialHealth - 8, player.GetHealth());
        }

        [TestMethod]
        public void TreasureEffectIncreasesScore()
        {
            Player player = new Player(5);
            int initialScore = player.GetScore();
            Treasure treasure = new Treasure();
            treasure.Effect(player);
            Assert.AreEqual(initialScore + 50, player.GetScore());
        }
    }

    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void AdjustHealthIncreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            player.AdjustHealth(10);
            Assert.AreEqual(initialHealth + 10, player.GetHealth());
        }

        [TestMethod]
        public void AdjustHealthDecreasesHealth()
        {
            Player player = new Player(5);
            int initialHealth = player.GetHealth();
            player.AdjustHealth(-5);
            Assert.AreEqual(initialHealth - 5, player.GetHealth());
        }

        [TestMethod]
        public void GoldCounterIncreasesScore()
        {
            Player player = new Player(5);
            int initialScore = player.GetScore();
            player.TreasureCounter();
            Assert.AreEqual(initialScore + 50, player.GetScore());
        }
    }

    [TestClass]
    public class GridTests
    {
        private Grid grid;

        [TestMethod]
        public void GridInitializationTest()
        {
            Grid grid = new Grid(5,6);
            Assert.AreEqual(5, grid.GetRows());
            Assert.AreEqual(6, grid.GetCols());
        }



    }
}