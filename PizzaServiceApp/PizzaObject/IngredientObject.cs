using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
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
        IngredientObject(int id, string name)
        {
            this.ingredientID = id;
            this.ingredientName = name;
        }
        IngredientObject() { }
        public static List<IngredientObject> ?StandartIngredients = new();
        public static void IngredientsJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            StandartIngredients = JsonConvert.DeserializeObject<List<IngredientObject>>(File.ReadAllText("Ingredients.json"));
            foreach (var ingredient in IngredientObject.StandartIngredients.Select((value, i) => new { i, value }))
            {
                var value = ingredient.value;
                var index = ingredient.i;
                ingredient.value.ingredientID = index;
            }
            File.WriteAllText("Ingredients.json", System.Text.Json.JsonSerializer.Serialize(IngredientObject.StandartIngredients, options));
        }
    }
}
