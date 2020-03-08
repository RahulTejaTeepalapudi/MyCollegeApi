using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College.BusinessModels.Entities.DTOs;

namespace College.DAL.IRepository.IRepositories
{
    public interface IStudentRepository
    {
        IEnumerable<StudentDto> GetAllStudents();
    }
}
