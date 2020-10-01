using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignToSeminarBackEnd
{
    public class ApplicationDbContext : DbContext   
    {
        public DbSet<Visitor> Visitors { set; get; }
        public DbSet<Seminar> Seminars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-PJO5M4U\SQLEXPRESS;database=SignToseminar;Trusted_Connection=True;");
        }
    }
}
