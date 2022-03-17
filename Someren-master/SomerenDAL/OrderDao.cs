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

        public void AddOrder(Order order)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters[0].Value = ("@OrderId", order.OrderId);
            sqlParameters[1].Value = ("@StudentId", order.StudentId);

            ExecuteEditQuery("INSERT INTO receipt (OrderId, StudentId)" +
                "VALUES (@OrderId, @StudentId);" +
                "SELECT SCOPE_IDENTITY();", sqlParameters);
        }
    }
}
