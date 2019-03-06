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
            RunGame();
        }

        public void RunGame() //some sort of loop. careful because will clear out inventory and store... need to move them out
        {
            inventory = new Inventory();
            store = new Store();
            recipe = new Recipe();
            actualTemp = new ActualWeather();
            actualTemp.GenerateWeather();
            player.ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
        }

    }
}