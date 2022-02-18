using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.Globalization;

namespace VehicleManager
{
    public class Vehicle
    {
        public string? Nickname { get; set;}
        public string? Make {get;}
        public string? Model {get;}
        public int Year {get;}
        public string? Vin {get;}
        public int Mileage {get; set;}

        //Create a list that tracks all the faults on a vehicle.
        public List<Fault> allFaults = new List<Fault>();
        //Create a list that tracks all the vehicles in the Database.
        public List<Vehicle> vics = new List<Vehicle>();
        
        

        //public Vehicle(string nickname, string make, string model, int year, string vin, int mileage)
        public Vehicle()
        {
            Console.WriteLine("Please enter a the Vehicle information:");
            Console.WriteLine("Make:");
            var make = Console.ReadLine();
            Console.WriteLine("Model:");
            var model = Console.ReadLine();
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Vin:");
            var vin = Console.ReadLine();
            Console.WriteLine("Current Mileage:");
            int mileage = int.Parse(Console.ReadLine());

            Console.WriteLine($"Awesome! It looks like you have a {year.ToString()} {make} {model} with a whopping {mileage.ToString()} miles! Is that Correct?");
            Console.ReadKey();
            Console.WriteLine("What would you like to call this vehicle?");
            var nickname = Console.ReadLine();
            Console.WriteLine("Creating your vehicle...");
            

            Nickname = nickname;
            Make = make;
            Model = model;
            Year = year;
            Vin = vin;
            Mileage = mileage;
           
        }

        public void ParkVehicle(Vehicle obj)
        {
            using (var writer = new StreamWriter("/home/osjimene/automotive/Vehicles.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {                               
                vics.Add(obj);
                csv.WriteRecords(vics);
            } 
        }
        

    }
}