using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBusiness.Model
{

    [Table("Village")]
    public class Village
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VillageID { get; set; }
        [MaxLength(50)]
        public string VillageName { get; set; }
        public byte[] Images { get; set; }
        public int TownID { get; set; }

        [ForeignKey("TownID")]
        public Town Town { get; set; }
    }
}
