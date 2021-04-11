using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSellerDal : ISellerDal
    {
        public void Add(Seller entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Seller entity)
        {
            throw new NotImplementedException();
        }

        public Seller Get(Expression<Func<Seller, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Seller> GetAll(Expression<Func<Seller, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Seller entity)
        {
            throw new NotImplementedException();
        }
    }
}
