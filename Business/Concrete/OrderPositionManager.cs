using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderPositionManager : IOrderPositionService
    {
        IOrderPositionDal _orderPositionDal;

        public OrderPositionManager(IOrderPositionDal orderPositionDal)
        {
            _orderPositionDal = orderPositionDal;
        }

        public IResult Add(OrderPosition order)
        {
            _orderPositionDal.Add(order);
            return new SuccessResult();

        }

        public IResult Delete(OrderPosition order)
        {
            _orderPositionDal.Delete(order);
            return new SuccessResult();
        }

        public IDataResult<List<OrderPosition>> GetAll()
        {
            return new SuccessDataResult<List<OrderPosition>>(_orderPositionDal.GetAll());
        }

        public IDataResult<List<OrderPosition>> GetAllByOrderId(int id)
        {
            return new SuccessDataResult<List<OrderPosition>>(_orderPositionDal.GetAll(p=> p.OrderId==id));
        }

        public IDataResult<OrderPosition> GetByID(int positionid)
        {
            return new SuccessDataResult<OrderPosition>(_orderPositionDal.Get(p => p.OderPositionId == positionid));
        }
    }
}
