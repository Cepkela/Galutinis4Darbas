using Darbbas4.Models;
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
using System.Web.Caching;

namespace Darbbas4.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class PathController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/Path
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// Metodas skirtas valdyti Get uzklausa.
        /// </summary>
        /// <param name="pav"></param>
        /// <param name="pav2"></param>
        /// <returns></returns>
        [Cash(Duration =300)]
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
                p.Distance = Convert.ToDouble(datas["distance"]);
                JToken datas2 = datas["legs"];
                JToken datas3 = datas2[0];
                JToken datas4 = datas3["maneuvers"];

                p.StartPoint = pav;
                p.EndPoint = pav2;
                p.StartLink = "/api/City?pav=" + pav;
                p.EndLink = "/api/City?pav=" + pav2;
                int b = datas4.Count();
                for (int i = 0; i < b; i++)
                {
                    JToken datas5 = datas4[i];
                    JToken datas6 = datas5["streets"];
                    p.ItemList.Add(datas6);
                }

                return p;
            }
            catch
            {
                Place p = new Place();
                return p;
            }
        }
        /// <summary>
        /// Nerializuotas
        /// </summary>
        // POST: api/Path
        [HttpPost]
        public void Post()
        {
        }
        /// <summary>
        /// Nerializuotas
        /// </summary>
        // PUT: api/Path/5
        public void Put()
        {
        }
        /// <summary>
        /// Nerializuotas
        /// </summary>
        // DELETE: api/ApiWithActions/5
        public void Delete()
        {
        }
    }
}
