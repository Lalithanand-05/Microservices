using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> myList = new List<string>() { "value1", "value2", "value3" };
        public IEnumerable<string> Get()
        {
            return myList;
        }

        public string Get(int id)
        {
            return myList[id];
        }

        public IEnumerable<string> Post([FromBody] string newval)
        {
            myList.Add(newval);
            return myList;
        }
    }
}
