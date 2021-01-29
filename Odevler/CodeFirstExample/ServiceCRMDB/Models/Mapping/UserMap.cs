using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ServiceCRMDB.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(15);

            this.Property(t => t.Gender)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Gender).HasColumnName("Gender");
        }
    }
}
