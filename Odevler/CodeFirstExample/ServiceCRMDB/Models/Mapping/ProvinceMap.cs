using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class ProvinceMap : EntityTypeConfiguration<Province>
    {
        public ProvinceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProvinceID);

            // Properties
            this.Property(t => t.ProvinceName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Province");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.ProvinceName).HasColumnName("ProvinceName");
            this.Property(t => t.PlateCode).HasColumnName("PlateCode");
        }
    }
}
