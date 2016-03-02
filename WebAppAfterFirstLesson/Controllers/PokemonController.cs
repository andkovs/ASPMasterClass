using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAfterFirstLesson.Models;

namespace WebAppAfterFirstLesson.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Pokemon()
        {
            PokemonModels[] pokemons = {
                                           new PokemonModels{PokemonName="Pikachu", MasterName="Ash", PicUrl="pikachu.jpg"},
                                           new PokemonModels{PokemonName="Bulbasaur", MasterName="Ash", PicUrl="bulbasaur.jpg"},
                                           new PokemonModels{PokemonName="Vulpix", MasterName="Broke", PicUrl="vulpix.jpg"},
                                           new PokemonModels{PokemonName="Psyduck", MasterName="Misty", PicUrl="psyduck.jpg"}
                                       };


            return View(pokemons);
        }

        public ActionResult Team()
        {
            return View();
        }
    }
}