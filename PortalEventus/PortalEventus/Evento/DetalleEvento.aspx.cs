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
    public partial class DetalleEvento : System.Web.UI.Page
    {
        public int eventoid
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["eventoid"]))
                {
                    return int.Parse(Request.QueryString["eventoid"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        EventoBL iEvento = new EventoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEvento();

                if (Session[NombreSesiones.PerfilId] == null)
                {
                    btnReservar.Visible = false;
                    btnActualizar.Visible = false;
                }
                else
                {
                    int perfil = Convert.ToInt32(Session[NombreSesiones.PerfilId]);

                    if (perfil == 1)
                    {
                        btnReservar.Visible = false;
                        btnActualizar.Visible = true;
                    }
                    else
                    {
                        btnReservar.Visible = true;
                        btnActualizar.Visible = false;
                    }
                }

            }
        }

        public void CargarEvento()
        {
            EventoBE obj = new EventoBE();
            obj = iEvento.ObtenerEvento(1);

            txtTitulo.Text = obj.titulo;
            txtDescripcion.Text = obj.descripcionEvento;
            txtCategoria.Text = obj.descripcionCateg;
            txtFechaInicio.Text = obj.fechaInicio.ToString("yyyy-MM-ddTHH:mm");
            txtFechaFin.Text = obj.fechaFin.ToString("yyyy-MM-ddTHH:mm");

            if (obj.RutaImagen != null)
            {
                byte[] bytes = obj.RutaImagen;
                string imag = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/jpeg;base64," + imag;

            }

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            /*Response.Redirect("Evento/ListarEvento.aspx?descripcionAdicional=" + "");*/
            Response.Redirect("ListarEvento.aspx?descripcionAdicional=" + "");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evento/ActualizarEvento.aspx?eventoid=" + eventoid);
        }
    }
}