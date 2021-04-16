using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Core.Entities;

namespace Entities.DTOs
{
    public class OrderDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int OrderId { get; set; }
        public int OrderPrice { get; set; }
        public int OrderPositionPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string SellerName { get; set; }
        
    }
}
