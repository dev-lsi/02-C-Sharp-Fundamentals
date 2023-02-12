using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
           //string password = Console.ReadLine();
            
            int failsCounter = 0;
            bool isPass = true;

            while(failsCounter<3)
            {
                string password = Console.ReadLine();
                if (username.Length != password.Length)
                {
                    failsCounter++;
                    Console.WriteLine($"Incorrect password. Try again.");
                    //password = Console.ReadLine();
                    continue;
                }
                else
                {
                    for (int i = 0; i < username.Length; i++)
                    {

                        if (username[i] == password[username.Length - 1 - i])
                        {
                            isPass = true;
                            continue;
                        }
                        else
                        {
                            isPass = false;
                            failsCounter++;
                            Console.WriteLine($"Incorrect password. Try again.");
                            //password = Console.ReadLine();
                            break;
                        }
                    }

                    if (isPass == true)
                    {
                        Console.WriteLine($"User { username } logged in.");
                        return;
                    }
                    else
                    {

                    }
                }
            }
            Console.WriteLine($"User { username } blocked!");
        }
    }
}
