﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    class Console
    {
        static public string Ask (string questions)
        {
            System.Console.Write(questions);
            return System.Console.ReadLine();
        }
    }
}
