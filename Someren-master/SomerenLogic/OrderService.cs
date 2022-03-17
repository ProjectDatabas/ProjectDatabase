using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDao studentdb;

        public OrderService()
        {
            studentdb = new OrderDao();
        }

        public List<Order> GetStudents()
        {
            List<Order> orders = studentdb.GetAllOrders();
            return orders;
        }
    }
}
