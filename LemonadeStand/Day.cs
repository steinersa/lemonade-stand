﻿using System;
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
        public int dayCount;
       

        //constructor
        public Day()
        {
            
        }

        //member methods
        public double CalculateDailyProfit()
        {
            dailyProfit = moneyMadeToday - moneySpentToday;
            if (dailyProfit >= 0)
            {
                Console.WriteLine($"You made {moneyMadeToday} dollars today at the stand! You spent {moneySpentToday} dollars on supplies, making it a daily profit of {dailyProfit} dollars!");
                return dailyProfit;
            }
            else
            {
                Console.WriteLine($"You made {moneyMadeToday} dollars today at the stand! You spent {moneySpentToday} dollars on supplies, making it a daily loss of {dailyProfit} dollars!");
                return dailyProfit;
            }
        }

        public int NextDay()
        {
            dayCount++;
            return dayCount;
        }
    }
}