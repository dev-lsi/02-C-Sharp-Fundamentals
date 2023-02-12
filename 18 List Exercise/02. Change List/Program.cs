using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delete {element} – delete all elements in the array, which are equal to the given element.
            //Insert { element} { position} – insert the element at the given position.

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int element = 0;

            while (input!="end")
            {
                string[] commandArr = input.Split().ToArray();
                
                // Delete command
                if (commandArr[0] == "Delete")
                {
                    element = int.Parse(commandArr[1]);
                    
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == element)
                        {
                            list.RemoveAt(i);
                            i--;
                        }
                    }

                }
                //Insert
                if(commandArr[0] == "Insert")
                {
                    int value = int.Parse(commandArr[1]);
                    int poss = int.Parse(commandArr[2]);
                    list.Insert(poss,value);
                }
                //next input reading
                input = Console.ReadLine();
            }

            //output
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
