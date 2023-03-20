using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class User
    {
        public string Login { get; set; }

        public User(string login) => Login = login;

        public virtual string GetInfo() => $"Пользователь {Login}";

        public override string ToString() => Login;
    }
}
