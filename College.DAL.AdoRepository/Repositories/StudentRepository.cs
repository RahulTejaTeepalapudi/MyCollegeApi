using College.BusinessModels.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Using SqlClient */
using System.Data.SqlClient;
using System.Data;
using College.CL.Helpers;
using College.CL.Mappers;
using College.DAL.IRepository.IRepositories;

namespace College.DAL.AdoRepository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string connectionString = "Data Source=DESKTOP-NGIN9NC;Initial Catalog=College;Integrated Security = True";
        private readonly int _connectionTimeOut = 0;


        public IEnumerable<StudentDto> GetAllStudents()
        {
            List<StudentDto> students = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandType = CommandType.StoredProcedure, 
                    CommandText = "sp_GetAllStudents",
                    CommandTimeout = _connectionTimeOut,
                };
                //sqlCommand.Parameters.AddWithValue("@DepartmentCode", "ECE");
                try
                {
                    sqlConnection.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    var result = sqlDataAdapter.Fill(ds);
                    sqlConnection.Close();
                    students = (DataHelper.TryValidateDataSource(ds, 0, out DataTable dt) == true) ? MappingHelper.MapToEntity<StudentDto>(dt) : null;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return students;
        }
    }
}
