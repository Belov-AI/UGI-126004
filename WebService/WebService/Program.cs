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
            Console.WriteLine(james.ToString());

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

            Console.WriteLine();

            foreach (var user in users)
                Console.WriteLine(user.GetInfo());

            Console.WriteLine();

            User kate2 = (User)kate;
            Console.WriteLine(kate2.GetInfo());

            //RegisteredUser kate3 = (RegisteredUser)kate2;
            //Console.WriteLine(kate3.Email);
            if (kate2 is RegisteredUser kate3)
                Console.WriteLine(kate3.Email);
            else
                Console.WriteLine(kate2.Login + " не зарегистрированный пользователь");

            //Admin admin2 = (Admin)kate2;
            if (kate2 is Admin admin2)
                Console.WriteLine(admin2.AccessLevel);
            else
                Console.WriteLine(kate2.Login + " не админ");

            var webservice = new Service();

            foreach( var user in users)
                webservice.AddUser(user);

            webservice.RemoveUser(john);

            foreach(var user in webservice)
                Console.WriteLine(user.GetInfo());

            Console.ReadKey();
        }
    }
}
