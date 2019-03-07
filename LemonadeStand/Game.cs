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
        int dayOfWeek;
        public string endOfGameChoice;

        //constructor
        public Game()
        {

        }

        //member methods (Can Do)
        public void GameSetup()
        {
            Console.WriteLine("So I hear you want to open up a lemonade stand! Please enter your name before we go any further: ");
            player = new Player(20);
            player.GetName();
            Console.WriteLine($"Nice to meet you, {player.name}! Let me give you the rundown and $20 dollars to start. Your stand will be open seven days, make as much money as possible in that time! At the beginning of the week you’ll be presented with a weather forecast. However, each morning, you’ll see the actual temperature for the day. Keep the temperature in mind when setting up your stand! Navigate through your inventory, recipe book, price book, and even the corner store to get your stand ready daily. Once you indicate you’re equipped to open, you’ll make servings of lemonade based on your current ingredient inventory and recipe! A word of caution - any lemonade made on a given day that does not sell will go bad! This is a pretty tightknit community and you’ll get some regular customers, as long as conditions meet their demands! Good luck!");
            Pause();
            weeklyForcast = new PredictedWeather();
            Console.WriteLine("Weekly Weather Forecast:");
            weeklyForcast.GenerateWeather();
            inventory = new Inventory();
            store = new Store();
            recipe = new Recipe();
            lemonade = new Lemonade();
            Pause();
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
                player.SellLemonade(player, lemonade, day, actualTemp);
                totalProfit += day.CalculateDailyProfit();
                Console.WriteLine($"With today complete and added to the books, you've made {totalProfit} dollars at your lemonade stand so far!");
                dayOfWeek += day.NextDay();
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

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}