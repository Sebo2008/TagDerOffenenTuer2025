using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzaServiceApp.PizzaObject
{
    internal class PizzaObject
    {
        int pizzaID;
        string pizzaName;

        PizzaObject(int pizzaID, string pizzaName)
        {
            pizzaID = this.pizzaID;
            pizzaName = this.pizzaName;
        }

       
        internal static readonly HashSet<string> standartPizzasHashSet =
            File.ReadAllLines("PizzaObject/standartPizzasList.txt").ToHashSet();

    }
}
