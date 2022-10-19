using Cofe_Ordering_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofe_Ordering_System.Repository
{
    public class IngredientStorage
    {
        public List<Ingredient> IngredientList = new List<Ingredient>()
        {
            new Ingredient{
                Id = 0,
                Name = "Ingredient0",
                Price = 10},

            new Ingredient{
                Id = 1,
                Name = "Ingredient1",
                Price = 9},

            new Ingredient{
                Id = 2,
                Name = "Ingredient2",
                Price = 7},

            new Ingredient{
                Id = 3,
                Name = "Ingredient3",
                Price = 15},
            new Ingredient{
                Id = 4,
                Name = "Ingredient4",
                Price = 9},
            new Ingredient{
                Id = 5,
                Name = "Ingredient5",
                Price = 12},
            new Ingredient{
                Id = 6,
                Name = "Ingredient6",
                Price = 8},
            new Ingredient{
                Id = 7,
                Name = "Ingredient7",
                Price = 3}
        };
    }
}
