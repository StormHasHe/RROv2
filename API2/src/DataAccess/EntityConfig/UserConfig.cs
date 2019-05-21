using Entities.ControleAcesso;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.EntityConfig
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasKey(u => u.ID);

            Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.RoleID)
                .IsRequired();

            ToTable("User");
        }
    }
}