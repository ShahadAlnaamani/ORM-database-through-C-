using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    public class Project
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Pname { get; set; }

        [Key]
        [Required]  
        public int Pnumber { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string PLocation { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int Dnum { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Works_On> Works_On { get; set; }
    }
}
