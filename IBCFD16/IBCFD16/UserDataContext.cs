using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace IBCFD16
{
    class UserDataContext : DbContext
    {
        public DbSet<Symptom> searchHistory { get; set; }
        public DbSet<Symptom> symptomsList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"filename=searchHistory.db");
        }
    }
}
