using Entities;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public class UsersRepository : IUserRepository
    {
        public UsersRepository()
        {
            UserStorage.Read();
        }
        public void AddOrUpdate(UserEntity userEntity)
        {
            if (UserStorage.userEntities.Contains(userEntity))
            {
                var index = UserStorage.userEntities.IndexOf(userEntity);
                UserStorage.userEntities[index] = userEntity;
            }
            else
            {
                UserStorage.userEntities.Add(userEntity);
            }
        }

        public void DeleteById(Guid id)
        {
            UserStorage.userEntities.Remove(GetById(id));
        }

        public UserEntity GetById(Guid id)
        {
            return UserStorage.userEntities.Where(user => user.Id == id).FirstOrDefault();
        }


        public UserEntity GetUserByIdentity(IdentityTokenEntity identityToken)
        {
            return UserStorage.userEntities.Where(user => user.Identity.Equals(identityToken)).FirstOrDefault();
        }

        ~UsersRepository()
        {
            UserStorage.Save();
        }
    }
}
