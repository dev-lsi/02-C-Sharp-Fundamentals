using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOrders = int.Parse(Console.ReadLine());
            
            
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());
            
            double bill = 0;
            double totalBill = 0;

            for (int i = 1; i <= nOrders; i++)
            {
                
                bill = ((days * capsulesCount) * pricePerCapsule);
                totalBill = totalBill + bill;
                Console.WriteLine($"The price for the coffee is: ${bill:f2}");
                if (i == nOrders)
                {
                    break;
                }
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
            }
            
            
            
            Console.WriteLine($"Total: ${totalBill:f2}");
        }
    }
}
