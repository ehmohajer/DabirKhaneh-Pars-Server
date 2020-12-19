using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dabirkhaneh.Data.DataBaseContext
{
    class DabirkhanehDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DabirkhanehPars;Integrated Security=True;MultipleActiveResultSets=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TArchive> TArchives { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<OrganPerson> OrganPersons { get; set; }
        public DbSet<Organ> Organs { get; set; }
        public DbSet<LetterOut> LetterOuts { get; set; }
        public DbSet<LetterIn> LetterIns { get; set; }
        public DbSet<LetterInter> letterInters { get; set; }
        public DbSet<Attach> Attaches { get; set; }
    }
}
