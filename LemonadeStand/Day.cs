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
        public double CalculateDailyProfit()
        {
            dailyProfit = moneyMadeToday - moneySpentToday;
            Console.WriteLine("You made " + moneyMadeToday + " dollars today at the stand! You spent " + moneySpentToday + " dollars on supplies, making your daily profit " +dailyProfit+ " dollars!");
            return dailyProfit;
        }


    }
}