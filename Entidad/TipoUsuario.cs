using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TipoUsuario
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public TipoUsuario() { }

        public TipoUsuario(int ID, string Tipo)
        {
            this.ID = ID;
            this.Tipo = Tipo;
        }
    }
}
