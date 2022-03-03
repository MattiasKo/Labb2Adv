using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Adv.Models
{
    class SkolaDbContext :DbContext
    {
 
        public DbSet<Lärare> Lärare { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Linje> Linjes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NP9Q5EE; Initial Catalog = Labb2ADV; Integrated Security = True;");
        }

    }
}
