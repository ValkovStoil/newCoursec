﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraning;

namespace EssentialTraningTest
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[1], "Milk");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("They are"));
        }
    }
}