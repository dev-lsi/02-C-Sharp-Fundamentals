using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Add { number} – add the given number to the end of the list
            //•	Insert { number} { index} – insert the number at the given index
            //•	Remove { index} – remove the number at the given index
            //•	Shift left { count} – first number becomes last. This has to be repeated the specified number of times
            //•	Shift right { count} – last number becomes first. To be repeated the specified number of times

            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string inputString = Console.ReadLine();

            while (inputString!="End")
            {
                string[] commandArr = inputString.Split().ToArray();

              // executing commands  
                
                //Add {number}
                if (commandArr[0] == "Add")
                {
                    intList.Add(int.Parse(commandArr[1]));
                    
                    //Console.WriteLine($"Add: {(string.Join(".",intList))}");
                }
                //Insert { number} { index}
                if (commandArr[0] == "Insert")
                {
                    int number = int.Parse(commandArr[1]);
                    int index =  int.Parse(commandArr[2]);
                    if (index > intList.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        intList.Insert(index,number);
                    }
                    
                    //Console.WriteLine($"Insert: {(string.Join(".", intList))}");

                }
                //Remove { index} – remove the number at the given index
                if (commandArr[0] == "Remove")
                {
                    int index = int.Parse(commandArr[1]);
                    if (index > intList.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        intList.RemoveAt(index);
                    }
                    
                    //Console.WriteLine($"Remove: {(string.Join(".", intList))}");

                }
                //Shift left { count} – first number becomes last.
                //This has to be repeated the specified number of times.
                if (commandArr[1] == "left")
                {
                    int count = int.Parse(commandArr[2]);
                    
                    
                    for (int i = 0; i < count; i++)
                    {
                        int temp = intList[0];

                        for (int j = 0; j < intList.Count-1; j++)
                        {
                            intList[j] = intList[j + 1];
                        }
                        intList[intList.Count - 1] = temp;
                    }

                    //Console.WriteLine($"Sift Left: {(string.Join(".", intList))}");

                }
                //Sift right
                if (commandArr[1] == "right")
                {
                    int count = int.Parse(commandArr[2]);
                    
                    for (int i = 0; i < count; i++)
                    {
                        int temp = intList[intList.Count - 1];
                        
                        for (int j = intList.Count - 1; j > 0; j--)
                        {
                            intList[j] = intList[j - 1];
                        }
                        intList[0] = temp;
                    }

                    //Console.WriteLine($"Sift Right: {(string.Join(".", intList))}");

                }

                //new command inputString
                inputString = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",intList));
            

        }
    }
}
