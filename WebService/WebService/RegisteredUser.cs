using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class RegisteredUser : User
    {
        public string Email { get; set; }
        protected string password { get; set; }

        public RegisteredUser(string login, string email, string password) : base(login) 
        { 
            Email = email;
            this.password = password;
        }

        public override string GetInfo() => $"{base.GetInfo()}. Email: {Email}";
    }
}
