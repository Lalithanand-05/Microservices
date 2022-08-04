using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverManagement
{
    public class DriverModel
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string DropPoint { get; set; }
        public float Fare { get; set; }
    }
}
