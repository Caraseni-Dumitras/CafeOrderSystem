using Cofe_Ordering_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofe_Ordering_System.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int MinutesCookingTime { get; set; }
        public List<Ingredient> ingredients = new List<Ingredient>();

        public double GetPrice(List<Ingredient> ingredients, List<int> id)
        {
            double sum = 0;
            var ingredientsUsed = new List<Ingredient>();
            ingredientsUsed = ingredients.Where(e => id.Contains(e.Id)).ToList();

            foreach (var i in ingredientsUsed)
            {
                sum += i.Price;
            }

            return sum + (sum / 100) * 20;
        }

        public List<Ingredient> GetIngredient(List<Ingredient> ingredients, List<int> id)
        {
            var ingredientsUsed = new List<Ingredient>();
                ingredientsUsed = ingredients.Where(e => id.Contains(e.Id)).ToList();
            return ingredientsUsed;
        }
    }
}
