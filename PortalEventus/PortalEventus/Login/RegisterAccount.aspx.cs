using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BP_Eventus;

namespace PortalEventus.Registro
{
    public partial class RegisterAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.paisListar();
                this.departamentoListar();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        #region Proc
        public void mensajeMostrar(string msg)
        {
            string mensaje = "<script type='text/javascript'>alert('{0}')</script>";

            mensaje = string.Format(mensaje, msg);
            ScriptManager.RegisterStartupScript(this, null, "msgBox", mensaje, true);

        }
        private void paisListar()
        {
            PersonaBL objPersona = new PersonaBL();
            try
            {
                ddlPais.DataSource = objPersona.paisListar();
                ddlPais.DataValueField = "codigoPais";
                ddlPais.DataValueField = "nombrePais";
                ddlPais.DataBind();
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
                throw;
            }
        }
        private void departamentoListar()
        {
            PersonaBL objPersona = new PersonaBL();
            try
            {
                ddlDepartamento.DataSource = objPersona.departamentoListar();
                ddlDepartamento.DataValueField = "codigoDepartamento";
                ddlDepartamento.DataValueField = "nombreDepartamento";
                ddlDepartamento.DataBind();
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
                throw;
            }
        }

        private void provinciaListar(String codDepartamento)
        {
            PersonaBL objPersona = new PersonaBL();
            try
            {
                ddlProvincia.DataSource = objPersona.provinciaListar(codDepartamento);
                ddlProvincia.DataValueField = "codigoProvincia";
                ddlProvincia.DataValueField = "nombreProvincia";
                ddlProvincia.DataBind();
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
                throw;
            }
        }

        #endregion

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String codigoDep = ddlDepartamento.DataValueField;
            this.provinciaListar(codigoDep);
           
        }

        protected void rbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (rbNacionalidad.SelectedIndex > -1)
            //{
                ddlDepartamento.Enabled = ddlProvincia.Enabled = ddlDistrito.Enabled = rbNacionalidad.SelectedItem.Value == "1" ? true : false;
            //}
        }
    }
}