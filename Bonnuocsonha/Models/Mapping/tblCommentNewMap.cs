using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblCommentNewMap : EntityTypeConfiguration<tblCommentNew>
    {
        public tblCommentNewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.NameNew)
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblCommentNew");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idNew).HasColumnName("idNew");
            this.Property(t => t.NameNew).HasColumnName("NameNew");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
        }
    }
}
