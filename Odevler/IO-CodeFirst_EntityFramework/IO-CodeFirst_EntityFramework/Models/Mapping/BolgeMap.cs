using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace IO_CodeFirst_EntityFramework.Models.Mapping
{
    public class BolgeMap : EntityTypeConfiguration<Bolge>
    {
        public BolgeMap()
        {
            // Primary Key
            this.HasKey(t => t.BolgeID);

            // Properties
            this.Property(t => t.BolgeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BolgeTanimi)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bolge");
            this.Property(t => t.BolgeID).HasColumnName("BolgeID");
            this.Property(t => t.BolgeTanimi).HasColumnName("BolgeTanimi");
        }
    }
}
