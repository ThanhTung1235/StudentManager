using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Models
{
    
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public StudentStatus Status { get; set; }

        public Student()
        {
            this.Gender = Gender.Male;
            this.Status = StudentStatus.Activited;

        }
    }
    
    public enum Gender
    {
        Female = 0,
        Male = 1,
        Other = 2
    }

    public enum StudentStatus
    {
        Activited = 1,
        UnActivited = 0
    }
}
