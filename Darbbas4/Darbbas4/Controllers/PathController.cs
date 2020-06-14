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
            var client = new RestClient("https://www.mapquestapi.com/directions/v2/route?key=IUioukh6TOaFypNnaHuJfuKM0xDknNti&from=" + pav + "&to=" + pav2 + "&outFormat=json&ambiguities=ignore&routeType=fastest&doReverseGeocode=false&enhancedNarrative=false&avoidTimedConditions=false");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            string jsona = JsonConvert.SerializeObject(json, Formatting.Indented);
            dynamic data = JObject.Parse(jsona);

            Place p = new Place();
            p.itemList.Add(data.streets);
            p.startPoint = pav;
            p.endPoint = pav2;
            using (StreamWriter sw = new StreamWriter((@"C:\Users\Cepkis\Source\Repos\Galutinis4Darbas\Darbbas4\Darbbas4\rez.txt"), true))
                {
                sw.WriteLine(data);
                }
            StreamReader sr = new StreamReader(@"C:\Users\Cepkis\Source\Repos\Galutinis4Darbas\Darbbas4\Darbbas4\rez.txt");
            string line;
            char[] chars = { ']',',' };
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("streets"))
                {
                    while (!line.Contains("]"))
                    {
                        line = sr.ReadLine();
                        p.itemList.Add(line);
                    }
                }
            }
            if (!string.IsNullOrEmpty(jsona))
            {
                string b = jsona.Split(',')[100];
                if (b == "streets")
                    p.itemList.Add(b);
            }
            return p;
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
