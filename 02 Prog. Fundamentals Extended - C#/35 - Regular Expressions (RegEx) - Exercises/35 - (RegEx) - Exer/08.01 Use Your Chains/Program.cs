﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08._01_Use_Your_Chains
{
    class Program
    {
        static void Main(string[] args)
        {
            string HTMLtext = Console.ReadLine();

            string pattern = @"<p>(.+?)<\/p>";

            MatchCollection matches = Regex.Matches(HTMLtext, pattern);

            string currentMatch = string.Empty;

            foreach (Match match in matches)
            {
                currentMatch += match.Groups[1].Value;
            }

            currentMatch = Regex.Replace(currentMatch, @"[^a-z0-9]", " ");
            currentMatch = Regex.Replace(currentMatch, @"\s+", " ");

            StringBuilder decryptedText = new StringBuilder();

            foreach (char @char in currentMatch)
            {
                char currentChar = @char;

                if (@char >= 'a' && @char <= 'm')
                {
                    currentChar = (char)(@char + 13);
                }

                else if (@char >= 'n' && @char <= 'z')
                {
                    currentChar = (char)(@char - 13);
                }

                decryptedText.Append(currentChar);
            }

            Console.WriteLine(decryptedText.ToString());
        }
    }
}
