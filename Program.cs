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
            var vehicle1 = new Vehicle();
            vehicle1.ParkVehicle(vehicle1);

            Console.WriteLine("Looks like your new vehicle has been entered into our database. We have a:");
            Console.WriteLine($"Make: {vehicle1.Make} \nModel: {vehicle1.Model} \nYear: {vehicle1.Year} \nMileage: {vehicle1.Mileage}");
            Console.ReadKey();




        }

    }
}
