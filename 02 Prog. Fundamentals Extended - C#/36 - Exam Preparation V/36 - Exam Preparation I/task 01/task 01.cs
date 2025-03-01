﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlags = int.Parse(Console.ReadLine()); //THE WING FLAPS
            double distancePerMeter = double.Parse(Console.ReadLine()); //THE DISTANCE (IN METERS) PER 1000 WING FLAPS
            int endurance = int.Parse(Console.ReadLine()); //THE ENDURANCE

            //GET HOW MANY RESTS WE WILL HAVE (DIVIDE THE WING FLAPS BY THE ENDURANCE)
            int rests = wingFlags / endurance;

            //GET THE TOTAL SECONDS WE WILL REST, MULTIPLY THE "rests" BY "5" (L) (LONG)
            //IF WE MULTIPLY "rests" by "5" IT DOES NOT MATTER THAT WE ARE STORING IT IN A LONG TYPE VARIABLE
            //INT * INT = INT (AND IF THE VALUES ARE TOO BIG, IT WILL OVERFLOW)
            //WHICH IS WHY WE CAST "5" TO LONG
            long seconds = rests * 5L;

            //CALCULATE THE DISTANCE (DIVIDE THE WING FLAPS BY 1000) AND MULTIPLY IT BY "m" (THE DISTANCE FOR 1000 METERS)
            double distance = (wingFlags / 1000) * distancePerMeter;

            //ADD THE TIME TAKEN WHILE TRAVELLING (EVERY 100 FLAPS - A SECOND) (ALL WING FLAPS DIVIDED BY 100)
            seconds += (wingFlags / 100);

            //PRINT THE OUTPUT
            Console.WriteLine("{0:F2} m.", distance); //FORMATED TO THE SECOND DIGIT AFTER THE DECIMAL POINT
            Console.WriteLine("{0} s.", seconds); //THE SECONDS PRINTED WITHOUT FORMATTING
        }
    }
}
