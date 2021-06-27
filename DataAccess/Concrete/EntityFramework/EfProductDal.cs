using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, _3dPrintContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<Product, bool>> filter = null)
        {
            using (_3dPrintContext context = new _3dPrintContext())
            {
                var result = from p in filter == null ? context.Products : context.Products.Where(filter)
                             join c in context.Categories
                             on  p.CategoryId equals c.CategoryID
                             join s in context.Sellers
                             on p.SellerId equals s.SellerId
                             
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 Quantity = p.Quantity,
                                 Price = p.Price,
                                 Description = p.Description,
                                 Name = p.Name,
                                 CategoryName = c.CategoryName,
                                 CompanyName = s.CompanyName,

                                 Images =
                              (from i in context.ProductImages where i.ProductId == p.ProductId select i.ImagePath).ToList()
                            
            };
                return result.ToList();
            }
        }
    }
}
