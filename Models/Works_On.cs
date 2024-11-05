using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    internal class Works_On
    {
        [ForeignKey]
        public int Essn { get; set; }

        [ForeignKey]
        public int Pno { get; set;}
        public int Hours { get; set; }
    }
}
