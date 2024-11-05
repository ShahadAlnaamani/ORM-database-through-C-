using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    internal class Department
    {
        public string Dname { get; set; }
        public int Dnumber { get; set; }

        [ForeignKey]
        public int Mgr_SSN { get; set; }
        public DateOnly Mgr_Start_Date { get; set; }
    }
}
