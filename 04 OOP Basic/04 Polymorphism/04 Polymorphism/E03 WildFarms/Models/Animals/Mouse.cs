﻿namespace E03_WildFarms.Models.Animals
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{GetType().Name}s are not eating that type of food!");
            }
            base.Eat(food);
        }

        public override string MakeSound()
        {
            return $"SQUEEEAAAK!";
        }
    }
}
