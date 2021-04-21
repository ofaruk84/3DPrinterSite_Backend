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
    public class EfSellerDal : EfEntityRepositoryBase<Seller, _3dPrintContext>, ISellerDal
    {
<<<<<<< HEAD
       
=======
        public List<SellerDetailDto> GetSellerDetails()
        {
            using (_3dPrintContext context = new _3dPrintContext())
            {
                var result = from s in context.Sellers
                             join u in context.Users
                             on s.UserId equals u.UserId
                             select new SellerDetailDto
                             {
                                 SellerId = s.SellerId,
                                 CompanyName = s.CompanyName,
                                 CompanyPhone = s.CompanyPhone,
                                 Email = u.Email,
                                 Name = u.Name,
                                 Surname = u.Surname,
                                 Phone = u.Phone
                             };
                return result.ToList();
            }
        }
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
    }
}
