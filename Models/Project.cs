using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    internal class Project
    {
        public string Pname { get; set; }
        public int Pnumber { get; set; }
        public string PLocation { get; set; }
        
        [ForeignKey]
        public int Dnum { get; set; }

    }
}
