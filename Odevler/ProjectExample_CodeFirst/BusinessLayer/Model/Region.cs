using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    [Table("Region")]
    public class Region
    {
        public Region()
        {
            this.Provinces = new List<Province>();  
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegionID { get; set; }
        [MaxLength(50)]
        public string RegionName { get; set; }

        public List<Province> Provinces { get; set; }
    }
}
