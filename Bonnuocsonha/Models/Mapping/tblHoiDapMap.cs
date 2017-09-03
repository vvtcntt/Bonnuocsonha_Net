using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblHoiDapMap : EntityTypeConfiguration<tblHoiDap>
    {
        public tblHoiDapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.Tieude)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblHoiDap");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Tieude).HasColumnName("Tieude");
            this.Property(t => t.Noidung).HasColumnName("Noidung");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
