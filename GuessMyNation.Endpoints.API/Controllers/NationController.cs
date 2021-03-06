using GuessMyNation.Core.ApplicationServices.Nations;
using GuessMyNation.Core.Domain.Nation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuessMyNation.Endpoints.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NationController : ControllerBase
    {
        private readonly NationApplicationService _nationApplicationService;

        public NationController(NationApplicationService blogApplicaitonService)
        {
            _nationApplicationService = blogApplicaitonService;
        }

        [HttpGet]
        [Route("GetButtons")]
        public IEnumerable<Nation> Get()
        {
            return _nationApplicationService.Get();
        }
        [HttpGet("{id}")]
        public Nation Get(int id)
        {
            return _nationApplicationService.Get(id);
        }

        [HttpPost]
        public IActionResult Add(Nation nation)
        {
            _nationApplicationService.Add(nation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _nationApplicationService.Remove(id);
            return NoContent();
        }
    }
}
