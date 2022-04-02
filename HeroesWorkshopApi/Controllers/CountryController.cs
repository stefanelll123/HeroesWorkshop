using FluentValidation;
using FluentValidation.Results;
using HeroesWorkshop.Business;
using HeroesWorkshop.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HeroesWorkshopApi.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _service;
        private readonly IValidator<Country> _validator;

        public CountryController(ICountryService service, IValidator<Country> validator)
        {
            _service = service;
            _validator = validator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Country), 200)]
        public IActionResult Get()
        {
            var countries = _service.Get();
            
            return Ok(countries);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(ValidationResult), 400)]
        public IActionResult Create([FromBody] Country country)
        {
            var validationResult = _validator.Validate(country);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
            
            _service.Add(country);

            return Ok();
        }
    }
}
