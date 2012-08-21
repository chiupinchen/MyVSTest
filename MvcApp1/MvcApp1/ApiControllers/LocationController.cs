using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApp1.ApiControllers
{
    public class LocationController : ApiController
    {
        // GET api/location
        public IEnumerable<string> Get()
        {
            System.Threading.Thread.Sleep(2000);
            return new string[] { "LA", "NYC" };
        }

        // GET api/location/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/location
        public void Post([FromBody]string value)
        {
        }

        // PUT api/location/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/location/5
        public void Delete(int id)
        {
        }
    }
}
