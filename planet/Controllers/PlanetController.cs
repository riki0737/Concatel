using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using planet.modelos;
namespace planet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        public List<Planeta> planets = new List<Planeta>() {
            new Planeta{ Id = 1, Name = "venoris"},
            new Planeta{Id = 2,Name = "geonte"},
        };
        // GET: api/Planet
        [HttpGet]
        public IEnumerable<Planeta> Get()
        {
            return planets;
        }

        public Planeta Getid(int id)
        {
            return planets[id];
        }

        // GET: api/Planet/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetAction(int id)
        {
            var planeta = planets.FirstOrDefault((p) => p.Id == id);
            if (planeta == null) {
                return NotFound();
            }
            return Ok(planeta);
        }
    }
}
