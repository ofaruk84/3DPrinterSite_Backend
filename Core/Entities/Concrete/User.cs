using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        //pushlama
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
    }
}
