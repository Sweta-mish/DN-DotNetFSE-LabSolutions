using _1._Web_Api_CRUD_operation.Models;
using System;
using System.Collections.Generic;

namespace _1._Web_Api_CRUD_operation.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Salary { get; set; }

        public bool Permanent { get; set; }

        public Department? Department { get; set; }

        public List<Skill>? Skills { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}