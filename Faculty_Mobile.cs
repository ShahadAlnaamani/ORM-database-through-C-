using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Models
{
    [PrimaryKey(nameof (FID),nameof (Mobile_No))]
    public class Faculty_Mobile
    {
        [ForeignKey("Faculty")]
        public int FID { get; set; }

        [Required]
        public string Mobile_No { get; set; }


    }
}
