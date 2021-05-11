using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public static class IdentityTokenMapper
    {
        public static IdentityTokenEntity ToEntity(this IdentityToken identity)
        {
            return new IdentityTokenEntity
            {
                Password = identity.Password,
                Email = identity.Email
            };
        }

        public static IdentityToken ToDomain(this IdentityTokenEntity identity)
        {
            return new IdentityToken
            {
                Password = identity.Password,
                Email = identity.Email
            };
        }
    }
}
