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
            EventoBE obj = new EventoBE();
            obj.titulo = txtTitulo.Text;
            obj.descripcion = txtDescripcion.Text;
            obj.descripcionAdicional = txtDescripcionAdicional.Text;
            obj.categoriaid = Convert.ToInt32(string.IsNullOrEmpty(cboCategoria.SelectedValue) ? "-1" : cboCategoria.SelectedValue);
            obj.fechaInicio = dtFechaInicio.SelectedDate;
            obj.fechaFin = dtFechaFin.SelectedDate;

            int resultado;
            resultado = iEvento.InsertEvento(obj);


        }

        public void CargarCategoria()
        {
            CategoriaBE obj = new CategoriaBE();
            List<CategoriaBE> lista = iCategoria.LstCategoria();

            this.cboCategoria.DataSource = lista;
            this.cboCategoria.DataTextField = "descripcion";
            this.cboCategoria.DataValueField = "categoriaid";
            this.cboCategoria.DataBind();

        }
    }
}