using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SellerManager : ISellerService
    {

        ISellerDal _sellerDal;

        public SellerManager(ISellerDal sellerDal)
        {
            _sellerDal = sellerDal;
        }

        public IResult Add(Seller seller)
        {
            _sellerDal.Add(seller);
            return new SuccessResult(Messages.SellerAdded);
        }

        public IResult Delete(Seller seller)
        {
            _sellerDal.Delete(seller);
            return new SuccessResult(Messages.SellerDeleted);
        }

        public IDataResult<List<Seller>> GetAll()
        {
            return new SuccessDataResult<List<Seller>>(Messages.SellersListed);
        }


        public IResult Update(Seller seller)
        {
            _sellerDal.Update(seller);
            return new SuccessResult(Messages.SellerUpdated);
        }
    }
}
