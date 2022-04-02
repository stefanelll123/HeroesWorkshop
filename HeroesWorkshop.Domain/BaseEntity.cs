using System;

namespace HeroesWorkshop.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
