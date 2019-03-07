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
            //Customer sally = new Customer("Sally", 65, 1.00);
            //Customer peter = new Customer("Peter", 75, 8.00);

            //List<Customer> customers = new List<Customer>();
            //customers.Add(sally);
            //customers.Add(peter);

            
            
                //foreach (Customer thing in customers)
                //{
                    if (weatherPreference <= actualTemp.weather && moneyToSpend >= lemonade.price && player.cupsAvailableToSell > 0)
                    {
                        player.cash += lemonade.price;
                        day.moneyMadeToday += lemonade.price;
                        player.cupsAvailableToSell --;
                        Console.WriteLine("Thank you! From, {0}", this.name);
                    }
                //}
            

        }

    }
}

