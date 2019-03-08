using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables
        public string name;
        public int weatherPreference;
        public double moneyToSpend;


        //constructor
        public Customer(string name, int weatherPreference, double moneyToSpend)
        {
            this.name = name;
            this.weatherPreference = weatherPreference;
            this.moneyToSpend = moneyToSpend;
          

        }

        //member methods
        public void BuyLemonade(Player player, Lemonade lemonade, Day day, Weather actualTemp)
        {   
                    if (weatherPreference <= actualTemp.weather && moneyToSpend >= lemonade.price && player.cupsAvailableToSell > 0)
                    {
                        player.cash += lemonade.price;
                        day.moneyMadeToday += lemonade.price;
                        player.cupsAvailableToSell --;
                        Console.WriteLine($"Thank you! From, {this.name}");
                    }
        }

    }
}

