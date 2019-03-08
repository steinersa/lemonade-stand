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
        public double totalProfit;
        int dayOfWeek;
        public string endOfGameChoice;
        public UserInterface userInterface;

        //constructor
        public Game()
        {

        }

        //member methods (Can Do)
        public void GameSetup()
        {
            userInterface = new UserInterface();
            userInterface.Welcome();
            player = new Player(20);
            player.GetName();
            userInterface.Directions(player);
            userInterface.Pause();
            weeklyForcast = new PredictedWeather();
            userInterface.Forecast();
            weeklyForcast.GenerateWeather();
            inventory = new Inventory();
            store = new Store();
            recipe = new Recipe();
            lemonade = new Lemonade();
            userInterface.Pause();
            RunGame();
        }

        public void RunGame()
        {
            if (dayOfWeek < 7)
            {
                day = new Day();
                actualTemp = new ActualWeather();
                Console.WriteLine($"Day {dayOfWeek + 1}!");
                actualTemp.GenerateWeather();
                player.ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
                player.MakeLemonade(inventory, recipe);
                userInterface.Pause();
                player.SellLemonade(player, lemonade, day, actualTemp);
                totalProfit += day.CalculateDailyProfit();
                userInterface.Pause();
                Console.WriteLine($"With today complete and added to the books, you've made {totalProfit} dollars at your lemonade stand so far!");
                dayOfWeek += day.NextDay();
                userInterface.Pause();
                RunGame();
            }
            else
            {
                Console.WriteLine($"Time flies when you're having fun! A week is already over. You made a total profit of {totalProfit} dollars at your lemonade stand. Would you like to 'play again' and see if you can earn more, or would you like to 'quit' the game?");
                endOfGameChoice = Console.ReadLine();
                switch (endOfGameChoice)
                {
                    case "play again":
                        dayOfWeek = 0;
                        GameSetup();
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Oops, not an option. Try again!");
                        RunGame();
                        break;
                }


            }
        }
    }
}