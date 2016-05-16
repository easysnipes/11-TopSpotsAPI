using _11_TopSpotsAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _11_TopSpotsAPI.Controllers
{ 
 [EnableCors(origins: "http://localhost:8080/", headers: "*", methods:"*")]

    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            //string AllText = File.ReadAllText("C:/dev/11-TopSpotsAPI-/TopSpotsAPI/TopSpotsAPI/topSpots.json");
            var jsonArray = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(File.ReadAllText("C:/dev/11-TopSpotsAPI-/TopSpotsAPI/TopSpotsAPI/topSpots.json"));

        return jsonArray;
        }
        //public object Get()
        //{
        //    string allText = File.ReadAllText("C:/dev/11-TopSpotsAPI-/TopSpotsAPI/TopSpotsAPI/topSpots.json");

        //    object jsonObject = JsonConvert.DeserializeObject(allText);
        //    return jsonObject;
        //}

    // GET: api/TopSpots/5
    public object Get(int id)
        {
        //string AllText = File.ReadAllText("C:/dev/11-TopSpotsAPI-/TopSpotsAPI/TopSpotsAPI/topSpots.json");
            var jsonArray = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(File.ReadAllText("C:/dev/11-TopSpotsAPI-/TopSpotsAPI/TopSpotsAPI/topSpots.json"));

            return "value";
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        var topSpot = new TopSpot
        {
            Name = value.name,
            Description = value.Description,
            Location = value.Location
        };

        var jsonArray = Get().Concat(new TopSpot[] { topSpot });
        var updatedJsonArray = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);

        File.WriteAllText("C:/dev/11-TopSpotsAPI-/TopSpotsAPI/TopSpotsAPI/topSpots.json", updatedJsonArray);
    }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
