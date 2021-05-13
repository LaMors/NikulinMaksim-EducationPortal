using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices.Abstract
{
    public interface IUsersRepositoryService
    {
        void AddOrUpdate(User user);

        void DeleteById(Guid id);

        User GetById(Guid id);

        User GetUserByIdentity(IdentityToken identityToken);
    }
}
