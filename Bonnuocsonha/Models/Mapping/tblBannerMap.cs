using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblBannerMap : EntityTypeConfiguration<tblBanner>
    {
        public tblBannerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.ImageName)
                .HasMaxLength(50);

            this.Property(t => t.ImageLink)
                .HasMaxLength(200);

            this.Property(t => t.ImageLinkRoot)
                .HasMaxLength(200);

            this.Property(t => t.Url)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblBanner");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageLink).HasColumnName("ImageLink");
            this.Property(t => t.ImageLinkRoot).HasColumnName("ImageLinkRoot");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
