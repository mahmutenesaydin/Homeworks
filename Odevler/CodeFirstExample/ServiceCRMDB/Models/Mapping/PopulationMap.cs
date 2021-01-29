using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class PopulationMap : EntityTypeConfiguration<Population>
    {
        public PopulationMap()
        {
            // Primary Key
            this.HasKey(t => t.PopulationID);

            // Properties
            this.Property(t => t.Population1)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Population");
            this.Property(t => t.PopulationID).HasColumnName("PopulationID");
            this.Property(t => t.Population1).HasColumnName("Population");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.TownID).HasColumnName("TownID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.Populations)
                .HasForeignKey(d => d.ProvinceID);
            this.HasOptional(t => t.Town)
                .WithMany(t => t.Populations)
                .HasForeignKey(d => d.TownID);

        }
    }
}
