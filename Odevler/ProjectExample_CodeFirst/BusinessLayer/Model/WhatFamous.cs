using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    [Table("WhatFamous")]
    public class WhatFamous
    {
        public WhatFamous()
        {
            this.Provinces = new List<Province>();
            this.Towns = new List<Town>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WhatFamousID { get; set; }
        [MaxLength(100)]
        public string WhatFamouss { get; set; }
        public List<Province> Provinces { get; set; }
        public List<Town> Towns { get; set; }
    }
}
