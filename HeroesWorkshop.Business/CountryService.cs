using System.Collections.Generic;
using HeroesWorkshop.Domain;
using HeroesWorkshop.Persistence;

namespace HeroesWorkshop.Business
{
    public sealed class CountryService : ICountryService
    {
        private readonly ICountryRepository _repository;

        public CountryService(ICountryRepository repository)
        {
            _repository = repository;
        }
        
        public List<Country> Get()
        {
            return _repository.Get();
        }

        public void Add(Country country)
        {
            _repository.Add(country);
        }
    }
}