using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalIncome = 0;
            double totalExpences = 0;

            for (int i = 1; i <= n; i++)
            {
                string city = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expences = double.Parse(Console.ReadLine());

                if (i % 5 == 0)
                {
                    income = income * 0.9;
                    income = income - expences;
                    totalIncome = totalIncome + income;
                    Console.WriteLine($"In {city} Burger Bus earned {income:f2} leva.");

                }
                else if (i % 3 == 0)
                {
                    expences = expences + expences * 0.5;
                    income = income - expences;
                    totalIncome = totalIncome + income;
                    Console.WriteLine($"In {city} Burger Bus earned {income:f2} leva.");
                }
                else
                {
                    income = income - expences;
                    totalIncome = totalIncome + income;
                    Console.WriteLine($"In {city} Burger Bus earned {income:f2} leva.");

                }


            }


            Console.WriteLine($"Burger Bus total profit: {totalIncome:f2} leva.");

        }
    }
}
