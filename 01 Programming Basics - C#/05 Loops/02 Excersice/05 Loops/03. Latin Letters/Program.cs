﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet: ");
            for (char letter ='a'; letter <= 'z'; letter++)
            {
                Console.WriteLine($"{letter}");
            }
        }
    }
}
