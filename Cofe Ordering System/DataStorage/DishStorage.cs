using Cofe_Ordering_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofe_Ordering_System.Repository
{
    public class DishStorage: Dish
    {
        public IngredientStorage ingredientStorage = new IngredientStorage();

        List<int> ingredientsIdList0 = new List<int>(new int[] { 0, 1, 2 });
        List<int> ingredientsIdList1 = new List<int>(new int[] { 4, 3, 1 });
        List<int> ingredientsIdList2 = new List<int>(new int[] { 2, 6 });
        List<int> ingredientsIdList3 = new List<int>(new int[] { 4, 1, 7 });
        List<int> ingredientsIdList4 = new List<int>(new int[] { 6, 1, 3, 5 });
        List<int> ingredientsIdList5 = new List<int>(new int[] { 5, 4, 3 });
        List<int> ingredientsIdList6 = new List<int>(new int[] { 0, 4, 7 });
        List<int> ingredientsIdList7 = new List<int>(new int[] { 0, 1, 7, 2, 5});


        public List<Dish> CreateDishesList()
        {
            List<Dish> DishesList = new List<Dish>();
            DishesList.Add(new Dish {
                Id = 0,
                Name = "Dish1",
                Description = "Dish1 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList0),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList0),
                MinutesCookingTime = 10 });

            DishesList.Add(new Dish {
                Id = 1, Name = "Dish2",
                Description = "Dish2 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList1),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList1),
                MinutesCookingTime = 7 });

            DishesList.Add(new Dish {
                Id = 2,
                Name = "Dish3",
                Description = "Dish3 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList2),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList2),
                MinutesCookingTime = 8 });

            DishesList.Add(new Dish {
                Id = 3,
                Name = "Dish4",
                Description = "Dish4 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList3),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList3),
                MinutesCookingTime = 15 });

            DishesList.Add(new Dish {
                Id = 4,
                Name = "Dish5",
                Description = "Dish5 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList4),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList4),
                MinutesCookingTime = 10 });

            DishesList.Add(new Dish {
                Id = 5,
                Name = "Dish6",
                Description = "Dish6 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList5),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList5),
                MinutesCookingTime = 13 });

            DishesList.Add(new Dish {
                Id = 6,
                Name = "Dish7",
                Description = "Dish7 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList6),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList6),
                MinutesCookingTime = 9 });

            DishesList.Add(new Dish {
                Id = 7,
                Name = "Dish8",
                Description = "Dish8 Description",
                ingredients = GetIngredient(ingredientStorage.IngredientList, ingredientsIdList7),
                Price = GetPrice(ingredientStorage.IngredientList, ingredientsIdList7),
                MinutesCookingTime = 5 });

            return DishesList;
        }
    }
}
