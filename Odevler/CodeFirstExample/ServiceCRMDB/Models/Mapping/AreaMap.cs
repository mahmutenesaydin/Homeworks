using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaID);

            // Properties
            this.Property(t => t.Area1)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Area");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.Area1).HasColumnName("Area");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.TownID).HasColumnName("TownID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.ProvinceID);
            this.HasOptional(t => t.Town)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.TownID);

        }
    }
}
