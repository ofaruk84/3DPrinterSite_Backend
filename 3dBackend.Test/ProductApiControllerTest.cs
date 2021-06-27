using Business.Abstract;
using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Controllers;
using Xunit;
using System.Linq;

namespace _3dBackend.Test
{
    public class ProductApiControllerTest
    {
        private readonly Mock<IProductService> _mockRepo;
        private readonly ProductsController _controller;

        private List<Product> _products;

        public ProductApiControllerTest()
        {
            _mockRepo = new Mock<IProductService>();
            _controller = new ProductsController(_mockRepo.Object);

            _products = new List<Product>() { new Product { ProductId = 1, CategoryId = 1, Description = "yorum yok", Name = "Kalem", Price = 1500, Quantity = 5, SellerId = 1 } };
        }

        

        [Fact]
        public void GetAll_ActionExecutes_ReturnOkResultWithProduct()
        {
            _mockRepo.Setup(x => x.GetAll()).Returns(new SuccessDataResult<List<Product>>(_products));

            var result = _controller.GetAll();

            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnProducts = Assert.IsType<SuccessDataResult<List<Product>>>(okResult.Value);

            Assert.Equal<int>(1, returnProducts.Data.ToList().Count);
        }
    }
}
