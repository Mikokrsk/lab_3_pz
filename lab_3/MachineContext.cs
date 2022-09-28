using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab_3
{
    public class MachineContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Machine_component> Components { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public string DbPath { get; set; }

        public MachineContext()
        {
            var directory = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(directory);
            DbPath = Path.Join(path, "Library3.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
