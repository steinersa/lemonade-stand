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
        public Inventory inventory;

        public double moneyInPocket;

        //constructor
        public Player()
        {

        }

        //member methods

        public void GetName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }

        public void ChooseWhatToDoAtStartOfDay()
        {
            Console.WriteLine("Before you begin selling for the day, would you like to 'check inventory', 'go to the store', 'change recipe', or 'change price'? If you're all set to go, please type 'open for business'!");
            beginDayChoice = Console.ReadLine();

            switch (beginDayChoice)
            {
                case "check inventory":
                    inventory.DisplayInventory();
                    break;
                case "go to the store":
                    //go to store
                    break;
                case "change recipe":
                    //go to change recipe
                    break;
                case "change price":
                    //go to change price
                    break;
                case "open for business":
                    //go to start day?
                    break;
                default:
                    Console.Write("Oops, not a choice. Please enter a valid option from above!");
                    ChooseWhatToDoAtStartOfDay();
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