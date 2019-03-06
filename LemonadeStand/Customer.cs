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
            //for each customer in a list...
            //buy
         
        }
    }
}

