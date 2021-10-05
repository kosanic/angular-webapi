using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentiController : ControllerBase
    {
        private readonly IStudentiService _query;

        public StudentiController(IStudentiService query)
        {
            _query = query;
        }

        [HttpGet(Name ="DohvatiSveStudente")]
        public async Task<IActionResult> DohvatiSveStudente()
        {

            //throw new Exception("greska na serveru");

            var studenti = await _query.DohvatiSveStudenteAsync();

            // return StatusCode(200, studenti);

            return Ok(studenti);
        }
    }
}
