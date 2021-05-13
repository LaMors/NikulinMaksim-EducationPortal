using API;
using Models;
using System;

namespace ConsoleView
{
    public class UserPanel
    {
        private IIdentityController identityController;

        public UserPanel(IIdentityController identityController)
        {
           this.identityController = identityController;
        }  

        public void ViewUserPanel()
        {
            while (true)
            {
                Console.WriteLine("1.Registration");
                Console.WriteLine("2.Login");
                var ans = Console.ReadLine();

                if (ans == "1" || ans.ToLower() == "registration")
                {
                    Console.WriteLine("Name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Age:");
                    var age = Console.ReadLine();
                    Console.WriteLine("Email:");
                    var email = Console.ReadLine();
                    Console.WriteLine("Password:");
                    var pass = Console.ReadLine();
                    

                }
                else if (ans == "2" || ans.ToLower() == "login")
                {
                    Console.WriteLine("Email:");
                    var email = Console.ReadLine();
                    Console.WriteLine("Password:");
                    var pass = Console.ReadLine();

                    var user = identityController.Login(email, pass);
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

                else
                {
                    Console.WriteLine("Select a command");
                }
            }
        }
    }
}
