using GuessMyNation.Core.ApplicationServices.NationItems;
using GuessMyNation.Core.Domain.Nation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuessMyNation.Endpoints.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NationItemController: ControllerBase
    {
        private readonly NationItemApplicationService _nationItemApplicationService;

        public NationItemController(NationItemApplicationService nationItemApplicationService)
        {
            _nationItemApplicationService = nationItemApplicationService;
        }        

        //[HttpGet("number")]
        //[Route("GetRandomly")]
        //public List<NationItem> GetRandomly(int number)
        //{
        //    return _nationItemApplicationService.GetRandomly(number);
        //}

        [HttpGet]
        [Route("GetFixFiveRandomly")]
        public List<NationItem> GetFixFiveRandomly()
        {
            return _nationItemApplicationService.GetFixFiveRandomly();
        }

    }
}
