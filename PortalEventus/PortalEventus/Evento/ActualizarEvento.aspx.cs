using BE_Eventus;
using BP_Eventus;
using System;
using System.Collections.Generic;
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

        static byte[] bytesGlob;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategoria();
                CargarEvento();
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
            
            obj.fechaInicio = dtFechaInicio.SelectedDate;
            obj.fechaFin = dtFechaFin.SelectedDate;
            obj.estado = 1;
            obj.usuarioCreacion = -1;
            obj.usuarioActualiza = -1;

            int resultado;
            resultado = iEvento.UpdateEvento(obj);

            if (resultado == 1)
            {
                CargarCategoria();
                CargarEvento();
            }
        }

        public void CargarCategoria()
        {
            CategoriaBE obj = new CategoriaBE();
            List<CategoriaBE> lista = new List<CategoriaBE>();
            obj.categoriaid = -1;
            obj.descripcion = "Seleccionar";

            lista = iCategoria.LstCategoria();
            lista.Add(obj);

            this.cboCategoria.DataSource = lista;
            this.cboCategoria.DataTextField = "descripcion";
            this.cboCategoria.DataValueField = "categoriaid";
            this.cboCategoria.DataBind();

        }

        public void CargarEvento()
        {
            EventoBE obj = new EventoBE();
            obj = iEvento.ObtenerEvento(1);

            txtTitulo.Text = obj.titulo;
            txtDescripcion.Text = obj.descripcionEvento;
            txtDescripcionAdicional.Text = obj.descripcionAdicional;
            cboCategoria.SelectedValue = obj.categoriaid.ToString();
            dtFechaInicio.SelectedDate = obj.fechaInicio;
            dtFechaFin.SelectedDate = obj.fechaFin;

            if (obj.RutaImagen != null)
            {
                byte[] bytes = obj.RutaImagen;
                bytesGlob = bytes;
                string imag = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/jpeg;base64," + imag;

            }
            
        }

    }
}