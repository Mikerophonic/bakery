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
    }
}