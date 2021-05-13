using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Id { get; protected set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; }

    }
}
