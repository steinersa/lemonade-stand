using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (Has A)
        public Player player;
        public Weather weeklyForcast;
        public Inventory inventory;
        public Store store;
        public Recipe recipe;
        public Weather actualTemp;
        public Lemonade lemonade;

        //constructor
        public Game()
        {

        }

        //member methods (Can Do)
        public void GameSetup()
        {
            Console.WriteLine("Welcome to your new lemonade stand! Please enter your name before we go any further...");
            player = new Player(50);
            player.GetName();
            Console.WriteLine("Nice to meet you, {0}! Directions are as follows...", player.name);
            weeklyForcast = new PredictedWeather();
            weeklyForcast.GenerateWeather();
            inventory = new Inventory();
            store = new Store();
            recipe = new Recipe();
            lemonade = new Lemonade();
            RunGame();
        }

        public void RunGame()
        {
            actualTemp = new ActualWeather();
            actualTemp.GenerateWeather();
            player.ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade);
        }

    }
}