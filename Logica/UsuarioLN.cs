using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Acceso;

namespace Logica
{
    public class UsuarioLN
    {
        #region "PATRON SINGLETON"
        private static UsuarioLN objUsuario = null;
        private UsuarioLN() { }
        public static UsuarioLN getInstance()
        {
            if (objUsuario == null)
            {
                objUsuario = new UsuarioLN();
            }
            return objUsuario;
        }
        #endregion

        public Usuario AccesoSistema(String user, String Pass)
        {
            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(user, Pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
