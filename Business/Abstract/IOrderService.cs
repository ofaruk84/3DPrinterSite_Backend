using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetAllByUserId(int id);
        IDataResult<Order> GetByID(int orderid);
        IResult Add(Order order);
        IResult Delete(Order order);
        IDataResult<List<OrderDetailDto>> GetOrderDto(int orderid);
    }
}
