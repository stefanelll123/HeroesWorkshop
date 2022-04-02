using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using HeroesWorkshop.Domain;

namespace HeroesWorkshop.Persistence
{
    public sealed class CityRepository : ICityRepository
    {
        private readonly SqlConnection _connection;

        public CityRepository(SqlConnection connection)
        {
            _connection = connection;
        }
        
        public List<City> Get()
        {
            const string Sql = @"SELECT * FROM CITY c1
JOIN COUNTRY c2 ON c1.countryId = c2.id;";
            var cities = _connection.Query<City, Country, City>(Sql, (city, country) =>
            {
                city.Country = country;
                return city;
            });

            return cities.ToList();
        }
    }
}