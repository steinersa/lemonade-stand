using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store //need to make sure player cash doesnt drop below zero
    {
        //member variables
        public string storeChoice;

        public string lemonsPurchased;
        public double priceOfFiveLemons;
        public double priceOfTenLemons;
        public double priceOfFifteenLemons;

        public string sugarPurchased;
        public double priceOfFiveSugar;
        public double priceOfTenSugar;
        public double priceOfFifteenSugar;

        public string icePurchased;
        public double priceOfFiveIce;
        public double priceOfTenIce;
        public double priceOfFifteenIce;

        //constructor
        public Store()
        {
            this.priceOfFiveLemons = 3.00;
            this.priceOfTenLemons = 5.00;
            this.priceOfFifteenLemons = 7.00;

            this.priceOfFiveSugar = 5.00;
            this.priceOfTenSugar = 9.00;
            this.priceOfFifteenSugar = 13.00;

            this.priceOfFiveIce = 2.00;
            this.priceOfTenIce = 4.00;
            this.priceOfFifteenIce = 6.00;
        }

        //member methods
        public void SellToPlayer(Player player, Inventory inventory, Store store, Recipe recipe)
        {
            Console.WriteLine("Would you like to buy 'lemons', 'sugar', or 'ice'? If you're all done shopping, please type 'leave store'.");
            storeChoice = Console.ReadLine();

            switch (storeChoice)
            {
                case "lemons":
                    SellLemons(player, inventory);
                    SellToPlayer(player, inventory, store, recipe);
                    break;
                case "sugar":
                    SellSugar(player, inventory);
                    SellToPlayer(player, inventory, store, recipe);
                    break;
                case "ice":
                    SellIce(player, inventory);
                    SellToPlayer(player, inventory, store, recipe);
                    break;
                case "leave store":
                    player.ChooseWhatToDoAtStartOfDay(inventory, store, player, recipe);
                    break;
                default:
                    Console.Write("Oops, not a choice. Please enter a valid option from above!");
                    SellToPlayer(player, inventory, store, recipe);
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

        public void SellSugar(Player player, Inventory inventory)
        {
            Console.WriteLine("Would you like to buy 'five' packs of sugar for $5.00, 'ten' for $9.00, or 'fifteen' for $13.00?");
            sugarPurchased = Console.ReadLine();
            if (sugarPurchased == "five")
            {
                player.cash -= priceOfFiveSugar;
                inventory.sugarInventory = +5;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (sugarPurchased == "ten")
            {
                player.cash -= priceOfTenSugar;
                inventory.sugarInventory = +10;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (sugarPurchased == "fifteen")
            {
                player.cash -= priceOfFifteenSugar;
                inventory.sugarInventory = +15;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else
            {
                Console.WriteLine("Not an option. Try again!");
                SellSugar(player, inventory);
            }
        }

        public void SellIce(Player player, Inventory inventory)
        {
            Console.WriteLine("Would you like to buy 'five' bundles of ice for $2.00, 'ten' for $4.00, or 'fifteen' for $6.00?");
            icePurchased = Console.ReadLine();
            if (icePurchased == "five")
            {
                player.cash -= priceOfFiveIce;
                inventory.iceInventory = +5;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (icePurchased == "ten")
            {
                player.cash -= priceOfTenIce;
                inventory.iceInventory = +10;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (icePurchased == "fifteen")
            {
                player.cash -= priceOfFifteenIce;
                inventory.iceInventory = +15;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else
            {
                Console.WriteLine("Not an option. Try again!");
                SellIce(player, inventory);
            }
        }

    }
}