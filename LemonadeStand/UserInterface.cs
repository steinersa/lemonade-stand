using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class UserInterface
    {
        //member variables


        //constructor
        public UserInterface()
        {

        }

        //member methods

        public void Pause()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.ResetColor();
        }

        public void Welcome()
        {
            Console.WriteLine("So I hear you want to open up a lemonade stand! Please enter your name before we go any further: ");
        }

        public void Directions(Player player)
        {
            Console.WriteLine($"Nice to meet you, {player.name}! Let me give you the rundown and $20 dollars to start. Your stand will be open seven days, make as much money as possible in that time! At the beginning of the week you’ll be presented with a weather forecast. However, each morning you’ll see the actual temperature for the day. Keep the temperature in mind when setting up your stand! Navigate through your inventory, recipe book, price book, and even the corner store to get your stand ready daily. Once you indicate you’re equipped to open, you’ll make servings of lemonade based on your current ingredient inventory and recipe! A word of caution - any lemonade made on a given day that does not sell will go bad! This is a pretty tightknit community and you’ll get some regular customers, as long as conditions meet their demands! Happy selling!");
        }

        public void Forecast()
        {
            Console.WriteLine("Weekly Weather Forecast:");
        }


    }
}