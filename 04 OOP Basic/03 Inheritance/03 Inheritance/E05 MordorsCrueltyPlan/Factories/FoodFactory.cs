﻿namespace E05_MordorsCrueltyPlan.Factories
{
    using E05_MordorsCrueltyPlan.Models;
    using E05_MordorsCrueltyPlan.Models.Foods;

    public class FoodFactory
    {
        public Food GetFood(string foodType)
        {
            switch (foodType.ToLower())
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "apple":
                    return new Apple();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Junk();
            }
        }
    }
}
