using API;
using ConsoleView;
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
            var UsersRepositorySevice = new UsersRepositoryService(new UsersRepository());
            var identityService = new IdentityService(UsersRepositorySevice);
            var identityController = new IdentityController(identityService, UsersRepositorySevice);
            new UserPanel(identityController).ViewUserPanel();

        }
    }
}
