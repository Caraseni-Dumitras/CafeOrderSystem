using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofe_Ordering_System.Entities
{
    public class Cook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dish> dishesToCook = new List<Dish>();

        public Dish GetDishToCook(List<Dish> dishes, string dishName)
        {
            var dishToCook = new Dish();
            foreach(var d in dishes)
            {
                if(d.Name == dishName)
                {
                    dishToCook = d;
                }
            }
            return dishToCook;
        }
    }
}
