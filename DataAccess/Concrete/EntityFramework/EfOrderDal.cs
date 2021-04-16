using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, _3dPrintContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails(int orderid)
        {
            using(_3dPrintContext context=new _3dPrintContext())
            {
                var result = from o in context.Orders
                    join opo in context.OrderPositions on o.OrderId equals opo.OrderId
                    join p in context.Products on opo.ProductId equals p.ProductId
                    join s in context.Sellers on p.SellerId equals s.SellerId
                    join u in context.Users on s.UserId equals u.UserId                    
                    where o.OrderId==orderid
                    select new OrderDetailDto
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        OrderId = o.OrderId,
                        OrderPrice = o.Price,
                        OrderPositionPrice = opo.Price,
                        OrderDate = o.OrderDate,
                        SellerName =u.Name
                    };
                return result.ToList();
            }
        }
    }
}
