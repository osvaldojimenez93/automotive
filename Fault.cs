using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManager
{
    public class Fault
    {
        public DateTime Date {get;}
        public string Location {get;}
        public string Description {get;}
        public string PartNumber {get; set;}

        public Fault(DateTime date, string location, string description, string partnumber)
        {
            Date = date;
            Location = location;
            Description = description;
            PartNumber = partnumber;

        }
    }
}