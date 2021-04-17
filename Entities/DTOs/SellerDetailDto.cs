using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SellerDetailDto:IDto
    {
        public int SellerId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

    }
}
