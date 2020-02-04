using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophmore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        public override double ComputeGradeAverage()
        {
            //TODO fix the implementation later
            return 4.0d;
        }

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidetioal.");

            return sb.ToString();
        }
    }
}
