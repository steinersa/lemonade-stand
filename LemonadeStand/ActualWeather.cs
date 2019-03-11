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

// SOLID Design: Liskov Substitution Principle
// I decided to have this class and a PredictedWeather class inherit from a parent Weather class because they are both generating a type of weather, but are doing so in slightly unique ways. They both use the parent's random number generator.