using Domain;
using Sevices.Abstract;
using System;

namespace Sevices
{
    public class IdentityService : IIdentityService
    {
        private IUsersRepositoryService usersRepository;

        public IdentityService(IUsersRepositoryService usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public User Login(IdentityToken identity)
        {
            return usersRepository.GetUserByIdentity(identity);
        }

        public IdentityToken Registration(string email, string password)
        {
            return new IdentityToken
            {
                Email = email,
                Password = password
            };
        }
    }
}
