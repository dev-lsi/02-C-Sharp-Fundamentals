using System;

namespace Puppy_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //all in gramms
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            food = food * 1000;
            hay = hay * 1000;
            cover=cover*1000;
            weight = weight * 1000;
            double foodEaten = 300;
            
            double coverEaten = weight/3;
            bool isNotEnough = false;

            for (int i = 1; i <= 30; i++)
            {
                //food
                 
                if (food-foodEaten <= 0)
                {
                    isNotEnough = true;
                    break;
                }
                food = food - foodEaten;
                //hay
                if (i % 2 == 0)
                {
                    if (hay-food/20 <= 0)
                    {
                        isNotEnough = true;
                        break;
                    }
                    hay = hay - food/20;
                }
                //cover
                if (i % 3 == 0)
                {
                    
                    if (cover <= 0)
                    {
                        isNotEnough = true;
                        break;
                    }
                    cover = cover - coverEaten;
                }
                
                Console.WriteLine($"food={ food }");
                Console.WriteLine($"food %5={ food/20 }");
                Console.WriteLine($"hay={ hay }");
                Console.WriteLine($"cover={ cover }");

            }
            //output
            if (isNotEnough == true)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else if (isNotEnough == false)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
            }

        }
    }
}
