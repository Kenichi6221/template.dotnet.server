using System.Collections.Generic;
using System.Threading.Tasks;
using Bambu.Core.Business;
using Bambu.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bambu.Api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class SalesPersonController : ControllerBase
    {
        ISalesPersonService _salesPersonService;

        public SalesPersonController(ISalesPersonService salesPersonServiceService)
        {
            _salesPersonService = salesPersonServiceService;
        }

        [HttpGet(Name = nameof(GetAllSalesPerson))]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<Salesperson>>> GetAllSalesPerson()
        {
            var salesPeople = await _salesPersonService.GetAllSalesPerson();
            return salesPeople;
        }
    }
}