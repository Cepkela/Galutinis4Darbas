using Newtonsoft.Json;
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
    public class CityController : ApiController
    {
        // GET: api/City
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/City/5
        public JToken Get(string pav)
        {
            var client = new RestClient("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?namePrefix=" + pav);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "wft-geo-db.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f5c564499dmshdd7aa9b68712bd9p1c9a55jsn05309b38eba0");
            IRestResponse response = client.Execute(request);

            JObject json = JObject.Parse(response.Content);
            string jsona = JsonConvert.SerializeObject(json, Formatting.Indented);
            JToken datas = json["data"];
            JToken datas2 = datas[0];
            return datas2; 
            ///s
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
