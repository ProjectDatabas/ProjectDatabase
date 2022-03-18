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
            string query = "SELECT * FROM receipt";
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
            SqlParameter[] sqlParameters = { new SqlParameter("@StudentId", SqlDbType.Int) { Value = order.StudentId },
                new SqlParameter("@DrinkId", SqlDbType.Int) { Value = order.DrinksIds[0] } };


            try
            {
                ExecuteEditQuery("INSERT INTO [Order] (StudentId, DrinkId)" +
                    "VALUES (@StudentId, @DrinkId);" +
                    "SELECT SCOPE_IDENTITY();", sqlParameters);
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong with saving to the database. " + e.Message);
            }


        }
    }
}
