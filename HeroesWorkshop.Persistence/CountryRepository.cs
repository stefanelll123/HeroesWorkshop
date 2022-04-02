using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using HeroesWorkshop.Domain;

namespace HeroesWorkshop.Persistence
{
    public sealed class CountryRepository : ICountryRepository
    {
        private readonly SqlConnection _connection;
        
        public CountryRepository(SqlConnection connection)
        {
            _connection = connection;
        }
        
        public List<Country> Get()
        {
            const string sql = "SELECT * FROM COUNTRY";
            var countries = _connection.Query<Country>(sql);

            return countries.ToList();
        }

        public void Add(Country country)
        {
            const string sql = "INSERT INTO country(id, name, nameEng, code) VALUES (@Id, @Name, @NameEng, @Code)";
            var parameters = new {
                Id = country.Id, 
                Name = country.Name, 
                NameEng = country.NameEng, 
                Code = country.Code
            };

            _connection.Execute(sql, parameters);
        }
    }
}