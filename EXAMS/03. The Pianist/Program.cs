using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] initial = Console.ReadLine().Split("|", 2);
                dict.Add(initial[0], initial[1]);
            }
            while (true)
            {
                string commandStr = Console.ReadLine();
                if (commandStr=="Stop")
                {
                    break;
                }
                else
                {
                    string[] commandArr = commandStr.Split("|");
                    if (commandArr[0]=="Add") //Add|{piece}|{composer}|{key}
                    {
                        if (dict.ContainsKey(commandArr[1]))
                        {
                            Console.WriteLine($"{commandArr[1]} is already in the collection!");
                        }
                        else
                        {
                            string val = commandArr[2] + "|" + commandArr[3];
                            dict.Add(commandArr[1],val);
                            Console.WriteLine($"{commandArr[1]} by {commandArr[2]} in {commandArr[3]} added to the collection!");
                        }
                    }
                    else if (commandArr[0] == "Remove")//Remove|{piece}
                    {
                        if (dict.ContainsKey(commandArr[1]))
                        {
                            dict.Remove(commandArr[1]);
                            Console.WriteLine($"Successfully removed {commandArr[1]}!");
                        }
                        else
                            Console.WriteLine($"Invalid operation! {commandArr[1]} does not exist in the collection.");
                    }
                    else if (commandArr[0] == "ChangeKey")
                    {
                        if (!dict.ContainsKey(commandArr[1]))
                        {
                            Console.WriteLine($"Invalid operation! {commandArr[1]} does not exist in the collection.");
                        }
                        else
                        {
                            string piece = commandArr[1];

                            string[] val=dict[piece].Split("|");
                            val[1] = commandArr[2];
                            string neval= val[0] + "|" + val[1];
                            dict[piece] = neval;
                            Console.WriteLine($"Changed the key of {commandArr[1]} to {commandArr[2]}!");
                        }
                    }
                }
            }

            foreach (var (v,k) in dict)
            {
                string[] arr2 = k.Split('|');
                Console.WriteLine($"{v} -> Composer: {arr2[0]}, Key: {arr2[1]}");
            }
        }
    }
}
