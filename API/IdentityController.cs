using Domain;
using Mappers;
using Models;
using Sevices.Abstract;
using System;

namespace API
{
    public class IdentityController : IIdentityController
    {
        private IUsersRepositoryService usersRepository;

        private IIdentityService identityService;
        public IdentityController(IIdentityService identityService, IUsersRepositoryService usersRepository)
        {
            this.identityService = identityService;

            this.usersRepository = usersRepository;
        }

        public void Registration(UserModel userModel, IdentityTokenModel identity)
        {
            usersRepository.AddOrUpdate(userModel.ToDomain(identity.ToDomain()));
        }

        public UserModel Login(string email, string password)
        {
            var token = new IdentityToken { Email = email, Password = password };

            return identityService.Login(token).ToModel();
        }
    }
}
