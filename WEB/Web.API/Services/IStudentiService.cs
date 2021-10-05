using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Models;

namespace Web.API.Services
{
    public interface IStudentiService
    {
        Task<List<StudentDto>> DohvatiSveStudenteAsync();
    }
}
