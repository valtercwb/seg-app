using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Segfy.Domain.Entities;
using Segfy.Services.Interfaces;

namespace Segfy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApoliceAutomovelController : ControllerBase
    {
        private readonly IApoliceAutomovelService _apoliceAutomovelService;

        public ApoliceAutomovelController(IApoliceAutomovelService apoliceAutomovelService)
        {
            _apoliceAutomovelService = apoliceAutomovelService;
        }

        [Route("apolice/automovel")]
        [HttpGet]
        public async Task<ActionResult<ApoliceAutomovel>> GetApoliceAutomovel()
        {
            var apolicesAutomovel =  await _apoliceAutomovelService.Get();
            return Ok(apolicesAutomovel);
        }

        [Route("apolice/automovel")]
        [HttpGet("{id}")]
        public async Task<ActionResult<ApoliceAutomovel>> GetApoliceAutomovel(int id)
        {
            var apoliceAutomovel = await _apoliceAutomovelService.Get(id);

            if (apoliceAutomovel == null)
            {
                return NotFound();
            }

            return apoliceAutomovel;
        }

        [Route("apolice/automovel")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApoliceAutomovel(int id, ApoliceAutomovel apoliceAutomovel)
        {
            if (id != apoliceAutomovel.Id)
            {
                return BadRequest();
            }

            try
            {
                await _apoliceAutomovelService.Update(apoliceAutomovel);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [Route("apolice/automovel")]
        [HttpPost]
        public async Task<ActionResult<ApoliceAutomovel>> PostApoliceAutomovel(ApoliceAutomovel apoliceAutomovel)
        {
            await _apoliceAutomovelService.Add(apoliceAutomovel);
            return CreatedAtAction("GetApoliceAutomovel", new { id = apoliceAutomovel.Id }, apoliceAutomovel);
        }

        [Route("apolice/automovel")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApoliceAutomovel>> DeleteApoliceAutomovel(int id)
        {
            await _apoliceAutomovelService.Delete(id);
            return Ok(id);
        }
    }
}
