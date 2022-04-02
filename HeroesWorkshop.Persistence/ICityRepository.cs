using System.Collections.Generic;
using HeroesWorkshop.Domain;

namespace HeroesWorkshop.Persistence
{
    public interface ICityRepository
    {
        List<City> Get();
    }
}