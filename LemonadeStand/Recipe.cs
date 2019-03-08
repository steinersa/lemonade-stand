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
        public string recipeChoice;
        public int resultLemons;
        public int resultSugar;
        public int resultIce;

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
            Console.WriteLine("Would you like to change the amount of 'lemons', 'sugar', or 'ice'? Otherwise, if the recipe looks good to go, type 'exit'.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            recipeChoice = Console.ReadLine();
            Console.ResetColor();
            
            switch (recipeChoice)
            {
                case "lemons":
                    ChangeLemons();
                    ChangeRecipe();
                    break;
                case "sugar":
                    ChangeSugar();
                    ChangeRecipe();
                    break;
                case "ice":
                    ChangeIce();
                    ChangeRecipe();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Can't change that! Please type an option from above.");
                    ChangeRecipe();
                    break;
            }
        }

        public void ChangeLemons()
        {
            Console.WriteLine("Please enter the number of lemons you'd like in each cup.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string userAddingLemons = Console.ReadLine();
            Console.ResetColor();
            try
            {
                int resultLemons = Int32.Parse(userAddingLemons);
                this.lemonsAdded = resultLemons;
                Console.WriteLine("Your lemonade now contains {0} lemons!", this.lemonsAdded);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to complete action.");
            }
        }

        public void ChangeSugar()
        {
            Console.WriteLine("Please enter the number of sugar packets you'd like in each cup.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string userAddingSugar = Console.ReadLine();
            Console.ResetColor();
            try
            {
                int resultSugar = Int32.Parse(userAddingSugar);
                this.sugarAdded = resultSugar;
                Console.WriteLine("Your lemonade now contains {0} packets of sugar!", this.sugarAdded);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to complete action.");
            }
        }

        public void ChangeIce()
        {
            Console.WriteLine("Please enter the number of ice bundles you'd like in each cup.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string userAddingIce = Console.ReadLine();
            Console.ResetColor();
            try
            {
                int resultIce = Int32.Parse(userAddingIce);
                this.iceAdded = resultIce;
                Console.WriteLine("Your lemonade now contains {0} bundles of ice!", this.iceAdded);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to complete action.");
            }
        }

    }
}