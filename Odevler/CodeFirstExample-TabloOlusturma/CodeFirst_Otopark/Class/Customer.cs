using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Otopark.Class
{
    class Customer
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
    }
}
