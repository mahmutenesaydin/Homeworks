using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBusiness.Model
{
    [Table("Town")]
    public class Town
    {
        public Town()
        {
            this.Villages = new List<Village>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TownID { get; set; }
        public string TownName { get; set; }
        public byte[] Images { get; set; }
        [Required]
        public int ProvinceID { get; set; }
        [Required]
        public int PlaceToVisitID { get; set; }
        [Required]
        public int WhatFamousID { get; set; }
        [Required]
        public int PopulationID { get; set; }
        [Required]
        public int TransportationServiceID { get; set; }
        [Required]
        public int PartyID { get; set; }

        [ForeignKey("PlaceToVisitID")]
        public PlacesToVisit PlacesToVisit { get; set; }
        [ForeignKey("ProvinceID")]
        public Province Province { get; set; }
        [ForeignKey("PartyID")] 
        public RulingParty RulingParty { get; set; }
        [ForeignKey("TransportationServiceID")]
        public TransportationService TransportationService { get; set; }
        [ForeignKey("WhatFamousID")]
        public WhatFamous WhatFamous { get; set; }

        public List<Village> Villages { get; set; }
    }
}
