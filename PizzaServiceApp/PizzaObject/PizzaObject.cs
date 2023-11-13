using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using PizzaServiceApp.PizzaObject;
using System.Threading.Tasks;

namespace PizzaServiceApp.PizzaObject
{
    public class PizzaObject
    {
        public int PizzaID { get; set; }
        public int LevelOfSpice { get; set; }
        public string PizzaName { get; set; }
        public double Price { get; set; }
        public List<IngredientObject> PizzaIngredients { get; set; }

        PizzaObject(int pizzaID, int levelOfSpice, string pizzaName, double price, List<IngredientObject> ingredients)
        {
            this.PizzaID = pizzaID;
            this.LevelOfSpice = levelOfSpice;
            this.PizzaName = pizzaName;
            this.Price = price;
            this.PizzaIngredients = ingredients;
        }
        public static void PizzasJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("StandartPizzas.json", JsonSerializer.Serialize(new PizzaObject(0, 0, "empty", 0.00, IngredientObject.StandartIngredients), options));
        }
        internal static readonly HashSet<string> standartPizzasHashSet = File.ReadAllLines("PizzaObject/standartPizzasList.txt").ToHashSet();
        public static void GetPizzaValuesFromInterface(string name, int spice, bool extraCheese, bool extraDip)
        {
            foreach (IngredientObject ingredient in IngredientObject.StandartIngredients)
            {

            }
        }
    }
}
