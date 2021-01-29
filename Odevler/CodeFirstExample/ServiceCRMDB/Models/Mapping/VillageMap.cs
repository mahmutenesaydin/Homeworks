using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class VillageMap : EntityTypeConfiguration<Village>
    {
        public VillageMap()
        {
            // Primary Key
            this.HasKey(t => t.VillageID);

            // Properties
            this.Property(t => t.VillageName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Village");
            this.Property(t => t.VillageID).HasColumnName("VillageID");
            this.Property(t => t.VillageName).HasColumnName("VillageName");
            this.Property(t => t.TownID).HasColumnName("TownID");

            // Relationships
            this.HasOptional(t => t.Town)
                .WithMany(t => t.Villages)
                .HasForeignKey(d => d.TownID);

        }
    }
}
