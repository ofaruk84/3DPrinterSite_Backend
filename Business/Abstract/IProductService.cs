using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {

        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetAllByProductId(int id);
        IDataResult<List<Product>> GetByCategoryId(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }

}
