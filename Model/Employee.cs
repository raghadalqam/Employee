using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; } // العلاقة مع القسم
        public List<Project> Projects { get; set; } = new List<Project>(); // العلاقة مع المشاريع
    }
}
