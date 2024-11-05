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

        [ForeignKey("Employee")]
        public int Mgr_SSN { get; set; }

        public DateOnly Mgr_Start_Date { get; set; }
    }
}
