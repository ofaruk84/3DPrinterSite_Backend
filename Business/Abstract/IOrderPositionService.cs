using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderPositionService
    {
        IDataResult<List<OrderPosition>> GetAll();
        IDataResult<List<OrderPosition>> GetAllByOrderId(int id);
        IDataResult<OrderPosition> GetByID(int positionid);
        IResult Add(OrderPosition order);
        IResult Delete(OrderPosition order);
    }
}
