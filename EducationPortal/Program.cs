using Data.Abstract;
using Domain;
using Sevices;
using System;

namespace EducationPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataRep = new UsersRepository();

            var sevicesRep = new UsersRepositorySevice(dataRep);

            var identityServices = new IdentityServices(sevicesRep);

            while (true)
            {
                Console.WriteLine("1.Registration");
                Console.WriteLine("2.Login");
                var ans = Console.ReadLine();

                if (ans == "1")
                {
                    Console.WriteLine("Name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Age:");
                    var age = Console.ReadLine();
                    Console.WriteLine("Password:");
                    var pass = Console.ReadLine();
                    Console.WriteLine("Email:");
                    var email = Console.ReadLine();

                    var token = identityServices.Registration(pass, email);

                    sevicesRep.AddOrUpdate(new User
                    {
                        Name = name,
                        Age = Convert.ToInt32(age),
                        Identity = token
                    });
                }
                else if (ans == "2")
                {
                    Console.WriteLine("Email:");
                    var email = Console.ReadLine();
                    Console.WriteLine("Password:");
                    var pass = Console.ReadLine();

                    var token = new IdentityToken { Password = pass, Email = email };

                    var user = identityServices.Login(token);
                    if (user != null)
                    {
                        Console.WriteLine("You:");
                        Console.WriteLine(user.Name);
                    }
                    else
                    {
                        Console.WriteLine("User is not found");
                    }
                    
                }
            }

            
        }
    }
}
