using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,double[]> carsDict = 
                new Dictionary<string,double[]>(); //"{car}|{mileage}|{fuel}"
            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split("|",2);
                double[] carDatainput = inputArr[1].Split("|").Select(double.Parse).ToArray();
                carsDict.Add(inputArr[0], carDatainput); //key:car val:mileage|fuel
            }
            
            while (true)
            {
                string commandStr = Console.ReadLine();
                if (true)
                {
                    if (commandStr=="Stop")
                    {
                        break;
                    }
                    else
                    {
                        string[] command = commandStr.Split(" : "); 
                        
                        if (command[0]== "Drive") //•"Drive : {car} : {distance} : {fuel}"
                        {
                            string car = command[1];
                            double distanceToRun = double.Parse(command[2]);
                            double fuelToSpend = double.Parse(command[3]);
                            double[] CarData = carsDict[car]; //{car}|{mileage}|{fuel}
                            double mileageOfTheCar = CarData[0];
                            double fuelInTheCar = CarData[1];
                            
                            if (fuelInTheCar < fuelToSpend) ////"Not enough fuel to make that ride"
                            {
                                Console.WriteLine("Not enough fuel to make that ride");
                            }
                            else
                            {
                                //"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
                                mileageOfTheCar += distanceToRun;
                                fuelInTheCar -= fuelToSpend;
                                {
                                    carsDict[car][0] = mileageOfTheCar;
                                    carsDict[car][1] = fuelInTheCar;
                                    Console.WriteLine($"{car} driven for {distanceToRun} kilometers. {fuelToSpend} liters of fuel consumed.");
                                    if (mileageOfTheCar >= 100000)
                                    {
                                        Console.WriteLine($"Time to sell the {car}!");
                                        carsDict.Remove(car);
                                    }
                                }
                            }
                        }
                        else if (command[0] == "Refuel") //•"Refuel : {car} : {fuel}" 75l max
                        {
                            string car = command[1];
                            double fuel =double.Parse(command[2]);
                            double[] CarData = carsDict[car];
                            double fuelInTheCar = CarData[1];//{car}|{mileage}|{fuel}
                            double neededFuel = 75 - fuelInTheCar;
                            if (neededFuel >= fuel)
                            {
                                Console.WriteLine($"{car} refueled with {fuel} liters");
                                carsDict[car][1] = fuel+ fuelInTheCar;
                            }
                            else
                            {
                                Console.WriteLine($"{car} refueled with {neededFuel} liters");
                                carsDict[car][1] = 75; //{car}|{mileage}|{fuel}
                            }
                            
                        }
                        else if (command[0] == "Revert")  //•"Revert : {car} : {kilometers}":
                        {
                            string car = command[1];
                            double kilometersToRevert = double.Parse(command[2]);
                            double[] CarData = carsDict[car];
                            double mileageOfTheCar = CarData[0];
                            double resultKm = mileageOfTheCar - kilometersToRevert;
                            if (resultKm<=10000)
                            {
                                carsDict[car][0] = 10000; //{car}|{mileage}|{fuel}
                            }
                            else
                            {
                                carsDict[car][0] = resultKm;
                                Console.WriteLine($"{car} mileage decreased by {kilometersToRevert} kilometers");
                            }
                        }
                    }
                }
            }
            //............output.............//"{car}|{mileage}|{fuel}"
            //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
            foreach (var item in carsDict)
            {
                string car = item.Key;
                double mileage=carsDict[car][0];
                double fuel = carsDict[car][1];

                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
