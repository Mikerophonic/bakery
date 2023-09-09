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
            Console.WriteLine("How many loaves of bread would you like?");
            int breadAmount = Convert.ToInt32(Console.ReadLine());

            Bread newBread = new Bread(breadAmount);
            int breadPrice = newBread.CalculateBreadPrice(newBread.Amount);
            
            Console.WriteLine($"The total cost of your bread order is: ${breadPrice}");



            
        }
    }
}