using recipeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeApi.Repos
{
    public class MockRecipeRepo : IRecipeRepo
    {
        public IList<Recepies> GetAllRecepies()
        {
            throw new NotImplementedException();
        }

        public Recepies GetRecepiesById()
        {
            throw new NotImplementedException();
        }
    }
}
