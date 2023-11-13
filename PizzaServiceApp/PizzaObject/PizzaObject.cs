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
        public double Price { get; set; }
        public List<IngredientObject> Ingredients { get; set; }

        PizzaObject(int pizzaID, string pizzaName, double price, List<IngredientObject> ingredients)
        {
            this.PizzaID = pizzaID;
            this.PizzaName = pizzaName;
            this.Price = price;
            this.Ingredients = ingredients;
        }
        public static void PizzsJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            List<IngredientObject> ingredients = new List<IngredientObject>();
            File.WriteAllText("StandartPizzas.json", JsonSerializer.Serialize(new PizzaObject(0, "empty", 0.00, ingredients), options));
        }

       
        internal static readonly HashSet<string> standartPizzasHashSet = File.ReadAllLines("PizzaObject/standartPizzasList.txt").ToHashSet();
    }
}
