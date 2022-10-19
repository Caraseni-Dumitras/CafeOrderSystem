using Cofe_Ordering_System.Entities;
using Cofe_Ordering_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofe_Ordering_System.DataStorage
{
    public class CookStorage: Cook
    {
        public List<Cook> CookList = new List<Cook>()
        {
            new Cook{
                Id = 0,
                Name = "Cook0",
                dishesToCook = { } },

            new Cook{
                Id = 1,
                Name = "Cook1",
                dishesToCook = { }},

            new Cook{
                Id = 2,
                Name = "Cook2",
                dishesToCook = { }},

            new Cook{
                Id = 3,
                Name = "Cook3",
                dishesToCook = { }},

            new Cook{
                Id = 4,
                Name = "Cook4",
                dishesToCook = { }},

            new Cook{
                Id = 5,
                Name = "Cook5",
                dishesToCook = { }},

            new Cook{
                Id = 6,
                Name = "Cook6",
                dishesToCook = { }},

            new Cook{
                Id = 7,
                Name = "Cook7",
                dishesToCook = { }}
        };
        

        public List<Cook> AssignOrderToCooker(List<Dish> dishesList, string dishName)
        {
            int checkNumberOfDishesToCook = 0;
            bool checkAssignation = false;
           
            foreach(var c in CookList)
            {
                checkNumberOfDishesToCook = c.dishesToCook.Count;
                if(checkNumberOfDishesToCook < 5)
                {
                    c.dishesToCook.Add(GetDishToCook(dishesList, dishName));
                    checkAssignation = true;
                }
                if(checkAssignation == true)
                {
                    break;
                }
            }
            return CookList;

        }

    }
}
