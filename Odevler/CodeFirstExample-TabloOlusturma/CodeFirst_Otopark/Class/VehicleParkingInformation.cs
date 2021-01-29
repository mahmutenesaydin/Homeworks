using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Otopark.Class
{
    class VehicleParkingInformation
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        public string NameSurname { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public int CustomerID { get; set; }
        public int BrandID { get; set; }
        public int SerialID { get; set; }
        public DateTime EntryDate{ get; set; }
        public virtual VehicleParking vehicleParking { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Serial Serial { get; set; }
    }
}
