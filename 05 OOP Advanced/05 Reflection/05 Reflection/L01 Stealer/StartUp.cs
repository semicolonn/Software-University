﻿using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        var spy = new Spy();

        var result = spy.StealFieldInfo("Hacker", "username", "password");

        Console.WriteLine(result);
    }
}