using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroController : ControllerBase
    {
        public static List<Comic> comics = new List<Comic> {
            new Comic {Id = 1, Name = "Marvel"},
            new Comic {Id = 2, Name = "DC"}

        };
        public static List<Superhero> heroes = new List<Superhero> {
            new Superhero {
                Id = 1,
                firstName = "Peter",
                lastName = "Parker",
                heroName = "Spiderman",
                Comic = comics[0]
            },
             new Superhero {
                Id = 2,
                firstName = "Bruce",
                lastName = "Wayne",
                heroName = "Batman",
                Comic = comics[1]
            },
            

        };

        [HttpGet]

        public async Task<ActionResult<List<Superhero>>> GetSuperHeroes()
        {
            return Ok(heroes);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Superhero>> GetSingleHeroe(int id)
        {
            var hero = heroes.FirstOrDefault(h => h.Id == id);
            if (hero == null)
            {
                return NotFound("Sorry no heroes here.");
            }
            return Ok(hero);
        }

    }
}
