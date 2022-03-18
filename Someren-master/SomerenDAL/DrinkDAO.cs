using System;
using SomerenModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace SomerenDAL
{
    public class DrinkDAO : BaseDao
    {
        public List<Drink> GetAll()
        {
            string query = "SELECT DrinksId, DrinksName, DrinksPrice, StockAmount FROM Drinks";
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
    }
}
