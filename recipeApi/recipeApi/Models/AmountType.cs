using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeApi.Models
{
    public class AmountType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<RecepieIngrediens> RecipeIngrediens { get; set; }

    }
}
