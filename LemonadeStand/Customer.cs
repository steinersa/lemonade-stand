using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables
        public string name;
        public int weatherPreference;
        public double moneyToSpend;
        public string recipePreference;
        public Day day;
        public Recipe price;
        public Recipe lemons;
        public Recipe sugar;
        public Recipe ice;
        //need to still instanciate these somewhere

        //constructor
        public Customer(string name, int weatherPreference, double moneyToSpend, string recipePreference)
        {
            this.name = name;
            this.weatherPreference = weatherPreference;
            this.moneyToSpend = moneyToSpend;
            this.recipePreference = recipePreference;

        }

        //member methods
        public void BuyLemonade()
        {
            if (this.weatherPreference == day.actualTemp && this.moneyToSpend == price.something  && this.recipePreference == )
            {
                
            }
        }
    }
}

