using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Lemonade
    {
        //member variables
        public double price;

        //constructor
        public Lemonade()
        {
            this.price = 1.00;
        }

        //member methods
        public void ChangePrice()
        {
            Console.WriteLine($"The current price per cup is {this.price} dollars.");
            Console.WriteLine("Please enter the price you'd like to sell a cup of lemonade for.");
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                double resultPrice = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                this.price = resultPrice;
                Console.WriteLine($"Your lemonade now costs {this.price} dollars a cup!");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to complete action.");
            }
        }

    }
}
