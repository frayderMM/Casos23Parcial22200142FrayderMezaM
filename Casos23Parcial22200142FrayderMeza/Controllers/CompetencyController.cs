using Casos23Parcial22200142FrayderMeza.Core.Entities;
using Casos23Parcial22200142FrayderMeza.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casos23Parcial22200142FrayderMeza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly ICompetencyRepository _competencyRepository;

        public CompetencyController(ICompetencyRepository competencyRepository)
        {
            _competencyRepository = competencyRepository;
        }

        //http create
        [HttpPost]
        public async Task<IActionResult> CreateCompetency([FromBody] Competency competency)
        {   
            int id = await _competencyRepository.CreateCompetency(competency);
            return Ok(id);
        }

        //http úpdate
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompetency(int id, [FromBody] Competency competency)
        {
            if (id != competency.Id) return BadRequest();
            var result = await _competencyRepository.UpdateCompetency(competency);
            if (!result) return NotFound();
            return Ok(result);
        }

        //http delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetency(int id)
        {
            var result = await _competencyRepository.DeleteCompetency(id);
            if (id == 0) return NotFound();
            return Ok(result);
        }

        //GET
        [HttpGet]
        public async Task<IActionResult> GetCompetencies()
        {
            var competencies = await _competencyRepository.GetCompetencies();
            return Ok(competencies);
        }
    }
}
