using System;
using System.Collections.Generic;

namespace Student_CRUD_and_API.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public byte Year { get; set; }
        public string Department { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
