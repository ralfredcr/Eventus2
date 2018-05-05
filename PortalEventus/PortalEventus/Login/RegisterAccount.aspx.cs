using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BP_Eventus;
using BE_Eventus;
using System.Net.Mail;
using System.Text;

namespace PortalEventus.Registro
{
    public partial class RegisterAccount : System.Web.UI.Page
    {
        MailMessage mail = new MailMessage();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //this.tipoDocumentoListar();   
                //trPais.Visible = trDepartamento.Visible = trProvincia.Visible = false;
                //this.paisListar();
                //this.departamentoListar();
                //this.provinciaListar(ddlDepartamento.SelectedValue.ToString());
                //this.distritoListar(ddlDepartamento.SelectedValue.ToString(), ddlProvincia.SelectedValue.ToString());
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
        //private void paisListar()
        //{
        //    PersonaBL objPersona = new PersonaBL();
        //    try
        //    {
        //        ddlPais.DataSource = objPersona.paisListar();
        //        ddlPais.DataValueField = "codigoPais";
        //        ddlPais.DataTextField = "nombrePais";
        //        ddlPais.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //        this.mensajeMostrar(ex.Message.ToString());
        //        throw;
        //    }
        //}
        //private void departamentoListar()
        //{
        //    PersonaBL objPersona = new PersonaBL();
        //    try
        //    {
        //        ddlDepartamento.DataSource = objPersona.departamentoListar();
        //        ddlDepartamento.DataValueField = "codigoDepartamento";
        //        ddlDepartamento.DataTextField = "nombreDepartamento";
        //        ddlDepartamento.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //        this.mensajeMostrar(ex.Message.ToString());
        //        throw;
        //    }
        //}

        //private void provinciaListar(String codDepartamento)
        //{
        //    PersonaBL objPersona = new PersonaBL();
        //    try
        //    {
        //        ddlProvincia.DataSource = objPersona.provinciaListar(codDepartamento);
        //        ddlProvincia.DataValueField = "codigoProvincia";
        //        ddlProvincia.DataTextField = "nombreProvincia";
        //        ddlProvincia.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //        this.mensajeMostrar(ex.Message.ToString());
        //        throw;
        //    }
        //}
        //private void distritoListar(String codDepartamento, String codProvincia)
        //{
        //    PersonaBL objPersona = new PersonaBL();
        //    try
        //    {
        //        ddlDistrito.DataSource = objPersona.distritoListar(codDepartamento, codProvincia);
        //        ddlDistrito.DataValueField = "codigoDistrito";
        //        ddlDistrito.DataTextField = "nombreDistrito";
        //        ddlDistrito.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //        this.mensajeMostrar(ex.Message.ToString());
        //        throw;
        //    }
        //}
        private Boolean validarCampos()
        {
            Boolean resultado = false;
            if (txtUsuario.Text.Replace(" ", "") == null || txtUsuario.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Ingrese nombre de usuario");
            }
            else if (txtNombre.Text.Replace(" ", "") == null || txtNombre.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Ingrese nombres.");
            }
            else if (txtApeparterno.Text.Replace(" ", "") == null || txtApeparterno.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Ingrese apellido paterno.");
            }
            //else if (txtApeMaterno.Text.Replace(" ", "") == null || txtApeMaterno.Text == "")
            //{
            //    resultado = false;
            //    this.mensajeMostrar("Ingrese apellido materno.");
            //}
            else if (txtContrasena.Text.Replace(" ", "") == null || txtContrasena.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Ingrese contrasena.");
            }
            else if (txtContrasena2.Text.Replace(" ", "") == null || txtContrasena2.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Confirme la contrasdena.");
            }
            else if (rbSexo.SelectedIndex < 0)
            {
                resultado = false;
                this.mensajeMostrar("Seleccione su sexo.");
            }
            else if (rbNacionalidad.SelectedIndex < 0)
            {
                resultado = false;
                this.mensajeMostrar("Seleccione nacionalidad.");
            }
            else if (txtNumeroDoc.Text.Replace(" ", "") == null || txtNumeroDoc.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Ingrese numero de documento.");
            }
            else if (txtFechaNacimiento.Text.Replace(" ", "") == null || txtFechaNacimiento.Text == "")
            {
                resultado = false;
                this.mensajeMostrar("Ingrese fecha nacimiento.");
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }
        private Boolean usuarioExisteValidar(String usuario)
        {
            PersonaBL objPersona = new PersonaBL();
            return objPersona.usuarioExisteValidar(usuario);
        }
        private Boolean documentoExisteValidar(String documento)
        {
            PersonaBL objPersona = new PersonaBL();
            return objPersona.documentoExisteValidar(documento);
        }

        private Boolean usuarioRegistrar()
        {
            try
            {
                Boolean resultado = false;
                String usuario = txtUsuario.Text;
                String documento = txtNumeroDoc.Text;
                if (this.usuarioExisteValidar(usuario))
                {
                    this.mensajeMostrar("Nombre de usuario no disponible");
                }
                else if (this.documentoExisteValidar(documento))
                {
                    this.mensajeMostrar("Nro. documento ya está registrado.");
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
                    obj.fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                    obj.telefono = null;// txtTelefono.Text;
                    obj.celular = null;// txtCelular.Text;
                    obj.direccion = null;// txtDireccion.Text;
                    obj.tipoDocumento = Convert.ToInt16(ddlTipoDocumento.SelectedValue.ToString());
                    obj.sexo = Convert.ToInt16(rbSexo.SelectedItem.Value.ToString());
                    obj.nacionalidad = Convert.ToInt16(rbNacionalidad.SelectedItem.Value.ToString());
                    obj.pais = null;// ddlPais.Text;
                    obj.ciudad = null;// txtCiudad.Text;
                    obj.codDepartamento = null;// ddlDepartamento.SelectedValue.ToString();
                    obj.codProvincia = null;// ddlProvincia.SelectedValue.ToString();
                    obj.codDistrito = null;// ddlDistrito.SelectedValue.ToString();

                    resultado = objPersona.usuarioRegistrar(obj);
                }
                return resultado;

                



            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
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
            //String codigoDep = ddlDepartamento.SelectedValue.ToString();
            //String codigoProv = ddlProvincia.SelectedValue.ToString();
            //this.provinciaListar(codigoDep);
            //this.distritoListar(codigoDep, codigoProv);

        }
        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String codigoDep = ddlDepartamento.SelectedValue.ToString();
            //String codigoProv = ddlProvincia.SelectedValue.ToString();
            //this.distritoListar(codigoDep, codigoProv);
        }
        protected void rbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trDepartamento.Visible = trProvincia.Visible = rbNacionalidad.SelectedItem.Value == "1" ? true : false;
            //if (rbNacionalidad.SelectedItem.Value.ToString() == "1")
            //{
            //    ddlPais.SelectedValue = "9589";
            //    trPais.Visible = false;
            //}
            //else
            //{
            //    trPais.Visible = true;
            //}            
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validarCampos())
                {
                    if (contrasenaValidar())
                    {
                        if (this.usuarioRegistrar())
                        {
                            Session["sUsuario"] = txtUsuario.Text.Replace(" ", "");

                            // Enviar Correo
                            SmtpClient SmtpServer = new SmtpClient();
                            SmtpServer.Credentials = new System.Net.NetworkCredential
                                        ("EventoInformativo@gmail.com", "P@ssword100");
                            SmtpServer.Port = 587;
                            SmtpServer.Host = "smtp.gmail.com";
                            SmtpServer.EnableSsl = true;
                            mail = new MailMessage();
                            String[] addr = txtCorreo.Text.Split(',');

                            try
                            {
                                var body = new StringBuilder();
                                body.AppendFormat("Hola, {0}\n", txtNombre.Text + ' ' + txtApeparterno.Text);
                                body.AppendLine(@"Su cuenta de EVENTOS a punto de activar haga clic en el siguiente enlace para completar el proceso de activación");
                                body.AppendLine("<br/>");
                                body.AppendLine("<a href=\"http://localhost:50228/ValidarUsuario.aspx?usuario=" + txtUsuario.Text + "\">login</a>");
                                
                                mail.From = new MailAddress("EventoInformativo@gmail.com", "Developers", System.Text.Encoding.UTF8);
                                Byte i;
                                for (i = 0; i < addr.Length; i++)
                                    mail.To.Add(addr[i]);
                                mail.Subject = "Confirmar Usuario";
                                mail.Body = body.ToString();
                                mail.IsBodyHtml = true;

                                SmtpServer.Send(mail);

                            }
                            catch (Exception)
                            {

                                throw;
                            }


                            this.mensajeMostrar("Enviamos un codigo de validacion a tu correo electronico, ingresalo para activar tu cuenta.");
                            Response.Redirect("~/Index.aspx");
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
            }
            catch (Exception ex)
            {
                this.mensajeMostrar(ex.Message.ToString());
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Index.aspx");
        }

        //protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ddlDepartamento.Enabled = ddlProvincia.Enabled = ddlDistrito.Enabled = ddlPais.SelectedItem.Value == "9589" ? true : false;
        //}
    }
}