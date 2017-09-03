using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblAssignRightMap : EntityTypeConfiguration<tblAssignRight>
    {
        public tblAssignRightMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.idUser });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblAssignRight");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idRight).HasColumnName("idRight");
            this.Property(t => t.idUser).HasColumnName("idUser");
        }
    }
}
