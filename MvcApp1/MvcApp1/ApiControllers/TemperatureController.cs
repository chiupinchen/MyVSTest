using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApp1.ApiControllers
{
    public class TemperatureController : ApiController
    {
        // GET api/temperature
        public IEnumerable<int> Get()
        {
            System.Threading.Thread.Sleep(3000);
            return new int[] { 34, 72 };
        }

        // GET api/temperature/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/temperature
        public void Post([FromBody]string value)
        {
        }

        // PUT api/temperature/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/temperature/5
        public void Delete(int id)
        {
        }
    }
}
