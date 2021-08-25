using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Acceso
{
    public class UsuarioDAO
    {
        #region "PATRON SINGLETON"
        private static UsuarioDAO daoUsuario = null;
        private UsuarioDAO() { }
        public static UsuarioDAO getInstance()
        {
            if (daoUsuario == null)
            { daoUsuario = new UsuarioDAO(); }
            return daoUsuario;
        }
        #endregion
        public Usuario AccesoSistema(String User, String Pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Usuario objUsuario = null;
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", User);
                cmd.Parameters.AddWithValue("@prmpass", Pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.ID = Convert.ToInt32(dr["ID"].ToString());
                    objUsuario.User = dr["USUARIO"].ToString();
                    objUsuario.TipoUsuario = dr["NOM_TIPO"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objUsuario;
        }
    }
}
