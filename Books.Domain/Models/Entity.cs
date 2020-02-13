using System;

namespace Books.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
