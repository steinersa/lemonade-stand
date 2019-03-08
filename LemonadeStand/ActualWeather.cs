using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class ActualWeather:Weather
    {
        //member variables

        //constructor
        public ActualWeather()
        {

        }

        //member methods
        public override void GenerateWeather()
        {
            weather = RandomNumber(60, 110);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The temperature today is: {weather} degrees");
            Console.ResetColor();
        }

    }
}
