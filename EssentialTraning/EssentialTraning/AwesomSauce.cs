using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraning
{
    public class AwesomSauce
    {
        public List<string> Sauces { get; set; }
        public AwesomSauce()
        {
            Sauces = new List<string>();
        }
        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }
    }
}
