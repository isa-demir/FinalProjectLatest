using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        List<Order> GetOrdersByEmployeeId(int id);
        Order GetOrderById(int id);

    }
}
