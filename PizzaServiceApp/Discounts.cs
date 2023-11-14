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
                    CalculateTotalPrice(Convert.ToInt32(code[..2]));
                }
            }
        }
        public static double CalculateTotalPrice(int discount)
        {
            double totalPrice = 0;
            foreach (PizzaObject.PizzaObject orderedPizza in Order.orderList)
            {
                totalPrice = +orderedPizza.Price;
            }
            return totalPrice - totalPrice / 100 * discount;
        }
    }
}
