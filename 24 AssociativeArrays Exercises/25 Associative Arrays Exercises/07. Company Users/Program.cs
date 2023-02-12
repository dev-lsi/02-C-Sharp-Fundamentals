using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = 
                new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                else
                {
                    string[] inputArr = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                    string companyName = inputArr[0];
                    string employeeId = inputArr[1];
                    
                    if (!companyUsers.ContainsKey(companyName))
                    {
                        companyUsers.Add(companyName, new List<string> { employeeId });
                    }
                    else
                    {
                        if (companyUsers[companyName].Contains(employeeId))
                        {
                            continue;
                        }
                        else
                        {
                            companyUsers[companyName].Add(employeeId);
                            continue;
                        }
                    }
                }
            }
            //......output.......
            foreach (var company in companyUsers)
            {
                Console.WriteLine(company.Key);

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
