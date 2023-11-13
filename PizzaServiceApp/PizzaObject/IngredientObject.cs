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
        public int ingredientID;
        public string ingredientName;
        public bool isOnPizza;
        IngredientObject(int id, string name, bool isOnPizza)
        {
            this.ingredientID = id;
            this.ingredientName = name;
            this.isOnPizza = isOnPizza;
        }
        readonly List<IngredientObject> ingredients = new();
        public static void IngredientsJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("Ingredients.json", JsonSerializer.Serialize(new IngredientObject(0, "empty", false)));
        }
    }
}
