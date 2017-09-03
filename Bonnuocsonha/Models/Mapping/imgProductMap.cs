using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class imgProductMap : EntityTypeConfiguration<imgProduct>
    {
        public imgProductMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.ImageName)
                .HasMaxLength(200);

            this.Property(t => t.ImageLink)
                .HasMaxLength(500);

            this.Property(t => t.ImageLinkRoot)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("imgProduct");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idProduct).HasColumnName("idProduct");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageLink).HasColumnName("ImageLink");
            this.Property(t => t.ImageLinkRoot).HasColumnName("ImageLinkRoot");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
