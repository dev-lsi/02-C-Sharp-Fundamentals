using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> storrage = Console.ReadLine().Split(", ").ToList();
            
            string[] command = Console.ReadLine().Split().ToArray();
            
            List<string> resultList = new List<string>();
            string currPhone = string.Empty;

            while (command[0] != "End")
            {
                //o	"Add - {phone}"
                if (command[0] == "Add")
                {
                    currPhone = command[2];
                    if (!storrage.Contains(currPhone))
                    {
                        storrage.Add(currPhone);
                    }
                }
                //o	"Remove - {phone}"
                if (command[0] == "Remove")
                {
                    currPhone = command[2];
                    if (storrage.Contains(currPhone))
                    {
                        storrage.Remove(currPhone);
                    }
                }
                //o	"Bonus phone - {oldPhone}:{newPhone}"
                if (command[0] == "Bonus")
                {
                    string[] tempArr = command[3].Split(":").ToArray();
                    string oldPhone = tempArr[0];
                    string newPhone = tempArr[1];
                    
                    if (storrage.Contains(oldPhone))
                    {
                        for (int i = 0; i < storrage.Count; i++)
                        {
                            
                            if (i == storrage.Count-1)
                            {
                                string temp = oldPhone;
                                storrage.Remove(oldPhone);
                                storrage.Add(oldPhone);
                                storrage.Add(newPhone);
                                break;
                            }
                            else if (storrage[i] == oldPhone)
                            {
                                storrage.Insert(i+1, newPhone);
                                break;
                            }
                        }
                    }


                }
                //o	"Last - {phone}"
                if (command[0] == "Last")
                {
                    currPhone = command[2];
                    
                    if (storrage.Contains(currPhone))
                    {
                        storrage.Remove(currPhone);
                        storrage.Add(currPhone);
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(", ", storrage));

        }
    }
}
