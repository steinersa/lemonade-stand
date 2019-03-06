using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public double moneySpentToday;
        public double moneyMadeToday;
        public double dailyProfit;
       

        //constructor
        public Day()
        {

        }

        //member methods
        public void CalculateDailyProfit()
        {
            dailyProfit = moneyMadeToday -= moneySpentToday;
            Console.WriteLine("You made " + moneyMadeToday + " dollars today! You spent " + moneySpentToday + " dollars on supplies, making your daily profit " +dailyProfit+ " dollars!");
        }


    }
}