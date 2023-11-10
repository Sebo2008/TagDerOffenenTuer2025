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
        public int pizzaID { get; set; }
        public string pizzaName { get; set; }

        PizzaObject(int pizzaID, string pizzaName)
        {
            this.pizzaID = pizzaID;
            this.pizzaName = pizzaName;
        }
        public static void jsonTest()
        {
            File.WriteAllText("jsonTest.json", JsonSerializer.Serialize(new PizzaObject(0, "test")));
        }

       
        internal static readonly HashSet<string> standartPizzasHashSet = File.ReadAllLines("PizzaObject/standartPizzasList.txt").ToHashSet();
    }
}
