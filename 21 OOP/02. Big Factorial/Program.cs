﻿using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = new BigInteger(1);

            for (int i = 1; i <= n; i++)
            {
                factoriel = factoriel * i;
            }

            Console.WriteLine(factoriel);
        }
    }
}
