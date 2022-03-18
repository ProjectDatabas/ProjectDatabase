using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class DrinksService
    {
        DrinksDao drinkdb;

        public DrinksService()
        {
            drinkdb = new DrinksDao();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
    }
}
