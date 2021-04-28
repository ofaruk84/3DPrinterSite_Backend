using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetAllByCategoryId(int id);
        IDataResult<Category> GetByID(int categoryId);
        IResult Add(Category category);
        IResult Delete(Category category);
       
    }
}
