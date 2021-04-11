using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.Concrete
{
    public class Seller:IEntity
    {
        public int SellerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAdress { get; set; }
        public string  CompanyPhone { get; set; }

    }
}
