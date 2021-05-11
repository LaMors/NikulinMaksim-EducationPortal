using System;

namespace Entities
{
    public interface IBaseEntity
    {
        Guid Id { get; }

        string Name { get; set; }

        DateTime CreationDate { get; }

    }
}
