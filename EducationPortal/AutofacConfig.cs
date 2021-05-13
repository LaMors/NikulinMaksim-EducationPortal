using API;
using Autofac;
using Autofac.Integration.Mvc;
using Data;
using Data.Abstract;
using Entities;
using Sevices;
using Sevices.Abstract;
using System.Reflection;

namespace EducationPortal
{
    public class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();
            //builder.RegisterType<IdentityController>().As<IIdentityController>();
            //builder.RegisterType<UsersRepository>().As<IUsersRepository>();
            //builder.RegisterType<UsersRepositorySevice>().As<IUsersRepositorySevice>();
            //builder.RegisterType<IdentityService>().As<IIdentityService>();
            //builder.RegisterType<BaseEntity>().As<IBaseEntity>();

            return builder.Build();
        }
    }
}
