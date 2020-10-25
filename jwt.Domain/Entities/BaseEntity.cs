using System;

namespace jwt.Domain.Entities
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime? Updated { get; set; }
        public virtual DateTime? Created { get; set; }
    }
}
