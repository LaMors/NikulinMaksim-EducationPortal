using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CourseEntity:BaseEntity
    {
        public Guid AuthorId { get; }

        public string Description { get; set; }

        public IQueryable<Guid> MaterialsId { get; set; }

        public CourseEntity(Guid id)
        {
            Id = id;
        }
    }
}
