using College.BusinessModels.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.BL.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentDto> GetAllStudents();
    }
}
