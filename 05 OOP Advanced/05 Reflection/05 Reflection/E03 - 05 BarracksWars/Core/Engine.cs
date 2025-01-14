﻿namespace E03___05_BarracksWars.Core
{
    using Contracts;
    using System;

    internal class Engine : IRunnable
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];

                    string result = this.commandInterpreter
                        .InterpretCommand(data, commandName)
                        .Execute();

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}