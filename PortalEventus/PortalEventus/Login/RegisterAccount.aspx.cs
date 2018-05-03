using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BP_Eventus;
using BE_Eventus;

namespace PortalEventus.Registro
{
    public partial class RegisterAccount : System.Web.UI.Page
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
        public void mensajeMostrar(string msg)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('" + msg + "')", true);
        }

        private void tipoDocumentoListar()
        {
            PersonaBL objPersona = new PersonaBL();
            try
            {
                ddlTipoDocumento.DataSource = objPersona.tipoDocListar();
                ddlTipoDocumento.DataValueField = "codiDocumento";
                ddlTipoDocumento.DataTextField = "descripcion";
                ddlTipoDocumento.DataBind();
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
                throw;
            }
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

        private Boolean usuarioExisteValidar(String usuario)
        {
            PersonaBL objPersona = new PersonaBL();
            return objPersona.usuarioExisteValidar(usuario);
        }

        private Boolean usuarioRegistrar()
        {
            try
            {
                Boolean resultado = false;
                String usuario = txtUsuario.Text;
                if (this.usuarioExisteValidar(usuario))
                {
                    this.mensajeMostrar("Nombre de usuario no disponible");
                }
                else
                {
                    PersonaBL objPersona = new PersonaBL();
                    Persona obj = new Persona();
                    obj.nombrePersona = txtNombre.Text;
                    obj.apePaterno = txtApeparterno.Text;
                    obj.apeMaterno = txtApeMaterno.Text;
                    obj.nombreUsuario = txtUsuario.Text;
                    obj.correo = txtCorreo.Text;
                    obj.contrasena = txtContrasena.Text;
                    obj.nroDocumento = txtNumeroDoc.Text;
                    obj.fechaNacimiento = txtFechaNacimiento.Text;
                    obj.telefono = txtTelefono.Text;
                    obj.celular = txtCelular.Text;
                    obj.direccion = txtDireccion.Text;
                    obj.tipoDocumento = Convert.ToInt16(ddlTipoDocumento.SelectedValue.ToString());
                    obj.sexo = Convert.ToInt16(rbSexo.SelectedItem.Value.ToString());
                    obj.nacionalidad = Convert.ToInt16(rbNacionalidad.SelectedItem.Value.ToString());
                    obj.pais = ddlPais.Text;
                    obj.ciudad = txtCiudad.Text;
                    obj.codDepartamento = ddlDepartamento.SelectedValue.ToString();
                    obj.codProvincia = ddlProvincia.SelectedValue.ToString();
                    obj.codDistrito = ddlDistrito.SelectedValue.ToString();

                    resultado = objPersona.usuarioRegistrar(obj);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private Boolean contrasenaValidar()
        {
            return txtContrasena.Text == txtContrasena2.Text ? true : false;
        }
        #endregion

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String codigoDep = ddlDepartamento.SelectedValue.ToString();
            String codigoProv = ddlProvincia.SelectedValue.ToString();
            this.provinciaListar(codigoDep);
            this.distritoListar(codigoDep, codigoProv);

        }
        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            String codigoDep = ddlDepartamento.SelectedValue.ToString();
            String codigoProv = ddlProvincia.SelectedValue.ToString();
            this.distritoListar(codigoDep, codigoProv);
        }
        protected void rbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ddlDepartamento.Enabled = ddlProvincia.Enabled = ddlDistrito.Enabled = rbNacionalidad.SelectedItem.Value == "1" ? true : false;
            trDepartamento.Visible = trProvincia.Visible = rbNacionalidad.SelectedItem.Value == "1" ? true : false;
            if (rbNacionalidad.SelectedItem.Value.ToString() == "1")
            {
                ddlPais.SelectedValue = "9589";
                //ddlPais.Enabled = false;
                trPais.Visible = false;
            }
            else
            {
                trPais.Visible = true;
                //ddlPais.Enabled = true;
            }            
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (contrasenaValidar())
                {
                    if (this.usuarioRegistrar())
                    {
                        this.mensajeMostrar("Enviamos un codigo de validacion a tu correo electronico, ingresalo para activar tu cuenta.");
                    }
                    else
                    {
                        this.mensajeMostrar("Error");
                    }
                }
                else
                {
                    this.mensajeMostrar("Las contrase;as no coinciden");
                }
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
            }
        }

        protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDepartamento.Enabled = ddlProvincia.Enabled = ddlDistrito.Enabled = ddlPais.SelectedItem.Value == "9589" ? true : false;
        }
    }
}