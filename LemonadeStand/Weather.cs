using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public abstract class Weather
    {
        //member variables
        public int weather;

        //constructor
        public Weather()
        {

        }

        //member methods
        public abstract void GenerateWeather();

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
