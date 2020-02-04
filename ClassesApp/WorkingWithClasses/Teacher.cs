using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override double ComputeGradeAverage()
        {
            //TODO fix the implementation  later
            return 0.0d;
        }
    }
}
