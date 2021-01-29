using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Context
{
    public class TurkeyProvincesContext : DbContext
    {
        public DbSet<PlacesToVisit> placesToVisit { get; set; }
        public DbSet<WhatFamous> whatFamous { get; set; }
        public DbSet<Region> region { get; set; }
        public DbSet<Province> province { get; set; }
        public DbSet<RulingParty> rulingParty { get; set; }
        public DbSet<Village> village { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<TransportationService> tranportationService { get; set; }
        public DbSet<Town> town { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //}
    }
}
