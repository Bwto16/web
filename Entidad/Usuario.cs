using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public int ID { get; set; }
        public string TipoUsuario { get; set; }
        public string User { get; set; }

        public Usuario() : this(0, "", "") { }
        public Usuario(int ID, string TipoUsuario, string User)
        {
            this.ID = ID;
            this.TipoUsuario = TipoUsuario;
            this.User = User;
        }
    }
}