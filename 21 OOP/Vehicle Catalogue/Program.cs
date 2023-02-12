using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //"{type}/{brand}/{model}/{horse power / weight}"
            Catalog catalog = new Catalog();
            catalog.Cars = new List<Car>();
            catalog.Trucks = new List<Truck>();
           

            while (true)
            {
                string[] input = Console.ReadLine().Split(@"/");
                if (input[0] == "end")
                {
                    break;
                }
                else
                {
                    string type = input[0];
                    string brand = input[1];
                    string model = input[2];
                    string horsePowerOrWeight = input[3];
                    if (type=="Car")
                    {
                        Car car = new Car();
                        car.Brand = brand;
                        car.Model = model;
                        car.HorsePower = horsePowerOrWeight;
                        catalog.Cars.Add(car);
                    }
                    else if (type=="Truck")
                    {
                        Truck truck = new Truck();
                        truck.Brand = brand;
                        truck.Model = model;
                        truck.Weight = horsePowerOrWeight;
                        catalog.Trucks.Add(truck);
                    }

                }
            }
            Console.WriteLine("Cars:");

            foreach (var car in (catalog.Cars).OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{ car.Brand}: { car.Model} - { car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            foreach (var truck in catalog.Trucks.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{ truck.Brand}: { truck.Model} - { truck.Weight}kg");
            }
             
             

        }
        //............................
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }
        class Catalog
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }

        }
    }
}
