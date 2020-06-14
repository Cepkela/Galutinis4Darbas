using Darbbas4.Rep;
using Newtonsoft.Json.Linq;
using RestSharp;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Path/5
        public JObject Get(string pav, string pav2)
        {
            var client = new RestClient("https://www.mapquestapi.com/directions/v2/route?key=IUioukh6TOaFypNnaHuJfuKM0xDknNti&from=" + pav + "&to=" + pav2 + "&outFormat=json&ambiguities=ignore&routeType=fastest&doReverseGeocode=false&enhancedNarrative=false&avoidTimedConditions=false");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            return json;

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
