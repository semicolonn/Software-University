﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Numbers_1._._.N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());

            for (int i = 1; i <= max; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
