using System;
using System.Collections.Generic;

namespace hremp.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        public DateTime? Dob { get; set; }
        public Guid DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
