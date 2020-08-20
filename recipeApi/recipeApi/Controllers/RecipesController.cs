using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using recipeApi.Models;
using recipeApi.Repos;

namespace recipeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        private readonly MockRecipeRepo _repo = new MockRecipeRepo();
        [HttpGet]
        public ActionResult<IList<Recepies>> GettAllRecepies()
        {
            var recepies = _repo.GetAllRecepies();
            return Ok(recepies);
        }

        [HttpGet("{id}")]
        public ActionResult<Recepies> GetRecepiesById()
        {
            return null;
        }

    }
}