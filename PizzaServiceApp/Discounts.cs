using PizzaServiceApp.PizzaObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaServiceApp
{
    public class Discounts
    {
        public static int currentDiscount { get; set; } = 0;
        public static double currentTotalPrice { get; set; } = 0;
        public static List<string> cuponCodes = new();
        public static void InitializeCuponCodes()
        {
            cuponCodes = new(File.ReadAllLines("PizzaObject/DiscountCodes.txt"));
            foreach (string code in new List<string>(cuponCodes))
            {
                cuponCodes.Add(code);
            }
        }
        public static void CheckCode(string userInput)
        {
            foreach(string code in cuponCodes)
            {
                if (userInput.Equals(code[2..]))
                {
                    currentDiscount = Convert.ToInt32(code[..2]);
                }
            }
        }
        public static void CalculateTotalPrice()
        {
            foreach (PizzaObject.PizzaObject orderedPizza in Order.orderList)
            {
                int orderedPizzaDefaultIngredientCount;
                foreach (PizzaObject.PizzaObject pizzaObject in PizzaObject.PizzaObject.StandartPizzas)
                {
                    if (pizzaObject.PizzaID == orderedPizza.PizzaID)
                    {
                        orderedPizzaDefaultIngredientCount = pizzaObject.PizzaIngredients.Count();
                        orderedPizza.Price += (orderedPizza.PizzaIngredients.Count - orderedPizzaDefaultIngredientCount);
                        break;
                    }
                }
                currentTotalPrice += orderedPizza.Price;
            }
            currentTotalPrice -= currentTotalPrice / 100 * currentDiscount;
        }
    }
}
