﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The \"use\" of quotations causes difficulties.";
            string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
        }
    }
}
