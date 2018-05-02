﻿using BE_Eventus;
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
    public partial class RegistrarEvento : System.Web.UI.Page
    {
        CategoriaBL iCategoria = new CategoriaBL();
        EventoBL iEvento = new EventoBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategoria();
                

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
            obj.titulo = txtTitulo.Text;
            obj.descripcion = txtDescripcion.Text;
            obj.descripcionAdicional = txtDescripcionAdicional.Text;
            obj.categoriaid = Convert.ToInt32(string.IsNullOrEmpty(cboCategoria.SelectedValue) ? "-1" : cboCategoria.SelectedValue);
            obj.RutaImagen = bytes;
            obj.fechaInicio = dtFechaInicio.SelectedDate;
            obj.fechaFin = dtFechaFin.SelectedDate;
            obj.estado = 1;
            obj.usuarioCreacion = -1;
            obj.usuarioActualiza = -1;

            int resultado;
            resultado = iEvento.InsertEvento(obj);


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
    }
}