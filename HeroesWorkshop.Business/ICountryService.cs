using System.Collections.Generic;
using HeroesWorkshop.Domain;

namespace HeroesWorkshop.Business
{
    public interface ICountryService
    {
        List<Country> Get();
        
        void Add(Country country);
    }
}