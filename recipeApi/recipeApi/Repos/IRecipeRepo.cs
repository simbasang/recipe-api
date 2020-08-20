using recipeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeApi.Repos
{
    public interface IRecipeRepo
    {
        IList<Recepies> GetAllRecepies();
        Recepies GetRecepiesById();
    }
}
