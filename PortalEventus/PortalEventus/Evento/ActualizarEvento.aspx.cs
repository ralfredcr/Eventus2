using BE_Eventus;
using BP_Eventus;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus.Evento
{
    public partial class ActualizarEvento : System.Web.UI.Page
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

        CategoriaBL iCategoria = new CategoriaBL();
        EventoBL iEvento = new EventoBL();
        ZonaEventoBL iZonaEvento = new ZonaEventoBL();

        static byte[] bytesGlob;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategoria();
                CargarEvento();
                CargarZona();
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            // Read the file and convert it to Byte Array
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;

            //string filePath = FileUpload1.PostedFile.FileName;
            //string filename2 = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename);
            string contenttype = String.Empty;

            //Set the contenttype based on File Extension
            switch (ext)

            {
                case ".jpg":
                    contenttype = "image/jpg";
                    break;
                case ".png":
                    contenttype = "image/png";
                    break;
                case ".gif":
                    contenttype = "image/gif";
                    break;
            }

            Stream fs = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);

            EventoBE obj = new EventoBE();
            obj.eventoid = 1;
            obj.titulo = txtTitulo.Text;
            obj.descripcion = txtDescripcion.Text;
            obj.descripcionAdicional = txtDescripcionAdicional.Text;
            obj.categoriaid = Convert.ToInt32(string.IsNullOrEmpty(cboCategoria.SelectedValue) ? "-1" : cboCategoria.SelectedValue);
            if (bytes.Length>0)
            {
                obj.RutaImagen = bytes;
            }
            else
            {
                obj.RutaImagen = bytesGlob;
            }
            
            obj.fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            obj.fechaFin = Convert.ToDateTime(txtFechaFin.Text);
            obj.estado = 1;
            obj.usuarioCreacion = -1;
            obj.usuarioActualiza = -1;

            int resultado;
            resultado = iEvento.UpdateEvento(obj);


            if (resultado == 1)
            {
                iZonaEvento.DeleteEventoZona(1);

                foreach (GridViewRow row in gZona.Rows)
                {
                    TextBox vzona = (TextBox)row.FindControl("txtZona");
                    TextBox vprecio = (TextBox)row.FindControl("txtPrecio");
                    TextBox vcantidad = (TextBox)row.FindControl("txtCantidad");

                    if (vzona.Text != "" && vprecio.Text != "" && vcantidad.Text != "")
                    {
                        ZonaEventoBE obj2 = new ZonaEventoBE();
                        obj2.eventoid = resultado;
                        obj2.zona = vzona.Text;
                        obj2.precio = Convert.ToDecimal(vprecio.Text);
                        obj2.cantidadMax = Convert.ToInt32(vcantidad.Text);

                        iZonaEvento.UpdateEventoZona(obj2);
                    }

                }

                Response.Redirect("Evento/ListarEvento.aspx?descripcionAdicional=" + "");
                //CargarCategoria();
                //CargarEvento();
                //CargarZona();


            }


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

        }

        public void CargarEvento()
        {
            EventoBE obj = new EventoBE();
            obj = iEvento.ObtenerEvento(eventoid);

            txtTitulo.Text = obj.titulo;
            txtDescripcion.Text = obj.descripcionEvento;
            txtDescripcionAdicional.Text = obj.descripcionAdicional;
            cboCategoria.SelectedValue = obj.categoriaid.ToString();
            txtFechaInicio.Text = obj.fechaInicio.ToString("yyyy-MM-ddTHH:mm");
            txtFechaFin.Text = obj.fechaFin.ToString("yyyy-MM-ddTHH:mm");

            if (obj.RutaImagen != null)
            {
                byte[] bytes = obj.RutaImagen;
                bytesGlob = bytes;
                string imag = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/jpeg;base64," + imag;

            }
            
        }

        public void CargarZona()
        {
            List<ZonaEventoBE> lista = new List<ZonaEventoBE>();

            lista = iZonaEvento.ObtenerEventoZona(1);

            if (lista.Count < 5)
            {

                for (int i = lista.Count; i < 5; i++)
                {
                    ZonaEventoBE obj = new ZonaEventoBE();
                    obj.num = i + 1;
                    lista.Add(obj);
                }
            }

            gZona.DataSource = lista;
            gZona.DataBind();



        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evento/ListarEvento.aspx?descripcionAdicional=" + "");
        }
    }
}