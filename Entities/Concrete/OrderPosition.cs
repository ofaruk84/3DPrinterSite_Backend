using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class OrderPosition:IEntity
    {
        public int OrderPositionId{ get; set; }
        public int OrderId { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
    }
}
