using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblAdMap : EntityTypeConfiguration<tblAd>
    {
        public tblAdMap()
        {
            // Primary Key
            this.HasKey(t => t.idAds);

            // Properties
            this.Property(t => t.HeadShort)
                .HasMaxLength(200);

            this.Property(t => t.ImageName)
                .HasMaxLength(50);

            this.Property(t => t.ImageLink)
                .HasMaxLength(50);

            this.Property(t => t.ImageLinkRoot)
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblAds");
            this.Property(t => t.idAds).HasColumnName("idAds");
            this.Property(t => t.HeadShort).HasColumnName("HeadShort");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageLink).HasColumnName("ImageLink");
            this.Property(t => t.ImageLinkRoot).HasColumnName("ImageLinkRoot");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
            this.Property(t => t.idUser).HasColumnName("idUser");
        }
    }
}
