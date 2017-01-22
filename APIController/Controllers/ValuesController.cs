
using System.Collections.Generic;
using System.Web.Http;

namespace EPCenterAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
    }
}
