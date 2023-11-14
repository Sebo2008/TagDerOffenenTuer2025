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
        public static List<PizzaObject> orderList = new List<PizzaObject>();
        public static void GetPizzaValuesFromInterface(string name, int spice, Collection<IngredientObject> checkedIngredients)
        {

        }
        public static void AddPizzaToOrder(string StandartPizzaName, int LevelOfSpice, ICollection<string> CheckedExtras)
        {
            List<IngredientObject> OrderIngredients = new();
            double price = 10.00;
            foreach (PizzaObject standartPizza in PizzaObject.StandartPizzas)
            {
                if (standartPizza.PizzaName.Equals(StandartPizzaName))
                {
                    foreach (IngredientObject standartPizzaIngredient in standartPizza.PizzaIngredients)
                    {
                        OrderIngredients.Add(standartPizzaIngredient);
                    }
                    price = standartPizza.Price;
                }
            }
            foreach (string extra in CheckedExtras)
            {
                foreach (IngredientObject ingredient in IngredientObject.StandartIngredients)
                {
                    if (extra.Equals(ingredient.ingredientName))
                    {
                        OrderIngredients.Add(ingredient);
                    }
                }
            }
            Order.orderList.Add(new PizzaObject(-1, LevelOfSpice, StandartPizzaName, price, OrderIngredients));
        }
        public static double ContinueToCheckout(int discount)
        {
            double totalPrice = 0;
            foreach (PizzaObject orderedPizza in Order.orderList)
            {
                totalPrice =+ orderedPizza.Price;
            }
            return totalPrice - totalPrice / 100 * discount;
        }
    }
}
