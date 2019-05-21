using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ControleAcesso
{
    public class Login
    {
        public virtual int UserID { get; set; }
        public virtual string Password { get; set; }
        public virtual int LoginAtempt { get; set; }
        public virtual DateTime LastLoginDate { get; set; }
        public virtual string LastLoginIP { get; set; }
    }
}
