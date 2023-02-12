using System;
using System.Collections.Generic;

namespace Students
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();
            

            while (true)
            {
                bool isAlreadyIn = false;
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else
                {
                    string[] studentInfo = input.Split();
                    string firstName = studentInfo[0];
                    string lastName = studentInfo[1];
                    string age = studentInfo[2];
                    string homeTown = studentInfo[3];
                    
                    foreach (var s in list)
                    {
                        if (s.FirstName == firstName && s.LastName == lastName)
                        {
                            s.Age = age;
                            s.HomeTown = homeTown;
                            isAlreadyIn = true;
                            break;
                        }
                        
                    }
                    if (isAlreadyIn == false)
                    {
                        Student student = new Student();
                        student.FirstName = firstName;
                        student.LastName = lastName;
                        student.Age = age;
                        student.HomeTown = homeTown;
                        list.Add(student);
                        isAlreadyIn = false;
                    }


                }
            }

            string city = Console.ReadLine();

            foreach (var s in list)
            {
                
                    if (s.HomeTown == city)
                    {
                        Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.");
                    }
                
            }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
