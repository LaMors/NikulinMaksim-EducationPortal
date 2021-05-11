
namespace Entities
{
    public class IdentityTokenEntity
    {
        public string Password { get; set; }

        public string Email { get; set; }

        public bool Equals(IdentityTokenEntity identityToken)
        {
            if (this.Password == identityToken.Password && this.Email == identityToken.Email)
            {
                return true;
            }

            return false;
        }
    }
}