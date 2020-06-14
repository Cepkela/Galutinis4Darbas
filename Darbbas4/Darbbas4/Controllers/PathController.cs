using Darbbas4.Models;
using Darbbas4.Rep;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
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
        public Place Get(string pav, string pav2)
        {
            try
            {
                var client = new RestClient("https://www.mapquestapi.com/directions/v2/route?key=IUioukh6TOaFypNnaHuJfuKM0xDknNti&from=" + pav + "&to=" + pav2 + "&outFormat=json&ambiguities=ignore&routeType=fastest&doReverseGeocode=false&enhancedNarrative=false&avoidTimedConditions=false");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                JObject json = JObject.Parse(response.Content);
                Place p = new Place();
                JToken datas = json["route"];
                p.distance = Convert.ToDouble(datas["distance"]);
                JToken datas2 = datas["legs"];
                JToken datas3 = datas2[0];
                JToken datas4 = datas3["maneuvers"];

                p.startPoint = pav;
                p.endPoint = pav2;
                p.startLink = "/api/City?pav=" + pav;
                p.endLink = "/api/City?pav=" + pav2;
                int b = datas4.Count();
                for (int i = 0; i < b; i++)
                {
                    JToken datas5 = datas4[i];
                    JToken datas6 = datas5["streets"];
                    p.itemList.Add(datas6);
                }




                return p;
            }
            catch
            {
                Place p = new Place();
                return p;
            }
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
