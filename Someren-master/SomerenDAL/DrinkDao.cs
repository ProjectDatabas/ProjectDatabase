using System;
using SomerenModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SomerenDAL
{
    public class DrinkDAO : BaseDao
    {
        public List<Drink> GetAll()
        {
            string query = "SELECT DrinksId, DrinksName, DrinksPrice, StockAmount FROM Drinks WHERE StockAmount > 1 AND DrinksPrice > 1 ORDER BY StockAmount, DrinksPrice, NrOfDrinksSold";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                // retrieve data from the dataTable
                int drinkID = (int)dr["DrinksID"];
                string drinksName = dr["DrinksName"].ToString();
                int drinksPrice = (int)dr["DrinksPrice"];
                int stock = (int)dr["StockAmount"];

                // add a new drink to the List
                drinks.Add(new Drink(drinkID, drinksName, drinksPrice, stock));
            }

            // return the filled list
            return drinks;
        }

        public void UpdateDrinkPrice(int itemID, int newDrinkPrice)
        {
            string query = "UPDATE Drinks SET DrinksPrice = @newDrinkPrice WHERE DrinksId = @itemID";

            SqlParameter[] sqlParameters = { new SqlParameter("@newDrinkPrice", SqlDbType.Int) { Value = newDrinkPrice }, new SqlParameter("@itemID", SqlDbType.Int) { Value = itemID } };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrinkStock(int itemID, int stockChange)
        {
            string query = "UPDATE Drinks SET StockAmount = @stockChange WHERE DrinksId = @itemID";

            SqlParameter[] sqlParameters = { new SqlParameter("@stockChange", SqlDbType.Int) { Value = stockChange }, new SqlParameter("@itemID", SqlDbType.Int) { Value = itemID } };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrinkName(int itemID, string newDrinkName)
        {
            string query = "UPDATE Drinks SET DrinksName = @newDrinkName WHERE DrinksId = @itemID";

            SqlParameter[] sqlParameters = { new SqlParameter("@newDrinkName", SqlDbType.NVarChar) { Value = newDrinkName }, new SqlParameter("@itemID", SqlDbType.Int) { Value = itemID } };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
