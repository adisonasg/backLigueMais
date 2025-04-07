using System.IO;
using Microsoft.AspNetCore.Mvc;
using FaleMais.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using FaleMais.Data;
using Microsoft.EntityFrameworkCore;

namespace FaleMais.Controllers
{
    [Route("ddd")]
    [ApiController]
    public class DDDController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<DDD>>> Get([FromServices] DataContext context)
        {
            var DDDs = await context.DDD.ToListAsync();
            return DDDs;
        }

    }
}
