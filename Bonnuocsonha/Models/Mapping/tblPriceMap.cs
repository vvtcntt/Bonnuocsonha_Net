using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblPriceMap : EntityTypeConfiguration<tblPrice>
    {
        public tblPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblPrice");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idDMNPP).HasColumnName("idDMNPP");
            this.Property(t => t.idProduct).HasColumnName("idProduct");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
