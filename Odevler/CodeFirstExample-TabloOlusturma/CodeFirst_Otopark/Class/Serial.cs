using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Otopark.Class
{
    class Serial
    {
        public int ID { get; set; }
        public int BrandID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string serial { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<VehicleParkingInformation>VehicleParkingInformation { get; set; }
    }
}
