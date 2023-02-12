using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            //The price for a single person is as follows:

            //       Friday Saturday Sunday

            //Students 8.45 9.80 10.46

            //Business 10.90 15.60 16

            //Regular 15 20 22.50

            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;
            double endPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")   { pricePerPerson =8.45; }
                else if (dayOfWeek == "Saturday") { pricePerPerson =9.80; }
                else if (dayOfWeek == "Sunday")   { pricePerPerson =10.46; }
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday") { pricePerPerson = 10.90; }
                else if (dayOfWeek == "Saturday") { pricePerPerson = 15.60; }
                else if (dayOfWeek == "Sunday") { pricePerPerson = 16; }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday") { pricePerPerson =15; }
                else if (dayOfWeek == "Saturday") { pricePerPerson =20; }
                else if (dayOfWeek == "Sunday") { pricePerPerson =22.50; }
            }

            totalPrice = pricePerPerson * countOfPeople;

            if(groupType=="Students" && countOfPeople >= 30)
            {
                totalPrice = totalPrice * 0.85;
                endPrice = totalPrice;
            }
            else if(groupType== "Business"&& countOfPeople >= 100)
            {
                totalPrice = totalPrice - pricePerPerson * 10;
                endPrice = totalPrice;
            }
            else if (groupType == "Regular" && countOfPeople>=10 && countOfPeople<=20)
            {
                totalPrice = totalPrice * 0.95;
                endPrice = totalPrice;
            }
            else
            {
                endPrice = totalPrice;
            }


            Console.WriteLine($"Total price: {endPrice:f2}");

        }
    }
}
