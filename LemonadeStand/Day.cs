using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public int actualTemp;
        public int dailyProfit;
        public int lemonadeAvailableToSell;
       

        //constructor
        public Day()
        {

        }

        //member methods
        public void GenerateActualTemp()
        {
            actualTemp = RandomNumber(60, 110);
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}