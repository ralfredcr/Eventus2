using BE_Eventus;
using BP_Eventus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus.Evento
{
    public partial class ListarEvento : System.Web.UI.Page
    {
        public string descripcionAdicional
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["descripcionAdicional"]))
                {
                    return Request.QueryString["descripcionAdicional"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        EventoBL iEvento = new EventoBL();
        CategoriaBL iCategoria = new CategoriaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEventos();
                CargarCategoria();
            }
        }

        public void CargarEventos()
        {
            
            List<EventoBE> lista = new List<EventoBE>();

            lista = iEvento.LstEvento("", descripcionAdicional,-1, Convert.ToDateTime("10/10/1900"));
            /*gEvento.DataSource = lista;
            gEvento.DataBind();
            */           

            dtlEvents.DataSource = lista;
            dtlEvents.DataBind();
        }

        public void CargarCategoria()
        {
            List<CategoriaBE> lista = new List<CategoriaBE>();

            lista = iCategoria.LstCategoria();

            this.cboCategoria.DataSource = lista;
            this.cboCategoria.DataTextField = "descripcion";
            this.cboCategoria.DataValueField = "categoriaid";
            this.cboCategoria.DataBind();
            this.cboCategoria.Items.Insert(0, new ListItem("Seleccionar", "-1"));
            this.cboCategoria.SelectedIndex = 0;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<EventoBE> lista = new List<EventoBE>();
            DateTime fecha;

            int categoriaid = Convert.ToInt32(string.IsNullOrEmpty(cboCategoria.SelectedValue) ? "-1" : cboCategoria.SelectedValue);

            if (txtFechaInicio.Text == "")
            {
                 fecha = Convert.ToDateTime("10/10/1900");
            }
            else
            {
                 fecha = Convert.ToDateTime(txtFechaInicio.Text);

            }
            

            lista = iEvento.LstEvento("", txtDescripcion.Text, categoriaid, fecha);
            /*gEvento.DataSource = lista;
            gEvento.DataBind();*/

            dtlEvents.DataSource = lista;
            dtlEvents.DataBind();
        }

        

        
    }
}