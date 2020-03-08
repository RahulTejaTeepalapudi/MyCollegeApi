using College.BL.Implementations;
using College.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College.Service.WebApi.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentService _studentService = null;

        public IStudentService StudentService
        {
            get
            {
                if (_studentService == null)
                    _studentService = new StudentService();
                return _studentService;
            }
            set
            {
                _studentService = value;
            }
        }

        [HttpGet]
        public IHttpActionResult GetAllStudents()
        {
            var students = StudentService.GetAllStudents();
            return Ok(students);
        }
    }
}
