using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    internal class Dependent
    {
        [ForeignKey]
        public int Essn { get; set; }

        public string Dependent_Name { get; set; }

        public bool Sex { get; set; }

        public DateOnly Bdate { get; set; }

        public string Relationship { get; set; }

    }
}
