using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblPageMap : EntityTypeConfiguration<tblPage>
    {
        public tblPageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblPage");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idRight).HasColumnName("idRight");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
