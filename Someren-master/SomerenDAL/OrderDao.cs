using System;
using SomerenModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT *OrderId, StudentId, DrinksId FROM receipt";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["OrderId"],
                    StudentId = (int)(dr["StudentId"]),
                };
                orders.Add(order);
            }
            return orders;
        }

        public void SendOrder(Order order)
        {
            try
            {
                for (int i = 0; i < order.DrinksIds.Count; i++)
                {
                    string queryInsertDrinks = "INSERT INTO [Order] (StudentId, DrinkId) VALUES (@StudentId, @DrinkId); SELECT SCOPE_IDENTITY();";
                    SqlParameter[] sqlParameters = { new SqlParameter("@StudentId", SqlDbType.Int) { Value = order.StudentId }, new SqlParameter("@DrinkId", SqlDbType.Int) { Value = order.DrinksIds[i] } };
                    ExecuteEditQuery(queryInsertDrinks, sqlParameters);


                    string queryUpdateStockDown = "UPDATE Drinks SET StockAmount -= @stockChange WHERE DrinksId = @itemID";
                    SqlParameter[] sqlParametersStockDown = { new SqlParameter("@stockChange", SqlDbType.Int) { Value = 1 }, new SqlParameter("@itemID", SqlDbType.Int) { Value = order.DrinksIds[i] } };
                    ExecuteEditQuery(queryUpdateStockDown, sqlParametersStockDown);


                    string queryUpdateNrSold = "UPDATE Drinks SET NrOfDrinksSold += @soldChange WHERE DrinksId = @itemID";
                    SqlParameter[] sqlParametersNrSold = { new SqlParameter("@soldChange", SqlDbType.Int) { Value = 1 }, new SqlParameter("@itemID", SqlDbType.Int) { Value = order.DrinksIds[i] } };
                    ExecuteEditQuery(queryUpdateNrSold, sqlParametersNrSold);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong with saving to the database. " + e.Message);
            }
        }
    }
}
