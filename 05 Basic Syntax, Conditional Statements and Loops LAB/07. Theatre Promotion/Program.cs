using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day / Age 0 <= age <= 18 18 < age <= 64 64 < age <= 122

            //Weekday        12$             18$           12$

            //Weekend        15$             20$           15$

            //Holiday        5$              12$           10$
            
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            //............
            if (dayType == "Weekday")
            {
                if (age > 64)
                {
                    price =12;
                }
                else if (age > 18)
                {
                    price =18;
                }
                else
                {
                    price =12;
                }
            }
            else if (dayType == "Weekend")
            {
                if (age > 64)
                {
                    price =15;
                }
                else if (age > 18)
                {
                    price =20;
                }
                else
                {
                    price =15;
                }
            }
            else
            {
                if (age > 64)
                {
                    price =10;
                }
                else if (age > 18)
                {
                    price =12;
                }
                else
                {
                    price =5;
                }
            }

            Console.WriteLine($"{price}$");

        }
    }
}
