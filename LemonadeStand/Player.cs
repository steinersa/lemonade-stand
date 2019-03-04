using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        public string name;

        //constructor
        public Player()
        {

        }

        //member methods

        public void GetName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }

        public void MakeLemonade()
        {
            throw new System.NotImplementedException();
        }

        public void GoToStore()
        {
            throw new System.NotImplementedException();
        }

        public void BuyInventory()
        {
            throw new System.NotImplementedException();
        }

        public void CheckInventory()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeRecipe()
        {
            throw new System.NotImplementedException();
        }
    }
}