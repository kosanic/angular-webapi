using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Models;

namespace Web.API.Services
{
    public class StudentiService : IStudentiService
    {
        private readonly string connectionString = "Server=DESKTOP-PV5OOHO;Database=StudentDtoDB;Trusted_Connection=True;";


        public async Task<IEnumerable<StudentDto>> DohvatiSveStudenteAsync()
        {
            var query = $@"select Studentid, StudentIme, StudentPrezime, DatumRodjenja from dbo.Studenti";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = await connection.QueryAsync<StudentDto>(query);
                return result;
            }
        }
      
        public async Task<int> KreirajStudentAsync(StudentDto obj)
        {
            var query = $@"
                                            insert into dbo.Studenti(BrojIndeksa, DatumRodjenja, StudentIme, StudentPrezime)
                                            values (@BrojIndeksa, @DatumRodjenja, @StudentIme, @StudentPrezime);

                                select SCOPE_IDENTITY() ";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = await connection.ExecuteScalarAsync<int>(query, obj);

                return result;
            }
        }
        public async Task<bool> IzbrisiStudentaAsync(int StudentId)
        {
            var query = $@"delete from dbo.Studenti where StudentId = @StudentId";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = await connection.ExecuteAsync(query, new { StudentId }, commandType:System.Data.CommandType.Text);

                return result == 1;
            }
        }

        public async Task<int> IzmeniStudentaAsync(StudentDto obj)
        {
            var query = $@"update dbo.Studenti set StudentIme = 'xxxx', StudentPrezime = 'xxxx', BrojIndeksa = 'xxxx', DatumRodjenja = '19990308' where StudentiId =15
                        ";
            using (var connection = new SqlConnection(connectionString))
            {
                var result = await connection.ExecuteScalarAsync<int>(query, obj);
                return result;
            }
        }

        public  async Task<StudentDto> DohvatiStudenta(int id)
        {
            var query = $@"select Studentid, StudentIme, StudentPrezime, DatumRodjenja from dbo.Studenti where Studentid = @id";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = await connection.QueryFirstOrDefaultAsync<StudentDto>(query, new { id });
                return result;
            }
        }
    }
}
