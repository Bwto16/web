using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Logica;

namespace Cpresentacion
{
    public partial class Login1 : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = UsuarioLN.getInstance().AccesoSistema(TxtUsuario.Text, TxtPass.Text);

            if(objUsuario !=null)
            {
                id = 1;
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario y/o Contraseña incorrecta')</script>");
            }
        }
    }
}