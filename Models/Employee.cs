using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    public class Employee
    {
        [StringLength(10, MinimumLength = 2)]
        public string Fname { get; set; }


        [StringLength(10, MinimumLength = 2)]
        public string Mname { get; set; }


        [StringLength(10, MinimumLength = 2)]
        public string Lname { get; set; }


        [Key]
        [Required]
        public int SSN { get; set; }
        public DateOnly Bdate { get; set; }


        [StringLength(50, MinimumLength = 2)]
        public string Address { get; set; }
        public enum Sex
        {
            Male,
            Female
        }
        [EnumDataType(typeof(Sex))]
        public Sex sex { get; set; }


        [MaxLength(100000)]
        public float Salary { get; set; }
        

        [ForeignKey("Manager")]
        public int SuperSSN { get; set; }
        public virtual Employee Manager { get; set; }


        [ForeignKey("Departments")] //For Works for relationship 
        public int Dno { get; set; }
        public virtual Department Departments { get; set; }

        [InverseProperty("Supervisor")]
        public virtual ICollection<Department> Department { get; set; } //For manages relationship
       
        public virtual ICollection<Works_On> Works_On { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }

        [InverseProperty("Manager")]
        public virtual ICollection<Employee> Managers { get; set; }

    }
}
