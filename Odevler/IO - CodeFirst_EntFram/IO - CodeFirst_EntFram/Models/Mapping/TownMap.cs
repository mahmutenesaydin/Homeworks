using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO___CodeFirst_EntFram.Models.Mapping
{
    public class TownMap : EntityTypeConfiguration<Town>
    {
        public TownMap()
        {
            // Primary Key
            this.HasKey(t => t.TownID);

            // Properties
            this.Property(t => t.TownName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Town");
            this.Property(t => t.TownID).HasColumnName("TownID");
            this.Property(t => t.TownName).HasColumnName("TownName");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.Towns)
                .HasForeignKey(d => d.ProvinceID);

        }
    }
}
