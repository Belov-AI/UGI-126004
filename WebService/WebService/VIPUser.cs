using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public sealed class VIPUser : RegisteredUser
    {
        private long cardNumber { get; set; }

        public VIPUser(string login, string email, string password, long cardNumber) 
            : base(login, email, password) => this.cardNumber = cardNumber;

        public void ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword != password) return;

            password = newPassword;
        }
    }
}
