using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        public int lemonInventory;
        public int sugarInventory;
        public int iceInventory;
       

        //constructor
        public Inventory()
        {
            this.lemonInventory = 0;
            this.sugarInventory = 0;
            this.iceInventory = 0;
        }

        //member methods

        public void DisplayInventory(Store store)
        {
            Console.WriteLine($"Your lemon inventory is: {this.lemonInventory}");
            Console.WriteLine($"Your sugar inventory is: {this.sugarInventory}");
            Console.WriteLine($"Your ice inventory is: {this.iceInventory}");
        }

    }
}