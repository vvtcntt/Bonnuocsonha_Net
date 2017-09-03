using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblMenuNewMap : EntityTypeConfiguration<tblMenuNew>
    {
        public tblMenuNewMap()
        {
            // Primary Key
            this.HasKey(t => t.idMenu);

            // Properties
            this.Property(t => t.MenuName)
                .HasMaxLength(300);

            this.Property(t => t.MenuNameURL)
                .HasMaxLength(300);

            this.Property(t => t.ImageName)
                .HasMaxLength(50);

            this.Property(t => t.ImageLink)
                .HasMaxLength(200);

            this.Property(t => t.ImageLinkRoot)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblMenuNews");
            this.Property(t => t.idMenu).HasColumnName("idMenu");
            this.Property(t => t.idParent).HasColumnName("idParent");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.MenuNameURL).HasColumnName("MenuNameURL");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageLink).HasColumnName("ImageLink");
            this.Property(t => t.ImageLinkRoot).HasColumnName("ImageLinkRoot");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.UserID).HasColumnName("UserID");
        }
    }
}
