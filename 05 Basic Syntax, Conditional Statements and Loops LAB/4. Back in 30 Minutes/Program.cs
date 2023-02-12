using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newHour = hour;
            int newMinutes = minutes+30;

            if (newMinutes > 60)
            {
                newHour = hour + 1;
                newMinutes = newMinutes - 60;
            }
            if (newMinutes == 60)
            {
                newHour = hour + 1;
                newMinutes = 0;
            }
            if (newHour > 23)
            {
                newHour = 0;
            }

            Console.WriteLine($"{newHour}:{newMinutes:D2}");

            



        }
    }
}
