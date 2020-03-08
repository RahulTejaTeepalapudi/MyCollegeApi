using College.BL.Interfaces;
using College.BusinessModels.Entities.DTOs;
using College.DAL.AdoRepository.Repositories;
using College.DAL.IRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.BL.Implementations
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository = null;

        public IStudentRepository StudentRepository
        {
            get
            {
                if (_studentRepository == null)
                    _studentRepository = new StudentRepository();
                return _studentRepository;
            }
            set
            {
                _studentRepository = value;
            }
        }

        public IEnumerable<StudentDto> GetAllStudents()
        {
            return StudentRepository.GetAllStudents();
        }
    }
}
