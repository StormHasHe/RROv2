using Entities.ControleAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessContracts.Interface.DataAccess
{
    public interface IAuthRepository
    {
        User FindUser(string userName, string password);
    }
}
