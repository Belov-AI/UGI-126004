using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class Service : IEnumerable<User>
    {
        List<User> users;

        public Service() 
        { 
            users = new List<User>();
            Console.WriteLine("> Служба запущена");
        }

        ~Service() => Console.WriteLine("Служба остановлена"); 

        public void AddUser(User user)
        {
            if(!users.Contains(user)) 
                users.Add(user);

            Console.WriteLine($"> Присоединился пользователь {user.Login}");

        }

        public IEnumerator<User> GetEnumerator()
        {
            return ((IEnumerable<User>)users).GetEnumerator();
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
            Console.WriteLine($"> Отсоединился пользователь {user.Login}");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)users).GetEnumerator();
        }
    }
}
