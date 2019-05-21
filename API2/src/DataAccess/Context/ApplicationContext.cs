using System;
using System.Data.Entity;
using DataAccess.EntityConfig;
using Entities.ControleAcesso;

namespace DataAccess.Context
{
    public class ApplicationContext : DbContext, IDisposable
    {
        public ApplicationContext()
            : base("CalendarioOperacaoConn")
        {
            Database.SetInitializer<ApplicationContext>(null);
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Login> Login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new LoginConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}