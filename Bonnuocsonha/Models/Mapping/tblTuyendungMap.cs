using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblTuyendungMap : EntityTypeConfiguration<tblTuyendung>
    {
        public tblTuyendungMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.HeadShort)
                .HasMaxLength(500);

            this.Property(t => t.ImageName)
                .HasMaxLength(50);

            this.Property(t => t.ImageLink)
                .HasMaxLength(200);

            this.Property(t => t.ImageLinkRoor)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblTuyendung");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HeadShort).HasColumnName("HeadShort");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageLink).HasColumnName("ImageLink");
            this.Property(t => t.ImageLinkRoor).HasColumnName("ImageLinkRoor");
        }
    }
}
