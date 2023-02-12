using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double TotalSumNeeded = 0;
            //Sabers needed
            int sabersNeeded = studentsCount * 10 + studentsCount;
            while (sabersNeeded % 10 != 0)
            {
                sabersNeeded++;
            }
            sabersNeeded = sabersNeeded / 10;
            
            //belts to pay
            int sixtCounter = 0;
            
            for (int i = 1; i <= studentsCount; i++)
            {
                if (i % 6 == 0)
                {
                    sixtCounter++;
                }
            }
            
            beltPrice = beltPrice * (studentsCount-sixtCounter);
            saberPrice = sabersNeeded * saberPrice;
            robePrice = robePrice * studentsCount;

            TotalSumNeeded = beltPrice + saberPrice + robePrice;
            

            //check balance

            if (moneyAmount >= TotalSumNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {TotalSumNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(TotalSumNeeded-moneyAmount):f2}lv more.");
            }
        }
    }
}
