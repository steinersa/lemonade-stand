using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variables
        public string storeChoice;
        public string lemonsPurchased;
        public double priceOfFiveLemons;
        public double priceOfTenLemons;
        public double priceOfFifteenLemons;



        //constructor
        public Store()
        {
            this.priceOfFiveLemons = 3.00;
            this.priceOfTenLemons = 5.00;
            this.priceOfFifteenLemons = 7.00;
        }

        //member methods
        public void SellToPlayer(Player player, Inventory inventory, Store store)
        {
            Console.WriteLine("Would you like to buy 'lemons', 'sugar', or 'ice'? If you're all done shopping, please enter 'leave store'.");
            storeChoice = Console.ReadLine();

            switch (storeChoice)
            {
                case "lemons":
                    SellLemons(player, inventory);
                    SellToPlayer(player, inventory, store);
                    break;
                case "sugar":
                    SellSugar();
                    break;
                case "ice":
                    SellIce();
                    break;
                case "leave store":
                    player.ChooseWhatToDoAtStartOfDay(inventory, store, player);
                    break;
                default:
                    Console.Write("Oops, not a choice. Please enter a valid option from above!");
                    SellToPlayer(player, inventory, store);
                    break;

            }
        }
        
        public void SellLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("Would you like to buy 'five' lemons for $3.00, 'ten' for $5.00, or 'fifteen' for $7.00?");
            lemonsPurchased = Console.ReadLine();
            if (lemonsPurchased == "five")
            {
                player.cash -= priceOfFiveLemons;
                inventory.lemonInventory =+ 5;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (lemonsPurchased == "ten")
            {
                player.cash -= priceOfTenLemons;
                inventory.lemonInventory = +10;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (lemonsPurchased == "fifteen")
            {
                player.cash -= priceOfFifteenLemons;
                inventory.lemonInventory = +15;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else
            {
                Console.WriteLine("Not an option. Try again!");
                SellLemons(player, inventory);
            }

        }

        public void SellSugar()
        {

        }

        public void SellIce()
        {

        }

    }
}