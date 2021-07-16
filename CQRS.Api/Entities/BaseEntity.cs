using System;

namespace CQRS.Api.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
    }
}
