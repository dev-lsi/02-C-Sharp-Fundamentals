using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombArr= Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = bombArr[0];
            int power = bombArr[1];
            bool hasBomb = false;
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                //Obectification
                if (list[i] == number)
                {
                    hasBomb = true;
                    
                    if (i - power > 0)
                    {
                        startIndex = i - power;
                    }
                    if(i - power <= 0)
                    {
                        startIndex = 0;
                    }
                    if (i + power <= list.Count - 1)
                    {
                        endIndex = i + power;
                    }
                    if (i + power > list.Count - 1)
                    {
                        endIndex = list.Count - 1;
                    }
                   
                   //onsole.WriteLine("start index" + startIndex);
                    //nsole.WriteLine("end index" + endIndex);
                    //Bomb dissarming
                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                    //nsole.WriteLine("BombDissarmed" + string.Join(" ", list));

                    //Bomb dissarmed
                    i = -1;
                    continue;

                }
                //if its not a bomb
                else
                {
                    continue;
                }
            }
            
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }
            Console.WriteLine(sum);

        }
    }
}
