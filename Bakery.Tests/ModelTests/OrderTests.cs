using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Test
{
    [TestClass]
    public class BakeryTests
    {

        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
          Bread newBread = new Bread(7);
          Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetBreadAmount_ReturnsBreadAmount_Int()
        {
          Bread newBread = new Bread(7);
          Assert.AreEqual(7, newBread.Amount);
        }

        [TestMethod]
        public void CalculateBreadPrice_ReturnsBreadPrice_Int()
        {
          Bread newBread = new Bread(7);
          int result = newBread.CalculateBreadPrice(newBread.Amount);
          Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
          Pastry newPastry = new Pastry(5);
          Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void GetPastryAmount_ReturnsPastryAmount_Int()
        {
          Pastry newPastry = new Pastry(5);
          Assert.AreEqual(5, newPastry.Amount);
        }

    }
}