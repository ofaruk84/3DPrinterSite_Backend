using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IDataResult<List<ProductImage>> GetAll();
        IDataResult<ProductImage> GetById(int id);
        IDataResult<List<ProductImage>> GetByProductId(int id);
        IResult Add(ProductImage productImage, IFormFile file);
        IResult Update(ProductImage productImage, IFormFile file);
        IResult Delete(ProductImage productImage);
    }
}
