using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Bonnuocsonha.Models.Mapping
{
    public class tblNPPMap : EntityTypeConfiguration<tblNPP>
    {
        public tblNPPMap()
        {
            // Primary Key
            this.HasKey(t => t.idNPP);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.NameURL)
                .HasMaxLength(200);

            this.Property(t => t.HeadShort)
                .HasMaxLength(500);

            this.Property(t => t.Address)
                .HasMaxLength(300);

            this.Property(t => t.Mobile)
                .HasMaxLength(50);

            this.Property(t => t.People)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblNPP");
            this.Property(t => t.idNPP).HasColumnName("idNPP");
            this.Property(t => t.idDMNPP).HasColumnName("idDMNPP");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.NameURL).HasColumnName("NameURL");
            this.Property(t => t.HeadShort).HasColumnName("HeadShort");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.People).HasColumnName("People");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Tags).HasColumnName("Tags");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
