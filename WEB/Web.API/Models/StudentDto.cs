using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Models
{
    public class StudentDto
    {
        public int StudentId { get; set; } 

        public string StudentIme { get; set; }

        public string StudentPrezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public string BrojIndeksa { get; set; }
        
    }
}


