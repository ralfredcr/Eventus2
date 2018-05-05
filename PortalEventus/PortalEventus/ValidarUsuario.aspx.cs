using BP_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus
{
    public partial class ValidarUsuario : System.Web.UI.Page
    {
        PersonaBL interfaf = new PersonaBL();
        public string usuario
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["usuario"]))
                {
                    return Request.QueryString["usuario"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            interfaf.habilitarCliente(usuario);

        }
    }
}