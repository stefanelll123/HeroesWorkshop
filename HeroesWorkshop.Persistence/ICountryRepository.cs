using System.Collections.Generic;
using HeroesWorkshop.Domain;

namespace HeroesWorkshop.Persistence
{
    public interface ICountryRepository
    {
        List<Country> Get();

        void Add(Country country);
    }
}