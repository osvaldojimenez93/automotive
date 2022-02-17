using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManager
{
    public class Vehicle
    {
        public string Nickname { get; set;}
        public string Make {get;}
        public string Model {get;}
        public int Year {get;}
        public string Vin {get;}
        public int Mileage {get; set;}

        //Create a list that tracks all the faults on a vehicle.
        public List<Fault> allFaults = new List<Fault>();

        public Vehicle(string nickname, string make, string model, int year, string vin, int mileage)
        {
            Nickname = nickname;
            Make = make;
            Model = model;
            Year = year;
            Vin = vin;
            Mileage = mileage;
        }
        
    }
}