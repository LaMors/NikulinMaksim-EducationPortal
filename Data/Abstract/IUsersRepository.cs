
using Entities;
using System;

namespace Data
{
    public interface IUsersRepository
    {
        void AddOrUpdate(UserEntity userEntity);

        void DeleteById(Guid id);

        UserEntity GetById(Guid id);

        UserEntity GetUserByIdentity(IdentityTokenEntity identityToken);
    }
}
