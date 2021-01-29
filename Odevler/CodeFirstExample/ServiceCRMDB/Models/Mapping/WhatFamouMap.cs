using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class WhatFamouMap : EntityTypeConfiguration<WhatFamou>
    {
        public WhatFamouMap()
        {
            // Primary Key
            this.HasKey(t => t.WhatFamousID);

            // Properties
            this.Property(t => t.WhatFamous)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("WhatFamous");
            this.Property(t => t.WhatFamousID).HasColumnName("WhatFamousID");
            this.Property(t => t.WhatFamous).HasColumnName("WhatFamous");
            this.Property(t => t.ProvinceID).HasColumnName("ProvinceID");

            // Relationships
            this.HasOptional(t => t.Province)
                .WithMany(t => t.WhatFamous)
                .HasForeignKey(d => d.ProvinceID);

        }
    }
}
