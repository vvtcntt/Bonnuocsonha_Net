using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class MapMap : EntityTypeConfiguration<Map>
    {
        public MapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.HeadShort)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Maps");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HeadShort).HasColumnName("HeadShort");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.iView).HasColumnName("iView");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
            this.Property(t => t.idUser).HasColumnName("idUser");
        }
    }
}
