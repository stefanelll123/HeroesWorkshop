using System.Collections.Generic;
using HeroesWorkshop.Domain;
using HeroesWorkshop.Persistence;

namespace HeroesWorkshop.Business
{
    public sealed class CityService : ICityService
    {
        private readonly ICityRepository _repository;

        public CityService(ICityRepository repository)
        {
            _repository = repository;
        }
        
        public List<City> Get()
        {
            return _repository.Get();
        }
    }
}