using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace PizzaServiceApp.PizzaObject
{
    public class IngredientObject
    {
        public int ingredientID { get; set; }
        public string ingredientName { get; set; }
        public bool isOnPizza { get; set; }
        IngredientObject(int id, string name, bool isOnPizza)
        {
            this.ingredientID = id;
            this.ingredientName = name;
            this.isOnPizza = isOnPizza;
        }

        public static readonly List<IngredientObject> StandartIngredients = new();
        public static void IngredientsJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var testIngredient = new IngredientObject(0, "empty", false);
            File.WriteAllText("Ingredients.json", JsonSerializer.Serialize(testIngredient, options));
        }
    }
}
