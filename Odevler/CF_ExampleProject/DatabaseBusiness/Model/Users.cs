using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBusiness.Model
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Password { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
        //public string Gender { get; set; }
        public int ProvinceID { get; set; }

        [ForeignKey("ProvinceID")]
        public Province Province { get; set; }
    }
}
