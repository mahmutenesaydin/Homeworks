using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    [Table("PlacesToVisit")]
    public class PlacesToVisit
    {
        public PlacesToVisit()
        {
            this.Provinces = new List<Province>();
            this.Towns = new List<Town>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaceToVisitID { get; set; }
        [MaxLength(200)]
        public string PlaceToVisit { get; set; }
        public List<Province> Provinces { get; set; }
        public List<Town> Towns { get; set; }
    }
}
