using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Models;

namespace Web.API.Services
{
    public class StudentiService : IStudentiService
    {
        public async Task<List<StudentDto>> DohvatiSveStudenteAsync()
        {
            await Task.Delay(1000); // await radi prikaza asinhrone metode

            var listaStudenata = new List<StudentDto>();

            listaStudenata.Add(new StudentDto { Ime = "Nenad", Prezime = "Kosanic", BrojIndeksa = "99/17", DatumRodjenja = DateTime.Now });
            listaStudenata.Add(new StudentDto { Ime = "Petar", Prezime = "Petrovic", BrojIndeksa = "99/17", DatumRodjenja = DateTime.Now });
            listaStudenata.Add(new StudentDto { Ime = "Vuk", Prezime = "Vucko", BrojIndeksa = "99/17", DatumRodjenja = DateTime.Now });
            listaStudenata.Add(new StudentDto { Ime = "Jeremija", Prezime = "Krstic", BrojIndeksa = "99/17", DatumRodjenja = DateTime.Now });

            return listaStudenata;
        }
    }
}
