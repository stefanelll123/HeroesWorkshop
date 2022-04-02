using System;

namespace HeroesWorkshop
{
    public abstract class Base
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
