using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO___CodeFirst_EntFram.Models.Mapping
{
    public class RulingPartyMap : EntityTypeConfiguration<RulingParty>
    {
        public RulingPartyMap()
        {
            // Primary Key
            this.HasKey(t => t.PartyID);

            // Properties
            this.Property(t => t.Party)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RulingParty");
            this.Property(t => t.PartyID).HasColumnName("PartyID");
            this.Property(t => t.Party).HasColumnName("Party");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");
            this.Property(t => t.TownID).HasColumnName("TownID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.RulingParties)
                .HasForeignKey(d => d.ProvinceID);
            this.HasOptional(t => t.Town)
                .WithMany(t => t.RulingParties)
                .HasForeignKey(d => d.TownID);

        }
    }
}
