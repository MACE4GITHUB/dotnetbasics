﻿using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxingAndUnboxing.Example();
            StructImplementsInterface.Example();

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}