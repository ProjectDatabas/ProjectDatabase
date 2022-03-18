using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drinks> GetAllDrinks()
        {
            string query = "SELECT DrinksId, DrinksName, DrinksPrice, StockAmount FROM drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drink = new Drinks()
                {
                    DrinkId = (int)dr["DrinksId"],
                    DrinkName = (string)(dr["DrinksName"]),
                    DrinkPrice = (int)(dr["DrinksPrice"]),
                    DrinkStock = (int)(dr["StockAmount"])
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}