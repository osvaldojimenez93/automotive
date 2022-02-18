using System;
using CsvHelper;
using System.Globalization;

namespace VehicleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Maintenance Program .... ");
            Console.WriteLine("Hello, lets get started entering a vehicle.");
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
            Console.WriteLine("Creating a Vehicle in the database...");

            var vehicle1 = new Vehicle(nickname, make, model, year, vin, mileage);

            Console.WriteLine("Looks like your new vehile has been entered into our database. We have a:");
            Console.WriteLine($"Make: {vehicle1.Make} \nModel: {vehicle1.Model} \nYear: {vehicle1.Year} \nMileage: {vehicle1.Mileage}");
            Console.ReadKey();

            var vics = new List<Vehicle>
            {
                new Vehicle(nickname, make, model, year, vin, mileage),
            };

            using (var writer = new StreamWriter("/home/osjimene/automotive/Vehicles.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(vics);
            }


        }

    }
}
