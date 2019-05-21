using Entities.ControleAcesso;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfig
{
    public class LoginConfig : EntityTypeConfiguration<Login>
    {
        public LoginConfig()
        {
            HasKey(u => u.UserID);

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(500);

            Property(u => u.LoginAtempt)
                .IsRequired();

            Property(u => u.LastLoginDate)
                .IsRequired();

            Property(u => u.LastLoginIP)
                .IsRequired()
                .HasMaxLength(50);

            ToTable("Login");
        }
    }
}
