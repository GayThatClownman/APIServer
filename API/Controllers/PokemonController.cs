using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        List<Pokemon> pokemons = new List<Pokemon>() 
        {
            new Pokemon() {Name = "Mismagius"},
            new Pokemon() {Name = "Darkrai"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
        
    }
}
