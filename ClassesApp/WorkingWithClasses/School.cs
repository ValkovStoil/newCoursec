using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    public class School
    {
        public string Name { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
       public string TwitterAddress
        {
            //make sure the twitter address starts with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555 - 1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public double AverageThreeScores(double a, double b, double c)
        //{
        //    var result = (a +b + c) / 3;
        //    return result;
        //}

        //replace with function body version of the same method
        public static double AverageThreeScores(double a, double b, double c) => (a + b + c) / 3;

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Addres);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
