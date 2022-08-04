using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirverController : ControllerBase
    {
        public IEnumerable<DriverModel> Get()
        {
            DriverModel drivermodel1 = new DriverModel();
            DriverModel drivermodel2 = new DriverModel();

            drivermodel1.DriverId = 11;
            drivermodel1.DriverName = "Bill";
            drivermodel1.DropPoint = "Cityx";
            drivermodel1.Fare = 56;

            drivermodel2.DriverId = 21;
            drivermodel2.DriverName = "Phil";
            drivermodel2.DropPoint = "Cityy";
            drivermodel2.Fare = 66;


            List<DriverModel> driverlist = new List<DriverModel>();
            driverlist.Add(drivermodel1);
            driverlist.Add(drivermodel1);


            return driverlist;
        }

        // GET api/
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/
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
