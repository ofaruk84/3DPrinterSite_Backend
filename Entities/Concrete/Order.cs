using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {

        public int OrderId { get; set; }
        public int  UserId { get; set; }
        public int SellerId{ get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Price { get; set; }
    }
}
