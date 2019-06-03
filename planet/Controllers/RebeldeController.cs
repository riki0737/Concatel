using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using planet.modelos;
namespace planet.Controllers
{
    [Route("api/Planet/(PlanetID)/Rebelde")]
    [ApiController]
    public class RebeldeController : ControllerBase
    {
        // GET: api/Rebelde
        [HttpGet]
        public IEnumerable<Rebelde> Get(int pid)
        {
            //aqui miramos los rebeldes por planeta
            return new Rebelde[] { new Rebelde { Name = "Ricardo" } };
        }

        // GET: api/Rebelde/5


        // POST: api/Rebelde
        [HttpPost]
        public void Post([FromBody] string value, string nomp) {
        }
        
   

        // PUT: api/Rebelde/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
