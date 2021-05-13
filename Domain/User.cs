using System;

namespace Domain
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IdentityToken Identity { get; set; }

    }
}
