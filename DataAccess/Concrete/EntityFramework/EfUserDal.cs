using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
<<<<<<< HEAD
=======
using Core.Entities.Concrete;
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
<<<<<<< HEAD
    public class EfUserDal : EfEntityRepositoryBase<User, _3dPrintContext>, IUserDal
    {
        
=======
    public class EfUserDal : EfEntityRepositoryBase<User,_3dPrintContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new _3dPrintContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
>>>>>>> 7d9f7ea068a475b3012ae3992a2b42333b93d63f
    }
}
