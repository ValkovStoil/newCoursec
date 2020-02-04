using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public abstract double ComputeGradeAverage();

        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Send one {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName  + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
