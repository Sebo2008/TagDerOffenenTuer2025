using System;
using System.Collections.Generic;
using System.Linq;
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
        readonly HashSet<string> standartPizzasList = File.ReadAllLines("standartPizzasList.txt").ToHashSet();
    }
}
