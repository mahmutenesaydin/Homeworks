using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst_Otopark.Class
{
    class OtoparkDbContext:DbContext
    {
        public DbSet<Brand> CFmarka { get; set; }
        public DbSet<Customer> CFcustomer { get; set; }
        public DbSet<Serial> CFserial { get; set; }
        public DbSet<VehicleParking> CFvehicleParking { get; set; }
        public DbSet<VehicleParkingInformation> CFparkingInformation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
