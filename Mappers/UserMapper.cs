using Data;
using Domain;
using Entities;
using System;

namespace Mappers
{
    public static class UserMapper
    {

        public static UserEntity ToEntity(this User user)
        {
            return new UserEntity 
            {
                Identity = user.Identity.ToEntity(),
                Name =user.Name,
                Age = user.Age
            };
        }

        public static User ToDomain(this UserEntity userEntity)
        {
            if (userEntity != null)
            {
                return new User
                {
                    Name = userEntity.Name,
                    Identity = userEntity.Identity.ToDomain(),

                };
            }
            return null;
        }
    }
}
