using FamilyFile.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Infrastructure.Data
{
    public class FamilyFileContext:DbContext
    {
        public FamilyFileContext(DbContextOptions<FamilyFileContext> options):base(options)
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }

        #endregion DbSet

    }
}
