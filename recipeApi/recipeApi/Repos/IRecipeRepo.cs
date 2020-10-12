using recipeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeApi.Repos
{
    public interface IRecipeRepo
    {
        Task<IList<Recepies>> GetAllRecepies();
        Task<Recepies> GetRecepiesById(int id);
    }
}
