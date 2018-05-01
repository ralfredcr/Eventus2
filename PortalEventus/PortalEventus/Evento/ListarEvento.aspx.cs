using BE_Eventus;
using BP_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus.Evento
{
    public partial class ListarEvento : System.Web.UI.Page
    {
        public string descripcion
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["descripcion"]))
                {
                    return Request.QueryString["descripcion"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        EventoBL iEvento = new EventoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEventos();
            }
        }

        public void CargarEventos()
        {
            
            List<EventoBE> lista = new List<EventoBE>();

            lista = iEvento.LstEvento(descripcion);
            gEvento.DataSource = lista;
            gEvento.DataBind();
        }

    }
}