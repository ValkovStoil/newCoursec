﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    public static class ExtensionMethods
    {
        public static int  WordCount(this string str)
        {
            var wordCOunt = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

            return wordCOunt;
        }
    }
}
