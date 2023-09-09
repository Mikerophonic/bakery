using System.Collections.Generic;
using System.Linq;
using System;

namespace Bakery.Models
{
    public class Bread
    {
        public int Amount { get; set; }
        
        public Bread(int amount)
        {
            Amount = amount;
        }

        public int CalculateBreadPrice(int amount)
        {
            int total = (amount - (amount / 3)) * 5;
            return total;
        }
    }

    public class Pastry
    {
        public int Amount { get; set; }

        public Pastry(int amount)
        {
            Amount = amount;
        }

        public int CalculatePastryPrice(int amount)
        {
            int total = (amount - (amount / 4)) * 2;
            return total;
        }
    }
}