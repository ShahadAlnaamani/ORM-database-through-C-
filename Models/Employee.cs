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
        
        [ForeignKey("Employee")]
        public int SuperSSN { get; set; }

        [ForeignKey("Department")]
        public int Dno { get; set; }
    }
}
