 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Models;

namespace Web.API.Services
{
    public interface IStudentiService
    {
        Task<IEnumerable<StudentDto>> DohvatiSveStudenteAsync();

        Task<int> KreirajStudentAsync(StudentDto obj);
        Task<bool> IzbrisiStudentaAsync(int StudentId);
        Task<int> IzmeniStudentaAsync(StudentDto obj);
    }
}
