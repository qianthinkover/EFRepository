using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EPCenterAPI.Controllers
{
  
    public class MutilGetController : BaseAPIController
    {

        [ActionName("Demo")]
        // GET: api/MutilGet
        public IEnumerable<string> GetDemo()
        {
            return new string[] { "value1", "value2" };
        }


        [ActionName("Demo2")]
        // GET: api/MutilGet
        public IEnumerable<string> GetDemo2()
        {
            return new string[] { "value1", "value2" };
        }




        // GET: api/MutilGet
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MutilGet/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MutilGet
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MutilGet/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MutilGet/5
        public void Delete(int id)
        {
        }
    }
}
