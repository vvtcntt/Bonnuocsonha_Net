using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblMenuNPPMap : EntityTypeConfiguration<tblMenuNPP>
    {
        public tblMenuNPPMap()
        {
            // Primary Key
            this.HasKey(t => t.idDMNPP);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblMenuNPP");
            this.Property(t => t.idDMNPP).HasColumnName("idDMNPP");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.NameURL).HasColumnName("NameURL");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.idUser).HasColumnName("idUser");
        }
    }
}
