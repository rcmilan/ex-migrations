using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IRepository<City, Guid> _repository;

        public CitiesController(IRepository<City, Guid> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] City city)
        {
            var result = await _repository.Add(city);

            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cities = _repository.GetAll();

            return Ok(cities);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> AddAccommodation(Guid id, Accommodation accommodation)
        {
            var city = await _repository.Get(id);

            city.AddAccommodation(accommodation);

            await _repository.Update(city);

            return Ok(city);
        }
    }
}
