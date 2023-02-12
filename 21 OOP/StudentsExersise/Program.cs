using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsExersise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            
            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split();
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                list.Add(student);
            }
            foreach (var item in list.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine(item.ToString());
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
