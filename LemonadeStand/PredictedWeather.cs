using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class PredictedWeather:Weather
    {
        //member variables
        
        //constructor
        public PredictedWeather()
        {

        }

        //member methods
        public override void GenerateWeather()
        {
            int[] weeklyForcastArray = new int[7];
            weeklyForcastArray[0] = RandomNumber(60, 110);
            weeklyForcastArray[1] = RandomNumber(60, 110);
            weeklyForcastArray[2] = RandomNumber(60, 110);
            weeklyForcastArray[3] = RandomNumber(60, 110);
            weeklyForcastArray[4] = RandomNumber(60, 110);
            weeklyForcastArray[5] = RandomNumber(60, 110);
            weeklyForcastArray[6] = RandomNumber(60, 110);

            foreach (int temp in weeklyForcastArray)
            {
                Console.WriteLine($"{temp} degrees");
            }

        }

    }
}