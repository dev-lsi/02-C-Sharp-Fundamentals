using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] daysOfweek = new string[7]
            {
             "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"
            };
            
            if(input<=0 || input > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            string day = string.Empty;
            
            for (int i = 0; i < daysOfweek.Length; i++)
            {
                day = daysOfweek[i];
                
                if (i == input-1)
                {
                    Console.WriteLine(day);
                }
                else
                {
                    continue;
                }
                
            }
        }
    }
}
