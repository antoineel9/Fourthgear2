using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FourthGear2.Data;

namespace FourthGear2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FourthGear2.Data.Accounting> Accounting { get; set; }
        public DbSet<FourthGear2.Data.Delegates> Delegates { get; set; }
        public DbSet<FourthGear2.Data.Departments> Departments { get; set; }
        public DbSet<FourthGear2.Data.Supervisors> Supervisors { get; set; }
    }
}
