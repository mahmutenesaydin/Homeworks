using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBusiness.Model
{
    [Table("PlacesToVisit")]
    [DataContract]
    public class PlacesToVisit
    {
        public PlacesToVisit()
        {
            this.Provinces = new List<Province>();
            this.Towns = new List<Town>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int PlaceToVisitID { get; set; }
        [MaxLength(200)]
        [DataMember]
        public string PlaceToVisit { get; set; }
        public List<Province> Provinces { get; set; }
        public List<Town> Towns { get; set; }
    }
}
