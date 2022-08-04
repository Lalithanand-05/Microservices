using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassengerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public IEnumerable<PassengerModel> Get()
        {
            PassengerModel passengermodel1 = new PassengerModel();
            PassengerModel passengermodel2 = new PassengerModel();

            passengermodel1.PassengerId = 1;
            passengermodel1.PassengerName = "Mike";
            passengermodel1.Destination = "Cityx";
            passengermodel1.Fare = 56;

            passengermodel2.PassengerId = 1;
            passengermodel2.PassengerName = "Jake";
            passengermodel2.Destination = "Cityz";
            passengermodel2.Fare = 66;


            List<PassengerModel> passengerlist = new List<PassengerModel>();
            passengerlist.Add(passengermodel1);
            passengerlist.Add(passengermodel2);


            return passengerlist;
        }

        // GET api
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

     
    }
}
