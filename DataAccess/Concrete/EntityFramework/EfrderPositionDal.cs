using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfrderPositionDal : IOrderPositionDal
    {
        public void Add(OrderPosition entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderPosition entity)
        {
            throw new NotImplementedException();
        }

        public OrderPosition Get(Expression<Func<OrderPosition, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<OrderPosition> GetAll(Expression<Func<OrderPosition, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderPosition entity)
        {
            throw new NotImplementedException();
        }
    }
}
