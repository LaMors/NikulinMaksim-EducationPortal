using Data;
using Domain;
using Entities;
using Mappers;
using Sevices.Abstract;
using System;

namespace Sevices
{
    public class UsersRepositoryService : IUsersRepositoryService
    {
        private IUsersRepository repository;

        public UsersRepositoryService(IUsersRepository repository)
        {
            this.repository = repository;
        }
        public void AddOrUpdate(User user)
        {
            repository.AddOrUpdate(user.ToEntity());
        }

        public void DeleteById(Guid id)
        {
            repository.DeleteById(id);
        }

        public User GetById(Guid id)
        {
            return repository.GetById(id).ToDomain();
        }

        public User GetUserByIdentity(IdentityToken identityToken)
        {
            return repository.GetUserByIdentity(identityToken.ToEntity()).ToDomain();
        }
    }
}
