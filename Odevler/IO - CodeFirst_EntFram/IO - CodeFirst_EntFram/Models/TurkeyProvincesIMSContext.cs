using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IO___CodeFirst_EntFram.Models.Mapping;

namespace IO___CodeFirst_EntFram.Models
{
    public partial class TurkeyProvincesIMSContext : DbContext
    {
        static TurkeyProvincesIMSContext()
        {
            Database.SetInitializer<TurkeyProvincesIMSContext>(null);
        }

        public TurkeyProvincesIMSContext()
            : base("Name=TurkeyProvincesIMSContext")
        {
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<PlacesToVisit> PlacesToVisits { get; set; }
        public DbSet<Population> Populations { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RulingParty> RulingParties { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<TransportationService> TransportationServices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<WhatFamou> WhatFamous { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new PlacesToVisitMap());
            modelBuilder.Configurations.Add(new PopulationMap());
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new RulingPartyMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TownMap());
            modelBuilder.Configurations.Add(new TransportationServiceMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new VillageMap());
            modelBuilder.Configurations.Add(new WhatFamouMap());
        }
    }
}
