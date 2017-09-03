using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblPopupMap : EntityTypeConfiguration<tblPopup>
    {
        public tblPopupMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.HeadShort)
                .HasMaxLength(500);

            this.Property(t => t.ImageName)
                .HasMaxLength(100);

            this.Property(t => t.Imagelink)
                .HasMaxLength(500);

            this.Property(t => t.ImageLinkRoot)
                .HasMaxLength(500);

            this.Property(t => t.Url)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblPopup");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HeadShort).HasColumnName("HeadShort");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.Imagelink).HasColumnName("Imagelink");
            this.Property(t => t.ImageLinkRoot).HasColumnName("ImageLinkRoot");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
