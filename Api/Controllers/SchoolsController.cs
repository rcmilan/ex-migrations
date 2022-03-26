using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly IRepository<School, long> _repository;

        public SchoolsController(IRepository<School, long> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id:long}")]
        public IActionResult Get(long id)
        {
            var school = _repository.Get(s => s.Id == id);

            return Ok(school);
        }
    }
}
