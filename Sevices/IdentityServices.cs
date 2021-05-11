using Domain;
using Sevices.Abstract;
using System;

namespace Sevices
{
    public class IdentityServices : IIdentityServices
    {
        private IUsersRepositorySevice usersRepository;

        public IdentityServices(IUsersRepositorySevice usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public User Login(IdentityToken identity)
        {
            return usersRepository.GetUserByIdentity(identity);
        }

        public IdentityToken Registration(string password, string email)
        {
            return new IdentityToken
            {
                Password = password,
                Email = email
            };
        }
    }
}
