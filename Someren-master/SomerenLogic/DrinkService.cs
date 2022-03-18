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

        public void ChangeStock(int itemID, int stockChange)
        {
            drinkDAO.UpdateDrinkStock(itemID, stockChange);
        }

        public void ChangeDrinkName(int itemID, string newDrinkName)
        {
            drinkDAO.UpdateDrinkName(itemID, newDrinkName);
        }
    }
}
