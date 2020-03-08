using College.CL.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.BusinessModels.Entities.DTOs
{
    public class StudentDto
    {
        [SourceName("RollNumber")]
        public string RollNumber { get; set; }

        [SourceName("StudentName")]
        public string StudentName { get; set; }

        [SourceName("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [SourceName("Gender")]
        public string Gender { get; set; }

        [SourceName("EmailId")]
        public string EmailId { get; set; }

        [SourceName("DepartmentCode")]
        public string DepartmentCode { get; set; }

        [SourceName("CourseCode")]
        public string CourseCode { get; set; }

        [SourceName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [SourceName("StartYear")]
        public DateTime StartYear { get; set; }

        [SourceName("EndTYear")]
        public DateTime EndYear { get; set; }

        [SourceName("AdmissionType")]
        public string AdmissionType { get; set; }

        [SourceName("StudentType")]
        public string StudentType { get; set; }

    }
}
