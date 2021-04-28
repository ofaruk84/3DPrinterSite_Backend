using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IProductService
    {

        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByProductId(int id);
        IDataResult<Product> GetByID(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
    }
}
