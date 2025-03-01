﻿using E03___05_BarracksWars.Models.Units;

namespace E03___05_BarracksWars.Models.Units
{
    public class Archer : Unit
    {
        private const int DefaultHealth = 25;
        private const int DefaultDamage = 7;

        public Archer()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}