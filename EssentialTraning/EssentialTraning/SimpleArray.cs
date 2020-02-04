using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraning
{
    public class SimpleArray
    {
      public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }

        public override string ToString()
        {
            return $"They are {GroceryList.Length} and they are: {GroceryList.ToString()}";
        }
    }
}
