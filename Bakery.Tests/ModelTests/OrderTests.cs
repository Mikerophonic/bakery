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
          Bread newBread = new Bread();
          Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
    }
}