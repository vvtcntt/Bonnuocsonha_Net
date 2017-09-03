using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblKMMap : EntityTypeConfiguration<tblKM>
    {
        public tblKMMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblKM");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idProduct).HasColumnName("idProduct");
            this.Property(t => t.Date).HasColumnName("Date");
        }
    }
}
