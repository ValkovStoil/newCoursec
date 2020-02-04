using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    public class ScienceExperiment : IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public double Score { get; set; }
        public double MaximumScore { get; set; }
    }
}
