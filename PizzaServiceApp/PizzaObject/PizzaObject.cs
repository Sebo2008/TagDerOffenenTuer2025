using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using PizzaServiceApp.PizzaObject;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace PizzaServiceApp.PizzaObject
{
    public class PizzaObject
    {
        public int PizzaID { get; set; }
        public int LevelOfSpice { get; set; }
        public string PizzaName { get; set; }
        public double Price { get; set; }
        public List<IngredientObject> PizzaIngredients { get; set; }

        public PizzaObject(int pizzaID, int levelOfSpice, string pizzaName, double price, List<IngredientObject> ingredients)
        {
            this.PizzaID = pizzaID;
            this.LevelOfSpice = levelOfSpice;
            this.PizzaName = pizzaName;
            this.Price = price;
            this.PizzaIngredients = ingredients;
        }
        public static List<PizzaObject> StandartPizzas = new List<PizzaObject>();
        internal static readonly HashSet<string> standartPizzasHashSet;
        public static void PizzasJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            StandartPizzas = JsonConvert.DeserializeObject<List<PizzaObject>>(File.ReadAllText("PizzaObject/StandartPizzas.json"))!;
            foreach (var standartPizza in StandartPizzas.Select((value, i) => new { i, value }))
            {
                var value = standartPizza.value;
                var index = standartPizza.i;
                standartPizza.value.PizzaID = index;
                standartPizzasHashSet.Add(standartPizza.value.PizzaName);
            }
            File.WriteAllText("PizzaObject/StandartPizzas.json", System.Text.Json.JsonSerializer.Serialize(StandartPizzas, options));
        }
    }
}
