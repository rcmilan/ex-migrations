using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccommodationsController : ControllerBase
    {
        private readonly IRepository<Accommodation, long> _repository;

        public AccommodationsController(IRepository<Accommodation, long> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Accommodation accommodation)
        {
            var result = await _repository.Add(accommodation);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get(long id)
        {
            var result = await _repository.Get(id);

            return Ok(result);
        }
    }
}
