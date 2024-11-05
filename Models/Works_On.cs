using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    public class Works_On
    {
        [ForeignKey("Employee")]
        public int Essn { get; set; }

        [ForeignKey("Project")]
        public int Pno { get; set;}
        public int Hours { get; set; }
    }
}
