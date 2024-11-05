using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMCodeFirst
{
    public class CustomDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(" Data Source=(local); Initial Catalog=ORMCodeFirst; Integrated Security=true; TrustServerCertificate=True ");
        }
    }
}
