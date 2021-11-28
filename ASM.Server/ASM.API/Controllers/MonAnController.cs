using ASM.Share.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonAnController : ControllerBase
    {
        private readonly IMonAnSvc _monanSvc;

        public MonAnController(IMonAnSvc monanSvc)
        {
            _monanSvc = monanSvc;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonAn>>> GetMonAns()
        {
            return await _monanSvc.GetMonAnAllAsync();
        }
    }
}
