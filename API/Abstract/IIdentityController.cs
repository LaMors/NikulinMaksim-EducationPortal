using Models;

namespace API
{
    public interface IIdentityController
    {
        UserModel Login(string email, string password);
        void Registration(UserModel userModel, IdentityTokenModel identity);
    }
}