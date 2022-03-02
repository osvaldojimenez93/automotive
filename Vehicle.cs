using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using CsvHelper.TypeConversion;
using CsvHelper.Configuration;
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
        //public List<Fault> allFaults = new List<Fault>();
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
        
        //public void AddFault(string vehicleName, DateTime date, string location, string description, string partNumber )
        public void AddFault(Vehicle obj)
        {
            
            Console.WriteLine($"Creating a fault for vehicle named: {obj.Nickname}");
            var vehicleName = obj.Nickname;
            Console.WriteLine("Please Describe the fault you want to annotate:");
            var description = Console.ReadLine();
            Console.WriteLine("Please enter the part number (if none enter N/A):");
            var partNumber = Console.ReadLine();
            Console.WriteLine("What location of the vehicle is this fault at? (e.g., Passenger front, Driver rear, etc.");
            var location = Console.ReadLine();
            var date = DateTime.Today;
                   
                                   
            var fault = new Fault(vehicleName, date, location, description, partNumber);
            List<Fault> allFaults = new List<Fault>();
            allFaults.Add(fault);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using (var stream = File.Open("/home/osjimene/automotive/Faults.csv",FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {                               
                csv.WriteRecords(allFaults);
            } 
        }
    }
}