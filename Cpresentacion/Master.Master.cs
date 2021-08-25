using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;

namespace Cpresentacion
{
    public partial class Master : System.Web.UI.MasterPage
    {
        Login1 L = new Login1();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (L.id != 0)
            {
                string key = "popup";
                string javascript = "document.getElementById('inicio').style.display = 'flex'; document.getElementById('invitado').style.display = 'none';";

                if (!Page.ClientScript.IsStartupScriptRegistered(key))
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), key, javascript, true);
                }
            }
        }
    }
}