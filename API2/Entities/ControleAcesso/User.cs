using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ControleAcesso
{
    public class User
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual int RoleID { get; set; }
    }
}
