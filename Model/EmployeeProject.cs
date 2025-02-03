using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class EmployeeProject
    {
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
