using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices.Abstract
{
    public interface IIdentityService
    {
        IdentityToken Registration(string password, string email);

        User Login(IdentityToken identity); 

    }
}
