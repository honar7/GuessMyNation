using GuessMyNation.Core.ApplicationServices.NationItems;
using GuessMyNation.Core.Domain.Nation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public List<NationItem> GetRandomly(int number)
        {
            return _nationItemApplicationService.GetRandomly(number);
        }

    }
}
