using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraning;

namespace EssentialTraningTest
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomTest()
        {
            var testInstance = new AwesomSauce();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

            //expect fals
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
