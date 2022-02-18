using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManager
{
    public class Fault
    {
        public string VehicleName {get; set;}
        public DateTime Date {get;}
        public string Location {get;}
        public string Description {get;}
        public string PartNumber {get; set;}
        

        public Fault( string vehicleName ,DateTime date, string location, string description, string partnumber)
        {
            VehicleName = vehicleName;
            Date = date;
            Location = location;
            Description = description;
            PartNumber = partnumber;
            

        }
    }
}