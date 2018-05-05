using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session[NombreSesiones.PerfilId] == null)
                {
                    txtBuscar.Visible = false;
                    btnBuscar.Visible = false;
                }
                else
                {
                    txtBuscar.Visible = true;
                    btnBuscar.Visible = true;
                }
                
            }
        }



        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string descripcionAdicional = txtBuscar.Text;
            Response.Redirect("Evento/ListarEvento.aspx?descripcionAdicional=" + descripcionAdicional);

        }
    }
}