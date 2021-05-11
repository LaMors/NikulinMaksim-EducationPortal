using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserEntity : BaseEntity
    {
        public int Age { get; set; }

        public IdentityTokenEntity Identity {get; set;}

        public IQueryable<Guid> CompCompletedMaterialId { get; set; }


    }
}
