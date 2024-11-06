using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    [Index(nameof(Department.Dnumber), IsUnique = true)]
    public class Department
    {
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Dname { get; set; }

        [Key]
        [Required]
        public int Dnumber { get; set; }

        [ForeignKey("Supervisor")]
        public int Mgr_SSN { get; set; }
        public virtual Employee Supervisor { get; set; }

        public DateOnly Mgr_Start_Date { get; set; }

        [InverseProperty("Departments")]
        public virtual ICollection<Employee> Employees { get; set; } //For works for relationship
        public virtual ICollection<Project> Project { get; set; }
        public virtual ICollection<Dept_location> Locations { get; set; }

    }
}
