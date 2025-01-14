﻿namespace E10_Explicit_Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public string Country { get; }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
