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
        public Customer sally;
        public Customer ted;
        public Customer jeff;
        public Customer anna;
        public Customer jack;
        public Customer jeanne;
        public Customer haley;
        public Customer carly;
        public Customer henry;
        public Customer lenny;
        public Customer marco;

        //constructor
        public Player(double cash)
        {
            this.cash = cash;
        }

        //member methods

        public void GetName()
        {
            name = Console.ReadLine();
        }

        public void ChooseWhatToDoAtStartOfDay(Inventory inventory, Store store, Player player, Recipe recipe, Lemonade lemonade, Day day)
        {
            Console.WriteLine("Before you begin selling for the day, would you like to 'check inventory', 'go to store', 'change recipe', or 'change price'? If you're all set to go, please type 'open for business'!");
            beginDayChoice = Console.ReadLine();


            switch (beginDayChoice)
            {
                case "check inventory":
                    inventory.DisplayInventory(store);
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
                    break;
                case "go to store":
                    store.SellToPlayer(player, inventory, store, recipe, day);
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
                    break;
                case "change recipe":
                    recipe.ChangeRecipe();
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
                    break;
                case "change price":
                    lemonade.ChangePrice();
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
                    break;
                case "open for business":
                    break;
                default:
                    Console.Write("Oops, not a choice. Please enter a valid option from above!");
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe, lemonade, day);
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
            inventory.lemonInventory -= (recipe.lemonsAdded * cupsAvailableToSell);
            inventory.sugarInventory -= (recipe.sugarAdded * cupsAvailableToSell);
            inventory.iceInventory -= (recipe.iceAdded * cupsAvailableToSell);
            Console.WriteLine("You made {0} cups of lemonade to sell today based on your available supplies and recipe.", cupsAvailableToSell);
        }

        public void SellLemonade(Player player, Lemonade lemonade, Day day, Weather actualTemp)
        {
            lenny = new Customer("Lenny", 60, 7.00);
            lenny.BuyLemonade(player, lemonade, day, actualTemp);
            marco = new Customer("Marco", 65, 6.00);
            marco.BuyLemonade(player, lemonade, day, actualTemp);
            sally = new Customer("Sally", 65, 1.00);
            sally.BuyLemonade(player, lemonade, day, actualTemp);
            ted = new Customer("Ted", 80, 7.00);
            ted.BuyLemonade(player, lemonade, day, actualTemp);
            jeff = new Customer("Jeff", 90, 5.00);
            jeff.BuyLemonade(player, lemonade, day, actualTemp);
            anna = new Customer("Anna", 80, 5.00);
            anna.BuyLemonade(player, lemonade, day, actualTemp);
            jack = new Customer("Jack", 70, 4.00);
            jack.BuyLemonade(player, lemonade, day, actualTemp);
            jeanne = new Customer("Jeanne", 60, 2.00);
            jeanne.BuyLemonade(player, lemonade, day, actualTemp);
            haley = new Customer("Haley", 65, 1.00);
            haley.BuyLemonade(player, lemonade, day, actualTemp);
            carly = new Customer("Carly", 90, 5.00);
            carly.BuyLemonade(player, lemonade, day, actualTemp);
            henry = new Customer("Henry", 80, 3.00);
            henry.BuyLemonade(player, lemonade, day, actualTemp);
        }
    }
}