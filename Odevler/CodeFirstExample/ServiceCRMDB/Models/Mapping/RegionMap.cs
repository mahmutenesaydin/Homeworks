using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.RegionName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.ProvinceID);

        }
    }
}
