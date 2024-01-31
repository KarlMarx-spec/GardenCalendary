using Domain.Entities;
using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RPrecipitationsController : ControllerBase
    {
        private readonly IGenericRepository<RPrecipitation, RPrecipitationModel> _repository;

        public RPrecipitationsController(IGenericRepository<RPrecipitation, RPrecipitationModel> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IList<RPrecipitationModel>>> GetAll()
        {
            return Ok(await _repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RPrecipitationModel>> GetById(int id)
        {
            return Ok(await _repository.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] RPrecipitationModel RPrecipitation)
        {
            await _repository.AddAsync(RPrecipitation);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Change(int id, [FromBody] RPrecipitationModel RPrecipitation)
        {
            await _repository.UpdateAsync(id, RPrecipitation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
