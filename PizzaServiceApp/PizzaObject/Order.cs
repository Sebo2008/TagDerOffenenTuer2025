using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaServiceApp.PizzaObject
{
    public class Order
    {
        List<PizzaObject> orderList = new List<PizzaObject>();
        public static void GetPizzaValuesFromInterface(string name, int spice, Collection<IngredientObject> checkedIngredients)
        {

        }
        public static void AddPizzaToOrder(Collection<string> checkedExtras)
        {
            foreach (string extra in checkedExtras)
            {
                foreach (IngredientObject ingredient in IngredientObject.StandartIngredients)
                {
                    if (extra.Equals(ingredient.ingredientName))
                    {

                    }
                }
            }
        }

    }
}
