using HeroesWorkshop.Business;
using HeroesWorkshop.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HeroesWorkshopApi.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _service;

        public CityController(ICityService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(City), 200)]
        public IActionResult Get()
        {
            var result = _service.Get();

            return Ok(result);
        }
    }
}