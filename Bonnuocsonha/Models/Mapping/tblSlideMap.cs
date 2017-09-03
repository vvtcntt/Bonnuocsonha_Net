using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblSlideMap : EntityTypeConfiguration<tblSlide>
    {
        public tblSlideMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ImageName)
                .HasMaxLength(50);

            this.Property(t => t.ImageLink)
                .HasMaxLength(200);

            this.Property(t => t.ImageLinkRoot)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblSlide");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.idMenu).HasColumnName("idMenu");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageLink).HasColumnName("ImageLink");
            this.Property(t => t.ImageLinkRoot).HasColumnName("ImageLinkRoot");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
