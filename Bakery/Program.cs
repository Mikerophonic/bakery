using Bakery.Models;
using System;
using System.Collections.Generic;


namespace AnagramChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Bakery!");
            Console.WriteLine("Bread is $5 a loaf. Buy two, get one free!");
            Console.WriteLine("Pastries are $2 each. Buy three, get one free!");
            Console.WriteLine("How many loaves of bread would you like?");
            int breadAmount = Convert.ToInt32(Console.ReadLine());

            Bread newBread = new Bread(breadAmount);
            int breadPrice = newBread.CalculateBreadPrice(newBread.Amount);
            
            Console.WriteLine("How many pastries would you like?");
            int pastryAmount = Convert.ToInt32(Console.ReadLine());

            Pastry newPastry = new Pastry(pastryAmount);
            int pastryPrice = newPastry.CalculatePastryPrice(newPastry.Amount);

            Console.WriteLine($"The total cost of your order is: ${breadPrice + pastryPrice}");



            
        }
    }
}