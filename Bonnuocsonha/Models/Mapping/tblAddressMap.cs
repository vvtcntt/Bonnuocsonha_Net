using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblAddressMap : EntityTypeConfiguration<tblAddress>
    {
        public tblAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblAddress");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idProduct).HasColumnName("idProduct");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
