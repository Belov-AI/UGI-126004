using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var james = new User("James007");

            //Console.WriteLine(james.GetInfo());

            var john = new RegisteredUser("John", "john@mail.ru", "12345");
            //Console.WriteLine(john.GetInfo());
            //Console.WriteLine($"{john.Email}");

            var kate = new VIPUser("Kate", "kate@gmail.com", "qwerty", 987654321000);
            //Console.WriteLine(kate.GetInfo());
            //Console.WriteLine($"{kate.Email}");

            var admin = new Admin("Paul", "admin@webservice.ru", "nvo[javb7t593", 2);
            //Console.WriteLine(admin.GetInfo());
            //Console.WriteLine($"Почта {admin.Email}. Уровень доступа {admin.AccessLevel}");

            var users = new User[] { james, john, kate, admin };

            foreach (var user in users)
                Console.WriteLine(user.GetInfo());

            Console.WriteLine();

            User kate2 = (User)kate;
            Console.WriteLine(kate2.GetInfo());
            RegisteredUser kate3 = (RegisteredUser)kate2;
            Console.WriteLine(kate3.Email);

            Console.ReadKey();
        }
    }
}
