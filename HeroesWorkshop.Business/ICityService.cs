using System.Collections.Generic;
using HeroesWorkshop.Domain;

namespace HeroesWorkshop.Business
{
    public interface ICityService
    {
        List<City> Get();
    }
}