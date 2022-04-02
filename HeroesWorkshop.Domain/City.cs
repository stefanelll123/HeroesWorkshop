using System;

namespace HeroesWorkshop.Domain
{
    public sealed class City : BaseEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public Guid CountryId { get; set; }
        
        public Country Country { get; set; }
    }
}
