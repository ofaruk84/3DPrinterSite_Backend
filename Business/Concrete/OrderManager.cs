using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class OrderManager:IOrderService
    {
        IOrderDal __orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            __orderDal = orderDal;
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(__orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<Order>>(__orderDal.GetAll(p => p.UserId == id));
        }

        public IDataResult<Order> GetByID(int orderid)
        {
            return new SuccessDataResult<Order>(__orderDal.Get(p => p.OrderId == orderid));
        }

        public IResult Add(Order order)
        {
            __orderDal.Add(order);
            return new SuccessResult();

        }

        public IResult Delete(Order order)
        {
            __orderDal.Delete(order);
            return new SuccessResult();

        }

        public IDataResult<List<OrderDetailDto>> GetOrderDto(int orderid)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(__orderDal.GetOrderDetails(orderid));
        }
    }
}
