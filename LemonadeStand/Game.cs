using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (Has A)
        public Player player;
        public Customer customer;
        public int runningMoneyTotal;
        public int weeklyWeatherForcast;


        //constructor
        public Game()
        {

        }

        //member methods (Can Do)
        public void GameSetup()
        {
            Console.WriteLine("Welcome to your new lemonade stand! Please enter your name before we go any further...");
            Player player = new Player();
            player.GetName();
            Console.WriteLine("Nice to meet you, {0}! Directions are as follows...", player.name);
            Weather weather = new Weather();
            weather.GenerateWeeklyForcast();
        }

        public void Day1()
        {
           
        }

        public void Day2()
        {

        }
    }
}