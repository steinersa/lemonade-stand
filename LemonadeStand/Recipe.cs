using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Recipe
    {
        //member variables
        public int lemonsAdded;
        public int sugarAdded;
        public int iceAdded;

        //constructor
        public Recipe()
        {
            this.lemonsAdded = 2;
            this.sugarAdded = 3;
            this.iceAdded = 1;
        }

        //member methods
        public void ChangeRecipe()
        {
            Console.WriteLine("The current recipe is set at " +this.lemonsAdded+ " lemons, " +this.sugarAdded+ " sugar packets, and " +this.iceAdded+ " ice bundles per cup of lemonade!");
            Console.WriteLine("Would you like to change the amount of 'lemons', 'sugar', or 'ice'? Otherwise, if it looks good to go, type 'exit'.");
        }

    }
}