using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Otopark.Class
{
    class VehicleParking
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string vehicleParking { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Status { get; set; }
        public virtual ICollection<VehicleParkingInformation> vehicleParkingInformation { get; set; }

    }
}
