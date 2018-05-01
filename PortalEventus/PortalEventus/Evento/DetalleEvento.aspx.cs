﻿using BE_Eventus;
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
            }
        }

        public void CargarEvento()
        {
            EventoBE obj = new EventoBE();
            obj = iEvento.ObtenerEvento(1);

            txtTitulo.Text = obj.titulo;
            txtDescripcion.Text = obj.descripcionEvento;
            txtDescripcionAdicional.Text = obj.descripcionAdicional;
            txtCategoria.Text = obj.descripcionCateg;
            dtFechaInicio.SelectedDate = obj.fechaInicio;
            dtFechaFin.SelectedDate = obj.fechaFin;

            if (obj.RutaImagen != null)
            {
                byte[] bytes = obj.RutaImagen;
                string imag = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/jpeg;base64," + imag;

            }

        }
    }
}