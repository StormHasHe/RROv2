using SimpleInjector;
using Services.Services;
using DataAccess.Context;
using Contracts.Interface.Service;
using DataAccess.Repository;
using DataAccessContracts.Interface.DataAccess;

namespace IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //DbContexts
            container.Register<ApplicationContext>(Lifestyle.Scoped);
            
            //Repositories
            container.Register<IAuthRepository, AuthRepository>(Lifestyle.Scoped);

            //Services
            container.Register<IAuthService, AuthService>(Lifestyle.Scoped);
        }
    }
}