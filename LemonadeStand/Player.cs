using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        public string name;
        public string beginDayChoice;
        public double cash;
        public int lemonsToCups;
        public int sugarToCups;
        public int iceToCups;
        public int cupsAvailableToSell;

        //constructor
        public Player(double cash)
        {
            this.cash = cash;
        }

        //member methods

        public void GetName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }

        public void ChooseWhatToDoAtStartOfDay(Inventory inventory, Store store, Player player, Recipe recipe, Lemonade lemonade)
        {
            Console.WriteLine("Before you begin selling for the day, would you like to 'check inventory', 'go to store', 'change recipe', or 'change price'? If you're all set to go, please type 'open for business'!");
            beginDayChoice = Console.ReadLine();


            switch (beginDayChoice)
            {
                case "check inventory":
                    inventory.DisplayInventory(store);
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade);
                    break;
                case "go to store":
                    store.SellToPlayer(player, inventory, store, recipe);
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade);
                    break;
                case "change recipe":
                    recipe.ChangeRecipe();
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade);
                    break;
                case "change price":
                    lemonade.ChangePrice();
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade);
                    break;
                case "open for business":
                    break;
                default:
                    Console.Write("Oops, not a choice. Please enter a valid option from above!");
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade);
                    break;
            }
        }

        public void MakeLemonade(Inventory inventory, Recipe recipe)
        {
            lemonsToCups = inventory.lemonInventory / recipe.lemonsAdded;
            sugarToCups = inventory.sugarInventory/recipe.sugarAdded;
            iceToCups = inventory.iceInventory/recipe.iceAdded;
            int[] possibleNumberOfCups = { lemonsToCups, sugarToCups, iceToCups };
            cupsAvailableToSell = possibleNumberOfCups.Min();
            Console.WriteLine("You made {0} cups of lemonade to sell today! This number is based on your inventory and recipe.", cupsAvailableToSell);
        }

        public void SellLemonade()
        {

        }
    }
}