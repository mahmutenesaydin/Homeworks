using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class TransportationServiceMap : EntityTypeConfiguration<TransportationService>
    {
        public TransportationServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.TransportationServicesID);

            // Properties
            this.Property(t => t.TransportationServices)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("TransportationServices");
            this.Property(t => t.TransportationServicesID).HasColumnName("TransportationServicesID");
            this.Property(t => t.TransportationServices).HasColumnName("TransportationServices");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.TownID).HasColumnName("TownID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.TransportationServices)
                .HasForeignKey(d => d.ProvinceID);
            this.HasOptional(t => t.Town)
                .WithMany(t => t.TransportationServices)
                .HasForeignKey(d => d.TownID);

        }
    }
}
