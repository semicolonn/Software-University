﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range_1to100
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", n);

        }
    }
}
