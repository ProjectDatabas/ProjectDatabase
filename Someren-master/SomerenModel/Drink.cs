using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public Drink(int drinkID, string drinksName, int drinksPrice, int stock)
        {
            DrinkId = drinkID;
            DrinksName = drinksName;
            DrinksPrice = drinksPrice;
            Stock = stock;
        }

        public int DrinkId { get; }
        public string DrinksName { get; }
        public int DrinksPrice { get; set; }
        public int Stock { get; set; }
        public bool IsSufficientStock 
        {
            get 
            {
                return Stock > 10;
            } 
        }
    }
}
