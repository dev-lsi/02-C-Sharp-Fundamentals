using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudents = 
                new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");
                if (input[0] == "end")
                {
                    break;
                }
                else
                {
                    if (!courseStudents.ContainsKey(input[0]))
                    {
                        courseStudents.Add(input[0],new List<string>{input[1]});
                    }
                    else
                    {
                        courseStudents[input[0]].Add(input[1]);
                    }
                }

            }

            foreach (var (course,students) in courseStudents)
            {
                Console.WriteLine($"{course}: {students.Count}");

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
