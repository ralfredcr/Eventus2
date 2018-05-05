using BE_Eventus;
using BP_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus.Login
{
    public partial class Login : System.Web.UI.Page
    {
        bool val = false;
        PersonaBL iPersonaBL = new PersonaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertStyles(val);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            panalert.Style.Add("height", "0px;");

            Persona obj = new Persona();
            obj = iPersonaBL.Login(txtUsuario.Text, txtContrasena.Text);

            if (obj == null)
            {
                lblError.Text = "Usuario o Contraseña Incorrecta";
            }
            else
            {
                if (obj.usuarioid != 0)
                {
                    LimpiarSesion();
                    IniciarSession(obj);

                    Response.Redirect("~/Index.aspx");
                }
                else
                {
                    lblError.Text = "Usuario o Contraseña Incorrecta";
                }
            }


        }

        private void AlertStyles(bool val)
        {
            if (val)
            {
                panalert.Style.Add("height", "0px;");
            }
            else
            {
                panalert.Style.Add("height", "0px;");
            }
        }

        private void LimpiarSesion()
        {
            Session.Remove(NombreSesiones.usuarioid);
            Session.Remove(NombreSesiones.nombreUsuario);
            Session.Remove(NombreSesiones.nombrePersona);
            Session.Remove(NombreSesiones.apePaterno);
            Session.Remove(NombreSesiones.PerfilId);
            Session.Remove(NombreSesiones.DescPerfil);

        }

        private void IniciarSession(Persona user)
        {

            Session[NombreSesiones.usuarioid] = user.usuarioid;
            Session[NombreSesiones.nombreUsuario] = user.nombreUsuario;
            Session[NombreSesiones.nombrePersona] = user.nombrePersona;
            Session[NombreSesiones.apePaterno] = user.apePaterno;
            Session[NombreSesiones.PerfilId] = user.PerfilId;
            Session[NombreSesiones.DescPerfil] = user.DescPerfil;
            //Session.Add("URLServidor", Request.ServerVariables["HTTP_HOST"] + Request.ApplicationPath);
        }


    }
}