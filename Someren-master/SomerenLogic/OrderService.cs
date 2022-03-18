using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDao orderdb;
        public List<int> drinksIds = new List<int>();
        public int student;

        public OrderService()
        {
            orderdb = new OrderDao();
        }

        public List<Order> GetStudents()
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }

        public void SendOrder(Order order)
        {
            orderdb.SendOrder(order);
        }
    }
}
