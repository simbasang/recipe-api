using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using recipeApi.Models;
using recipeApi.Repos;

namespace recipeApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        private readonly IRecipeRepo _repo;

        public RecipesController(IRecipeRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public ActionResult<IList<Recepies>> GettAllRecepies()
        {

            var recepies = _repo.GetAllRecepies();
            return Ok(recepies);
        }

        [HttpGet("{id}")]
        public ActionResult<Recepies> GetRecepiesById(int id)
        {

            var recepie = _repo.GetRecepiesById(id);
            return Ok(recepie);
        }

    }
}