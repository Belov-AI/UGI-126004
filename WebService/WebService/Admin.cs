using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class Admin : RegisteredUser
    {
        public int AccessLevel { get; private set; }

        public Admin(string login, string email, string password, int level) 
            : base(login, email, password) => AccessLevel = level;
    }
}
