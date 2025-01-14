﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distanceTraveled;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTraveled = 0;
        }

        public string Model => this.model; //<---> { get { return this.model; } }

        public void Drive(int distance)
        {
            if (this.fuelConsumption * distance <= this.fuelAmount)
            {
                this.distanceTraveled += distance;
                this.fuelAmount -= this.fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:f2} {this.distanceTraveled}";
        }
    }
}
