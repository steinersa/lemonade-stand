using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (Has A)
        public Player player;

        public int RunningMoneyTotal;
        public int weeklyWeatherForcast;
        public int Day;


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
            weather.GenerateWeeklyForcast(); //display weekly forcast?
        }

        public void StartDay()
        {
            throw new System.NotImplementedException();
        }
    }
}