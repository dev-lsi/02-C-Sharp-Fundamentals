using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 0-2 – baby

            · 3-13 – child

           · 14-19 – teenager

           · 20-65 – adult

           · >= 66 – elder*/

            int age = int.Parse(Console.ReadLine());
            string kindOfPerson = "";

            if (age <=2)
            {
                kindOfPerson = "baby";
            }
            else if (age <=13)
            {
                kindOfPerson = "child";
            }
            else if (age <=19)
            {
                kindOfPerson = "teenager";
            }
            else if (age <=65)
            {
                kindOfPerson = "adult";
            }
            else
            {
                kindOfPerson = "elder";
            }
            
            Console.WriteLine(kindOfPerson);
        }
    }
}
