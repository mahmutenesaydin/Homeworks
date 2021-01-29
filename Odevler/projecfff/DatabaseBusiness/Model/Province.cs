using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBusiness.Model
{
    [Table("Province")]
    public class Province
    {
        public Province()
        {
            this.Towns = new List<Town>();
            this.Users = new List<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProvinceID { get; set; }
        [MaxLength(50)]
        public string ProvinceName { get; set; }
        public int PlateCode { get; set; }
        public byte[] Images { get; set; }
        public int PlaceToVisitID { get; set; }
        public int WhatFamousID { get; set; }
        public int PopulationID { get; set; }
        public int RegionID { get; set; }
        public int TransportationServiceID { get; set; }
        public int PartyID { get; set; }

        [ForeignKey("PlaceToVisitID")]
        public PlacesToVisit PlacesToVisit { get; set; }
        [ForeignKey("PartyID")]
        public RulingParty RulingParty { get; set; }
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
        [ForeignKey("TransportationServiceID")]
        public TransportationService TransportationService { get; set; }
        [ForeignKey("WhatFamousID")]
        public WhatFamous WhatFamous { get; set; }

        public List<Town> Towns { get; set; }
        public List<User> Users { get; set; }
    }
}   
