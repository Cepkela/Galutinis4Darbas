using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.Web.Http;

namespace Darbbas4.Controllers
{
    /// <summary>
    /// Kontroleris skirtas valdyti uzklausas
    /// </summary>
    public class CityController : ApiController
    {
        /// <summary>
        /// Paprastas get
        /// </summary>
        /// <returns></returns>
        // GET: api/City
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// Metodas skirtas get uzklausos valdymui
        /// </summary>
        /// <param name="pav"></param>
        /// <returns></returns>
        // GET: api/City/5
        [Cash(Duration =300)]
        public JToken Get(string pav)
        {
            try
            {
                var client = new RestClient("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?namePrefix=" + pav);
                var request = new RestRequest(Method.GET);

                request.AddHeader("x-rapidapi-host", "wft-geo-db.p.rapidapi.com");
                request.AddHeader("x-rapidapi-key", "f5c564499dmshdd7aa9b68712bd9p1c9a55jsn05309b38eba0");
                IRestResponse response = client.Execute(request);


                JObject json = JObject.Parse(response.Content);
                JToken datas = json["data"];
                JToken datas2 = datas[0];
                return datas2;
            }
            catch
            {

                JToken j = "Kazkas blogai";
                return j;
            }
        }
        /// <summary>
        /// Nerealizuotas
        /// </summary>

        // POST: api/City
        public void Post()
        {
        }
        /// <summary>
        /// Nerializuotas
        /// </summary>

        // PUT: api/City/5
        public void Put()
        {
        }
        /// <summary>
        /// Nerializuotas
        /// </summary>

        // DELETE: api/City/5
        public void Delete()
        {
        }
    }
}
