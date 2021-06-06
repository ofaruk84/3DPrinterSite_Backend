using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<List<Basket>> GetAll();
        IDataResult<List<Basket>> GetAllByUserId(int userId);
        IResult Add(Basket basket);
        IResult Delete(Basket basket);
        IResult Update(Basket basket);
    }
}
