using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaServiceApp
{
    public class Discounts
    {
        public static List<string> cuponCodes = new();
        public static void InitializeCuponCodes()
        {
            foreach (string code in File.ReadAllLines("PizzaServiceApp/Discounts.txt"))
            {
                cuponCodes.Add(code);
            }
        }

    }
}
