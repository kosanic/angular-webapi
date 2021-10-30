using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Models;
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


        [HttpPost(Name ="KreirajStudenta")]
        public async Task<IActionResult> KreirajStudenta([FromBody]StudentDto input )
        {
            var studentId = await _query.KreirajStudentAsync(input);

            if(studentId > 0)
            {
                return StatusCode(202, studentId);
            }

            throw new Exception("Desila se greska, student nije kreiran");

        }

        [HttpDelete("{StudentId}",Name ="IzbrisiStudenta")]
        public async Task<IActionResult> IzbrisiStudenta([FromRoute]int StudentId)
        {
            var result = await _query.IzbrisiStudentaAsync(StudentId);

            return NoContent();
        }
        [HttpPut("{StudentId}", Name = "IzmeniStudenta")]
        public async Task<IActionResult> IzmeniStudenta([FromBody] StudentDto input)
        {
            var studentId = await _query.IzmeniStudentaAsync(input);
            if (studentId > 0)
            {
                return StatusCode(202, studentId);
            }

            throw new Exception("Desila se greska, student nije promenjen");

        }
    }
}
