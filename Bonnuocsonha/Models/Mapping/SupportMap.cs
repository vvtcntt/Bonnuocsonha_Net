using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class SupportMap : EntityTypeConfiguration<Support>
    {
        public SupportMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Yahoo)
                .HasMaxLength(50);

            this.Property(t => t.Skyper)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Support");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Yahoo).HasColumnName("Yahoo");
            this.Property(t => t.Skyper).HasColumnName("Skyper");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
        }
    }
}
