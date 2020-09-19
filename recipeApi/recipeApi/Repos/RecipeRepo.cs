using Microsoft.EntityFrameworkCore;
using recipeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeApi.Repos
{
    public class RecipeRepo : IRecipeRepo
    {
        private readonly RecepieDbContext _context;

        public RecipeRepo(RecepieDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Recepies>> GetAllRecepies()
        {
            var result = await _context.Recepies.ToListAsync();
            return result;
        }

        public async Task<Recepies> GetRecepiesById()
        {
            throw new NotImplementedException();
        }
    }
}
