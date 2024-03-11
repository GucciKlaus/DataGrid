using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    internal class HospitalDBContext :DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Examination> Examinations { get; set; }

        public HospitalDBContext()
        {
            
        }

        public HospitalDBContext(DbContextOptions<HospitalDBContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            string conStr = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=C:\Users\hoehfurtnerk190028\Downloads\DaataGrid-master\DaataGrid-master\DataLayerLib\HosDB.mdf; database=HosDBGrpA;integrated security=True;MultipleActiveResultSets=True;";

            Console.WriteLine($"Using ConnStr={conStr}");
            optionsBuilder.UseSqlServer(conStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
