using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            //vehicle1>>vehicle2>>vehicle3…"
            //o   "family"
            //o   "heavyDuty"
            //o   "sports"
            string[] input = Console.ReadLine().Split(">>").ToArray();
            string carType = string.Empty;
            int years = 0;
            int kilometers = 0;

            double tax = 0;
            double currTax = 0;
            double totalTax = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] vehInfoArr = input[i].Split().ToArray();
                carType = vehInfoArr[0];
                years=int.Parse(vehInfoArr[1]);
                kilometers=int.Parse(vehInfoArr[2]);
                
                
                if(carType== "family"|| carType == "heavyDuty" || carType == "sports")
                {
                    if(carType == "family")
                    {
                        tax = 50;
                        
                        currTax = (kilometers / 3000) * 12 + (tax - years * 5);
                        totalTax = totalTax + currTax;
                    }
                    else if(carType == "heavyDuty")
                    {
                        tax = 80;
                        currTax = (kilometers / 9000) * 14 + (tax - years * 8);
                        totalTax = totalTax + currTax;

                    }
                    else if (carType == "sports")
                    {
                        tax = 100;
                        currTax = (kilometers / 2000) * 18 + (tax - years * 9);
                        totalTax = totalTax + currTax;
                    }

                    Console.WriteLine($"A {carType} car will pay {currTax:f2} euros in taxes.");


                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                    
                }
                
            }


            Console.WriteLine($"The National Revenue Agency will collect {totalTax:f2} euros in taxes.");


        }
    }
}
