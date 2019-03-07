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
        public Day day;
        double totalProfit;

        //constructor
        public Game()
        {

        }

        //member methods (Can Do)
        public void GameSetup()
        {
            Console.WriteLine("Welcome to your new lemonade stand! Please enter your name before we go any further...");
            player = new Player(20);
            player.GetName();
            Console.WriteLine($"Nice to meet you, {player.name}! Directions are as follows...");
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
            day = new Day();
            actualTemp = new ActualWeather();
            actualTemp.GenerateWeather();
            player.ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
            player.MakeLemonade(inventory, recipe);
            player.SellLemonade(player, lemonade, day, actualTemp);
            totalProfit += day.CalculateDailyProfit();
            Console.WriteLine($"With today complete and added to the books, so far you've made {totalProfit} dollars at your lemonade stand!");
            Console.ReadLine();
            //display running total make an array here that the daily profit is pushed to
            //start next day (if run game count less than or equal to 7)
        }
    }
}