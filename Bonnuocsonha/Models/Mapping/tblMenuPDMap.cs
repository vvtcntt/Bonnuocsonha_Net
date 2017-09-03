using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblMenuPDMap : EntityTypeConfiguration<tblMenuPD>
    {
        public tblMenuPDMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblMenuPD");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
