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
        public static int currentDiscount { get; set; }
        public static double currentTotalPrice { get; set; }
        public static List<string> cuponCodes = new();
        public static void InitializeCuponCodes()
        {
            Discounts.cuponCodes = new(File.ReadAllLines("PizzaObject/DiscountCodes.txt"));
        }
        public static void CheckCode(string userInput)
        {
            foreach(string code in cuponCodes)
            {
                if (userInput.Equals(code[2..]))
                {
                    currentDiscount = Convert.ToInt32(code[..2]);
                    break;
                }
                else
                {
                    currentDiscount = 0;
                }
            }
            CalculateTotalPrice();
        }
        public static void CalculateTotalPrice()
        {
            currentTotalPrice = 0;
            foreach (PizzaObject.PizzaObject orderedPizza in Order.orderList)
            {
                int orderedPizzaDefaultIngredientCount;
                foreach (PizzaObject.PizzaObject pizzaObject in PizzaObject.PizzaObject.StandartPizzas)
                {
                    orderedPizzaDefaultIngredientCount = pizzaObject.PizzaIngredients.Count();
                    if (pizzaObject.PizzaID == orderedPizza.PizzaID)
                    {
                        currentTotalPrice += (orderedPizza.PizzaIngredients.Count - orderedPizzaDefaultIngredientCount) * 0.75;
                    }
                }
                currentTotalPrice += orderedPizza.Price;
            }
            currentTotalPrice -= currentTotalPrice * currentDiscount / 100;
        }
    }
}
