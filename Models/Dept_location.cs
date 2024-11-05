using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    internal class Dept_location
    {
        [ForeignKey]
        public int Dnumber { get; set; }

        [ForeignKey]
        public string Location { get; set; }
    }
}
