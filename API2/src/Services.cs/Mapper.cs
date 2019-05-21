using Contracts.DTO;
using Entities.ControleAcesso;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal static class Mapper
    {
        public static UserDTO ToUserDTO(this User user)
        {
            var retorno = new UserDTO()
            {
               ID = user.ID,
               Email = user.Email,
               Name = user.Name
            };

            return retorno;
        }
    }
}
