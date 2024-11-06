using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    [PrimaryKey(nameof(SID), nameof(Phone_No))]
    public class Student_Phones
    {
        [ForeignKey("Students")]
        public int SID { get; set; }

        [Required]
        public string Phone_No { get; set; }

    }
}
