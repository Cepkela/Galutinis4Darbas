using Darbbas4.Rep;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Darbbas4.Controllers
{
    public class PathController : ApiController
    {
        // GET: api/Path
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Path/5
        public JObject Get(string pav)
        {
            PlaceRep pr = new PlaceRep();
            JObject j = new JObject();
            j = pr.Action(pav, "Naujamiestis");
            return j;

        }

        // POST: api/Path
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Path/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        public void Delete(int id)
        {
        }
    }
}
