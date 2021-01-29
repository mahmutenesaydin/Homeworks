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
    [Table("Region")]
    [DataContract]
    public class Region
    {
        public Region()
        {
            this.Provinces = new List<Province>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int RegionID { get; set; }
        [MaxLength(50)]
        [DataMember]
        public string RegionName { get; set; }

        public List<Province> Provinces { get; set; }
    }
}
