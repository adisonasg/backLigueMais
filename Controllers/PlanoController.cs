using FaleMais.Data;
using FaleMais.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FaleMais.Controllers
{
    [Route("plano")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Plano>>> Get([FromServices] DataContext context)
        {
            var planos = await context.Plano.ToListAsync();
            return planos;
        } 
    }
}
