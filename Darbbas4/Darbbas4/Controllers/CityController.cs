using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Darbbas4.Controllers
{
    public class CityController : ApiController
    {
        // GET: api/City
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/City/5
        public IRestResponse Get(string pav)
        {
            var client = new RestClient("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?namePrefix=" + pav);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "wft-geo-db.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "44567d52ccmshf11e31b8ae8fb6dp14ea5ejsn12f0d378b535");
            IRestResponse response = client.Execute(request);
            return response;
        }

        // POST: api/City
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/City/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/City/5
        public void Delete(int id)
        {
        }
    }
}
