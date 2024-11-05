using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    internal class Employee
    {
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public int SSN { get; set; }
        public DateOnly Bdate { get; set; }
        public string Address { get; set; }
        public bool Sex { get; set; }
        public float Salary { get; set; }
        
        [ForeignKey]
        public int SuperSSN { get; set; }

        [ForeignKey]
        public int Dno { get; set; }
    }
}
