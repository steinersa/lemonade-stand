using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variables
        public string storeChoice;
        public int lemonsForSale;
        public int sugarForSale;
        public int iceForSale;

        //constructor
        public Store()
        {

        }

        //member methods
        public void SellToPlayer()
        {
            Console.WriteLine("Would you like to buy 'lemons', 'sugar', or 'ice'?");
            storeChoice = Console.ReadLine();

            switch (storeChoice)
            {
                case "lemons":
                    //lemons
                    break;
                case "sugar":
                    //sugar
                    break;
                case "ice":
                    //ice
                    break;
            }
        }


    }
}