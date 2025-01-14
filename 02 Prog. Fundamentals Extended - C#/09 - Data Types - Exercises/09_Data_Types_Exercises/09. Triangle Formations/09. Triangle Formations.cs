﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"Triangle is valid.");

                if (a * a + b * b == c * c) //stava s Math.Pow(a , 2)
                {
                    Console.WriteLine($"Triangle has a right angle between sides a and b");
                }
                else if (a * a + c * c == b * b)
                {
                    Console.WriteLine($"Triangle has a right angle between sides a and c");
                }
                else if (c * c + b * b == a * a)
                {
                    Console.WriteLine($"Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine($"Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine($"Invalid Triangle.");
            }
        }
    }
}
