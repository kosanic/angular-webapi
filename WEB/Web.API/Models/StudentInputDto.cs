using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Models
{
    public class StudentInputDto
    {
        public int? StudentiId { get; set; }

        public string StudentIme { get; set; }

        public string StudentPrezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public string BrojIndeksa { get; set; }
    }
}
