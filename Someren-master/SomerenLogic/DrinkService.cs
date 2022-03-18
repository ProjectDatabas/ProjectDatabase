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

        public void ChangeDrinkPrice(int itemID, int newDrinkPrice)
        {
            drinkDAO.UpdateDrinkPrice(itemID, newDrinkPrice);
        }

        public void AddNewDrink(string newDrinkName, int newDrinkPrice, int newDrinkStock)
        {
            drinkDAO.AddNewDrink(newDrinkName, newDrinkPrice, newDrinkStock);
        }

        public void SetToTen()
        {
            List<Drink> drinks = drinkDAO.GetAllDrinkIds();

            foreach  (Drink d in drinks)
            {
                ChangeStock(d.DrinkId, 10);
            }
        }

        public void DeleteDrink(int itemID)
        {
            drinkDAO.DeleteDrink(itemID);
        }
    }
}
