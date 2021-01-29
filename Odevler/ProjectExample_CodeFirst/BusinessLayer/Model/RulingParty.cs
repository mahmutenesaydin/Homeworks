using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    [Table("RulingParty")]
    public class RulingParty
    {
        public RulingParty()
        {
            this.Provinces = new List<Province>();
            this.Towns = new List<Town>();
        }   

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartyID { get; set; }
        [MaxLength(50)]
        public string Party { get; set; }


        public List<Province> Provinces { get; set; }
        public List<Town> Towns { get; set; }
    }
}
