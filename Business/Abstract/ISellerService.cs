using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISellerService
    {
        IDataResult<List<Seller>> GetAll();
        IResult Add(Seller seller);
        IResult Update(Seller seller);
        IResult Delete(Seller seller);
        IDataResult<List<SellerDetailDto>> GetSellerDetails();

    }
}
