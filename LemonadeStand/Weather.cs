using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        public string weeklyForcast;

        //constructor
        public Weather()
        {

        }

        //member methods
        public void GenerateWeeklyForcast()
        {
            int[] weeklyweatherForcastArray = new int[7];
            weeklyweatherForcastArray[0] = RandomNumber(60, 110);
            weeklyweatherForcastArray[1] = RandomNumber(60, 110);
            weeklyweatherForcastArray[2] = RandomNumber(60, 110);
            weeklyweatherForcastArray[3] = RandomNumber(60, 110);
            weeklyweatherForcastArray[4] = RandomNumber(60, 110);
            weeklyweatherForcastArray[5] = RandomNumber(60, 110);
            weeklyweatherForcastArray[6] = RandomNumber(60, 110);

            foreach (int temp in weeklyweatherForcastArray)
            {
                Console.WriteLine(temp);
            }

        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}