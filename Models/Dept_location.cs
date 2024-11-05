using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    [PrimaryKey(nameof(Dnumber), nameof(Location))]
    public class Dept_location
    {
        [ForeignKey("Department")]
        [Required]
        public int Dnumber { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
