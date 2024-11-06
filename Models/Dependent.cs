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
    [PrimaryKey(nameof(Essn), nameof(Dependent_Name))]
    public class Dependent
    {
        [ForeignKey("Employee")]
        [Required]
        public int Essn { get; set  ; }
        public virtual Employee Employee { get; set; }

        [Required]
        public string Dependent_Name { get; set; }

        public enum Sex
        {
            Male,
            Female
        }
        [EnumDataType(typeof(Sex))]
        public Sex sex { get; set; }


        public DateOnly Bdate { get; set; }


        public enum RelationshipType
        {
            Parent,
            Child, 
            Partner,
            Sibling
        }

        [Required]
        [EnumDataType(typeof(RelationshipType))]
        public RelationshipType relationship { get; set; }

    }
}
