﻿public class Hero
{
    private string name;
    private int experience;
    private Iweapon weapon;

    public Hero(string name, Iweapon weapon)
    {
        this.name = name;
        this.experience = 0;
        this.weapon = weapon;
    }

    public string Name
    {
        get { return this.name; }
    }

    public int Experience
    {
        get { return this.experience; }
    }

    public void Attack(Dummy target)
    {
        this.weapon.Attack(target);

        if (target.IsDead())
        {
            this.experience += target.GiveExperience();
        }
    }
}
//