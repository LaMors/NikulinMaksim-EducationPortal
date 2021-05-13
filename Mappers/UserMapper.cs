using Data;
using Domain;
using Entities;
using Models;
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
                    Age = userEntity.Age,
                    Identity = userEntity.Identity.ToDomain(),

                };
            }
            return null;
        }

        public static User ToDomain(this UserModel userModel, IdentityToken identityToken)
        {
            if (userModel != null)
            {
                return new User
                {
                    Name = userModel.Name,
                    Age = userModel.Age,
                    Identity = identityToken,
                };
            }
            return null;
        }

        public static UserModel ToModel(this User user)
        {
            if (user != null)
            {
                return new UserModel
                {
                    Name = user.Name,
                    Age = user.Age,
                    Identity = user.Identity.ToModel(),
                };
            }
            return null;
        }
    }
}
