using System;

namespace Models
{
    public class UserModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IdentityTokenModel Identity { get; set; }
    }
}
