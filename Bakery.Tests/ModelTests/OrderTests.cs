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
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
          Anagram newOrder = new Order();
          Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}