﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst.Models
{
    [PrimaryKey(nameof(Essn), nameof(Pno))]
    public class Works_On
    {
        [ForeignKey("Employee")]
        public int Essn { get; set; }
        public Employee Employee { get; set; }


        [ForeignKey("Project")]
        public int Pno { get; set;}
        public Project Project { get; set; }


        public int Hours { get; set; }
    }
}
