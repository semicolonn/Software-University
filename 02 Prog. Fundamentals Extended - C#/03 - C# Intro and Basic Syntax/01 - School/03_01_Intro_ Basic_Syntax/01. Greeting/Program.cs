﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
