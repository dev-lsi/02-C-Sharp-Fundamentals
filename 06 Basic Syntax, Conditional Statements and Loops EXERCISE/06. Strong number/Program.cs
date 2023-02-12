using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int currInteger = 0;
            int factOfCurrInt = 0;
            int SumOfFactiriels = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                currInteger = int.Parse(inputString[i].ToString());
                factOfCurrInt = FactorielOf(currInteger);
                SumOfFactiriels = SumOfFactiriels + factOfCurrInt;
            }

            if (SumOfFactiriels == int.Parse(inputString))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }

        static int FactorielOf(int a)
        {
            int factoriel = 1;
            
            if (a == 1)
            {
                factoriel = 1;
                return factoriel;
            }
            else if (a == 0)
            {
                factoriel = 1;
                return factoriel;
            }
            else
            {
                for (int i = 2; i <= a; i++)
                {
                    factoriel = factoriel * i;
                }
                
                return factoriel;
            }
        }
    }
}
