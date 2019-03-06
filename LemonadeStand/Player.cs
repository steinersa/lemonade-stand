using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        public string name;
        public string beginDayChoice;
        public double cash;

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

        public void ChooseWhatToDoAtStartOfDay(Inventory inventory, Store store, Player player, Recipe recipe)
        {
            Console.WriteLine("Before you begin selling for the day, would you like to 'check inventory', 'go to store', 'change recipe', or 'change price'? If you're all set to go, please type 'open for business'!");
            beginDayChoice = Console.ReadLine();


            switch (beginDayChoice)
            {
                case "check inventory":
                    inventory.DisplayInventory(store);
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
                    break;
                case "go to store":
                    store.SellToPlayer(player, inventory, store, recipe);
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
                    break;
                case "change recipe":
                    recipe.ChangeRecipe();
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
                    break;
                case "change price":
                    //go to change price
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
                    break;
                case "open for business":
                    //go to start day?
                    break;
                default:
                    Console.Write("Oops, not a choice. Please enter a valid option from above!");
                    ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
                    break;
            }
        }

        public void MakeLemonade()
        {
            
        }

        public void GoToStore()
        {
            
        }

        public void BuyInventory()
        {
            
        }

        public void CheckInventory()
        {
            
        }

        public void ChangeRecipe()
        {
            
        }

        public void SellLemonade()
        {

        }
    }
}