using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            List<string> namesList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = input.Split().ToArray();
                //Name is going count=3
                if (command.Length == 3)
                {
                    //check if name is on the list
                    bool isInTheList = false;
                    for (int j = 0; j < namesList.Count; j++)
                    {
                        if (namesList[j] == command[0])
                        {
                            isInTheList = true;
                        }
                    }
                    if (isInTheList)
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                        isInTheList = false;
                    }
                    else if (isInTheList == false)
                    {
                        namesList.Add(command[0]);
                    }
                }
                //Name is not going count=4
                if (command.Length == 4)
                {
                    //check if name is on the list
                    bool isInTheList = false;
                    for (int j = 0; j < namesList.Count; j++)
                    {
                        if (namesList[j] == command[0])
                        {
                            isInTheList = true;
                        }
                    }
                    if (isInTheList)
                    {
                        namesList.Remove(command[0]);
                        isInTheList = false;
                    }
                    else if (isInTheList == false)
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
                //new command
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, namesList));
        }
    }
}
