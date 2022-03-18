using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class DrinkService
    {
        private DrinkDAO drinkDAO = new DrinkDAO();
        public List<Drink> GetAllDrinks()
        {
            return drinkDAO.GetAll();
        }
    }
}
