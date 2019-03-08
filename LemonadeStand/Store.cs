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
        public double priceOfFifteenLemons;
        public double priceOfThirtyLemons;
        public double priceOfFortyfiveLemons;

        public string sugarPurchased;
        public double priceOfFifteenSugar;
        public double priceOfThirtySugar;
        public double priceOfFortyfiveSugar;

        public string icePurchased;
        public double priceOfFifteenIce;
        public double priceOfThirtyIce;
        public double priceOfFortyfiveIce;

        //constructor
        public Store()
        {
            this.priceOfFifteenLemons = 3.00;
            this.priceOfThirtyLemons = 5.00;
            this.priceOfFortyfiveLemons = 7.00;

            this.priceOfFifteenSugar = 1.50;
            this.priceOfThirtySugar = 3.00;
            this.priceOfFortyfiveSugar = 4.50;

            this.priceOfFifteenIce = 1.00;
            this.priceOfThirtyIce = 2.00;
            this.priceOfFortyfiveIce = 3.00;
        }

        //member methods
        public void SellToPlayer(Player player, Inventory inventory, Store store, Recipe recipe, Day day)
        {
            Console.WriteLine("Would you like to buy 'lemons', 'sugar', or 'ice'? If you're all done shopping, please type 'leave store'.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            storeChoice = Console.ReadLine();
            Console.ResetColor();

            switch (storeChoice)
            {
                case "lemons":
                    SellLemons(player, inventory, day);
                    SellToPlayer(player, inventory, store, recipe, day);
                    break;
                case "sugar":
                    SellSugar(player, inventory, day);
                    SellToPlayer(player, inventory, store, recipe, day);
                    break;
                case "ice":
                    SellIce(player, inventory, day);
                    SellToPlayer(player, inventory, store, recipe, day);
                    break;
                case "leave store":
                    break;
                default:
                    Console.WriteLine("Oops, not a choice. Please enter a valid option from above!");
                    SellToPlayer(player, inventory, store, recipe, day);
                    break;

            }
        }
        
        public void SellLemons(Player player, Inventory inventory, Day day)
        {
            Console.WriteLine($"Would you like to buy 'fifteen' lemons for ${priceOfFifteenLemons}, 'thirty' for ${priceOfThirtyLemons}, or 'fortyfive' for ${priceOfFortyfiveLemons}?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            lemonsPurchased = Console.ReadLine();
            Console.ResetColor();
            if (lemonsPurchased == "fifteen")
            {
                player.cash -= priceOfFifteenLemons;
                inventory.lemonInventory += 15;
                day.moneySpentToday += priceOfFifteenLemons;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (lemonsPurchased == "thirty")
            {
                player.cash -= priceOfThirtyLemons;
                inventory.lemonInventory += 30;
                day.moneySpentToday += priceOfThirtyLemons;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (lemonsPurchased == "fortyfive")
            {
                player.cash -= priceOfFortyfiveLemons;
                inventory.lemonInventory += 45;
                day.moneySpentToday += priceOfFortyfiveLemons;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else
            {
                Console.WriteLine("Not an option. Try again!");
                SellLemons(player, inventory, day);
            }

        }

        public void SellSugar(Player player, Inventory inventory, Day day)
        {
            Console.WriteLine($"Would you like to buy 'fifteen' packs of sugar for ${priceOfFifteenSugar}, 'thirty' for ${priceOfThirtySugar}, or 'fortyfive' for ${priceOfFortyfiveSugar}?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            sugarPurchased = Console.ReadLine();
            Console.ResetColor();
            if (sugarPurchased == "fifteen")
            {
                player.cash -= priceOfFifteenSugar;
                inventory.sugarInventory += 15;
                day.moneySpentToday += priceOfFifteenSugar;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (sugarPurchased == "thirty")
            {
                player.cash -= priceOfThirtySugar;
                inventory.sugarInventory += 30;
                day.moneySpentToday += priceOfThirtySugar;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (sugarPurchased == "fortyfive")
            {
                player.cash -= priceOfFortyfiveSugar;
                inventory.sugarInventory += 45;
                day.moneySpentToday += priceOfFortyfiveSugar;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else
            {
                Console.WriteLine("Not an option. Try again!");
                SellSugar(player, inventory, day);
            }
        }

        public void SellIce(Player player, Inventory inventory, Day day)
        {
            Console.WriteLine($"Would you like to buy 'fifteen' bundles of ice for ${priceOfFifteenIce}, 'thirty' for ${priceOfThirtyIce}, or 'fortyfive' for ${priceOfFortyfiveIce}?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            icePurchased = Console.ReadLine();
            Console.ResetColor();
            if (icePurchased == "fifteen")
            {
                player.cash -= priceOfFifteenIce;
                inventory.iceInventory += 15;
                day.moneySpentToday += priceOfFifteenIce;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (icePurchased == "thirty")
            {
                player.cash -= priceOfThirtyIce;
                inventory.iceInventory += 30;
                day.moneySpentToday += priceOfThirtyIce;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else if (icePurchased == "fortyfive")
            {
                player.cash -= priceOfFortyfiveIce;
                inventory.iceInventory += 45;
                day.moneySpentToday += priceOfFortyfiveIce;
                Console.WriteLine("Thanks for your purchase! You now have {0} dollars.", player.cash);
            }
            else
            {
                Console.WriteLine("Not an option. Try again!");
                SellIce(player, inventory, day);
            }
        }

    }
}