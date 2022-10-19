using Cofe_Ordering_System.DataStorage;
using Cofe_Ordering_System.Entities;
using Cofe_Ordering_System.Repository;
using System;
using System.Linq;

namespace Cofe_Ordering_System
{
    class Program
    {
        static void Main(string[] args)
        {
            DishStorage dishStorage = new DishStorage();
            dishStorage.CreateDishesList();
            var dishesList = dishStorage.CreateDishesList();
            Console.WriteLine("MENU\n");
            bool check;
            foreach (var d in dishesList)
            {
                Console.WriteLine("Name: {0}", d.Name);
                Console.Write("Ingredients: ");

                foreach (var i in d.ingredients)
                {
                    check = i.Equals(d.ingredients.Last());
                    if (check)
                    {
                        Console.Write("{0}.", i.Name);
                    }
                    else
                    {
                        Console.Write("{0}, ", i.Name);
                    }
                }
                Console.WriteLine("\nPrice: {0}$\nDescription: {1}\n", d.Price, d.Description);
            }

            Console.WriteLine("\nDish Order");
            int answer = 0;
            CookStorage cookStorage = new CookStorage();
            do
            {
                Console.WriteLine("\nPlease enter the name of the dish you would like to order: ");
                string dishName = Console.ReadLine();

                cookStorage.AssignOrderToCooker(dishesList, dishName);

                foreach (var c in cookStorage.CookList)
                {
                    Console.WriteLine("\nName: {0}", c.Name);
                    Console.Write("DishesToCook: ");
                    foreach (var d in c.dishesToCook)
                    {
                        Console.Write("{0}, ", d.Name);
                    }
                }
                Console.WriteLine("Do you want to make another order? 0 -> yes / 1 -> no");
                answer = Int16.Parse(Console.ReadLine());
            } while (answer == 0);

            Console.ReadLine();
        }
    }
}
