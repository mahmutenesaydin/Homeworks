using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class PlacesToVisitMap : EntityTypeConfiguration<PlacesToVisit>
    {
        public PlacesToVisitMap()
        {
            // Primary Key
            this.HasKey(t => t.PlacesToVisitID);

            // Properties
            this.Property(t => t.PlacesToVisit1)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("PlacesToVisit");
            this.Property(t => t.PlacesToVisitID).HasColumnName("PlacesToVisitID");
            this.Property(t => t.PlacesToVisit1).HasColumnName("PlacesToVisit");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.PlacesToVisits)
                .HasForeignKey(d => d.ProvinceID);

        }
    }
}
