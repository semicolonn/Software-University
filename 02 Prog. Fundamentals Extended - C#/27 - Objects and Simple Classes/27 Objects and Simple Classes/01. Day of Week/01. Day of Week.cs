﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = 
                DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("{0}", input.DayOfWeek);
        }
    }
}
