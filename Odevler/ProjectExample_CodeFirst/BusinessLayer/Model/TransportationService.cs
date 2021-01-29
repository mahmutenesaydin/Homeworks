using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    [Table("TransportationServices")]
    public class TransportationService
    {
        public TransportationService()
        {
            this.Provinces = new List<Province>();
            this.Towns = new List<Town>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransportationServiceID { get; set; }
        [MaxLength(50)]
        public string TransportationServicee { get; set; }

       
        public List<Province> Provinces { get; set; }
        public List <Town> Towns { get; set; }
    }
}

