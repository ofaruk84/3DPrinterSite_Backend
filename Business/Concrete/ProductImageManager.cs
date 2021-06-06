using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }


        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<ProductImage> GetById(int id)
        {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(p => p.Id == id));
        }

        public IDataResult<List<ProductImage>> GetByProductId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfProductImageNull(id));

            if (result != null)
            {
                return new ErrorDataResult<List<ProductImage>>(result.Message);
            }

            return new SuccessDataResult<List<ProductImage>>(CheckIfProductImageNull(id).Data);
        }

        public IResult Add(ProductImage productImage, IFormFile file)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimitExceeded(productImage.ProductId));

            if (result != null)
            {
                return result;
            }

            var imageResult = FileHelper.Upload(file);

            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }

            productImage.ImagePath = imageResult.Message;
            productImage.Date = DateTime.Now;

            _productImageDal.Add(productImage);

            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Update(ProductImage productImage, IFormFile file)
        {
            var isImage = _productImageDal.Get(p => p.Id == productImage.Id);
            if (isImage == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }

            var updatedFile = FileHelper.Update(file, isImage.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            productImage.ImagePath = updatedFile.Message;
            _productImageDal.Update(productImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        public IResult Delete(ProductImage productImage)
        {
            var image = _productImageDal.Get(p => p.Id == productImage.Id);
            if (image == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }

            FileHelper.Delete(image.ImagePath);
            _productImageDal.Delete(productImage);
            return new SuccessResult(Messages.ImageDeleted);
        }


        private IResult CheckIfImageLimitExceeded(int id)
        {
            var count = _productImageDal.GetAll(p => p.ProductId== id).Count;

            if (count >= 5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }

            return new SuccessResult();
        }


        private IDataResult<List<ProductImage>> CheckIfProductImageNull(int id)
        {
            try
            {
                string path = @"\images\logo.jpg";
                var result = _productImageDal.GetAll(p => p.ProductId == id).Any();
                if (!result)
                {
                    List<ProductImage> productImages = new List<ProductImage>();
                    productImages.Add(new ProductImage() { ProductId = id , ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<ProductImage>>(productImages);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<ProductImage>>(exception.Message);
            }

            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll(p => p.ProductId == id).ToList());
        }
    }
}
