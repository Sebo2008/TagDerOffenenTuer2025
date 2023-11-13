using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaServiceApp.PizzaObject
{
    public class PizzaObject
    {
        public int PizzaID { get; set; }
        public string PizzaName { get; set; }
        public decimal Price { get; set; }
        public List<IngredientObject> Ingredients { get; set; }

        PizzaObject(int pizzaID, string pizzaName, decimal price, List<IngredientObject> ingredients)
        {
            this.PizzaID = pizzaID;
            this.PizzaName = pizzaName;
            this.Price = price;
            this.Ingredients = ingredients;
        }
        public static void jsonTest()
        {
            File.WriteAllText("jsonTest.json", JsonSerializer.Serialize(new PizzaObject()));
        }

       
        internal static readonly HashSet<string> standartPizzasHashSet = File.ReadAllLines("PizzaObject/standartPizzasList.txt").ToHashSet();
    }
}
