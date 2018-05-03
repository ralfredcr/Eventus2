using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BP_Eventus;
using BE_Eventus;

namespace PortalEventus
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //this.tipoDocumentoListar();   
                trPais.Visible = trDepartamento.Visible = trProvincia.Visible = false;
                this.paisListar();
                this.departamentoListar();
                this.provinciaListar(ddlDepartamento.SelectedValue.ToString());
                this.distritoListar(ddlDepartamento.SelectedValue.ToString(), ddlProvincia.SelectedValue.ToString());
            }
        }
        #region Proc
        private void usuarioConsultar(String usuario)
        {
            try
            {
                List<Persona> listaPersona = new List<Persona>();
                PersonaBL objPersona = new PersonaBL();
                listaPersona = objPersona.usuarioConsultar("graziellavl");
                foreach (var item in listaPersona)
                {
                    lblUsuario.Text = item.nombreUsuario;
                    txtNombres.Text = item.nombrePersona;
                    txtApeparterno.Text = item.apeMaterno;
                    txtApeMaterno.Text = item.apeMaterno;
                    lblContrasena.Text = item.contrasena;
                    txtCorreo.Text = item.correo;
                    rbSexo.SelectedValue = item.sexo.ToString();
                    rbNacionalidad.SelectedValue = item.nacionalidad.ToString();
                    ddlTipoDocumento.SelectedValue = item.tipoDocumento.ToString();
                    txtNumeroDoc.Text = item.nroDocumento;
                    txtTelefono.Text = item.telefono;
                    txtCelular.Text = item.celular;
                    txtFechaNacimiento.Text = item.fechaNacimiento;
                    txtCiudad.Text = item.ciudad;
                    txtDireccion.Text = item.direccion;
                }
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
            }
        }
        public void mensajeMostrar(string msg)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('" + msg + "')", true);
        }
        private void paisListar()
        {
            PersonaBL objPersona = new PersonaBL();
            try
            {
                ddlPais.DataSource = objPersona.paisListar();
                ddlPais.DataValueField = "codigoPais";
                ddlPais.DataTextField = "nombrePais";
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
                ddlDepartamento.DataTextField = "nombreDepartamento";
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
                ddlProvincia.DataTextField = "nombreProvincia";
                ddlProvincia.DataBind();
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
                throw;
            }
        }
        private void distritoListar(String codDepartamento, String codProvincia)
        {
            PersonaBL objPersona = new PersonaBL();
            try
            {
                ddlDistrito.DataSource = objPersona.distritoListar(codDepartamento, codProvincia);
                ddlDistrito.DataValueField = "codigoDistrito";
                ddlDistrito.DataTextField = "nombreDistrito";
                ddlDistrito.DataBind();
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
                throw;
            }
        }
        #endregion
}
}