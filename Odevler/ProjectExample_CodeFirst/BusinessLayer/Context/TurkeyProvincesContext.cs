using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Context
{
    public class TurkeyProvincesContext:DbContext
    {
        public DbSet<PlacesToVisit> placesToVisitt { get; set; }
        public DbSet<WhatFamous> whatFamousss { get; set; }
        public DbSet<Region> regionn{ get; set; }
        public DbSet<Province> provincee{ get; set; }
        public DbSet<RulingParty> rulingPartyy{ get; set; }
        public DbSet<Village> villagee{ get; set; }
        public DbSet<User> userr{ get; set; }
        public DbSet<TransportationService> tranportationServiceee{ get; set; }
        public DbSet<Town> townnn { get; set; }
    }
}
