using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list=Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string input = Console.ReadLine();
            int temp = 0;
            bool changedList = false;
            

            while (input != "end")
            {
                string[] inputArr = input.Split().ToArray();
                
                if (inputArr[0] == "Add")
                {
                   
                    list.Add(int.Parse(inputArr[1]));
                    changedList = true;

                }
                if (inputArr[0] == "Remove")
                {
                    list.Remove(int.Parse(inputArr[1]));
                    changedList = true;

                }
                if (inputArr[0]== "RemoveAt")
                {
                    list.RemoveAt(int.Parse(inputArr[1]));
                    changedList = true;

                }
                if (inputArr[0] == "Insert")
                {
                    list.Insert(int.Parse(inputArr[2]),int.Parse(inputArr[1]));
                    changedList = true;

                }
                //checkings not changing the list

                //contains command
                if (inputArr[0] == "Contains")
                {
                    temp = int.Parse(inputArr[1]);
                    bool contains = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i]==temp)
                        {
                            contains = true;
                            break;
                        } 
                        else if(list[i] == temp)
                        {
                            contains = false;
                            continue;
                        }
                    }
                    if (contains)
                    {
                        Console.WriteLine("Yes");
                        contains = false;
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                        contains = false;
                    }
                }
                //PrintEven command

                if(inputArr[0] == "PrintEven")
                {
                    //temp = int.Parse(inputArr[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2==0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();

                }
                //PrintOdd command
                if (inputArr[0] == "PrintOdd")
                {
                    //temp = int.Parse(inputArr[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();

                }
                //GetSum command
                int sum = 0;
                if (inputArr[0] == "GetSum")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum = sum + list[i];
                    }
                    Console.WriteLine(sum);
                }
                //Filter condition number
                if (inputArr[0] == "Filter")
                {
                    temp = int.Parse(inputArr[2]);
                    
                    if (inputArr[1] == ">")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i]>temp)
                            {
                                Console.Write(list[i]+" ");
                            }
                        }
                        Console.WriteLine();

                    }
                    if (inputArr[1] == "<")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < temp)
                            {
                                Console.Write(list[i] + " ");
                            }
                        }
                        Console.WriteLine();

                    }
                    if (inputArr[1] == ">=")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] >= temp)
                            {
                                Console.Write(list[i] + " ");
                            }
                        }
                        Console.WriteLine();

                    }
                    if (inputArr[1] == "<=")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] <= temp)
                            {
                                Console.Write(list[i] + " ");
                            }
                        }
                        Console.WriteLine();

                    }
                }
                
                //read next command
                
                input = Console.ReadLine();


            }
            if (changedList==true)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {

            }
            
        }
    }
}
