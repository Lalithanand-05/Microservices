using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassengerManagement
{
    public class PassengerModel
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string Destination { get; set; }
        public float Fare { get; set; }

    }
}
