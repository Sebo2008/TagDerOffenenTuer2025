using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaServiceApp.PizzaObject
{
    public class IngredientObject
    {
        int ingredientID;
        string ingredientName;

        IngredientObject(int id, string name)
        {
            this.ingredientID = id;
            this.ingredientName = name;
        }
    }
}
