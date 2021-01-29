using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Otopark.Class
{
    class Brand
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string BrandName { get; set; }
        public virtual ICollection<Serial> Serial { get; set; }
        public virtual ICollection<VehicleParkingInformation>VehicleParkingInformation { get; set; }
    }
}
