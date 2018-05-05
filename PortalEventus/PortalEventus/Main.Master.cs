using BE_Eventus;
using BP_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEventus
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session[NombreSesiones.PerfilId] == null)
                {
                    
                }
                else
                {
                    int perfil = Convert.ToInt32(Session[NombreSesiones.PerfilId]);
                    CargarMenu(perfil);
                }


                    
            }
                
        }
        

        private void CargarMenu(int perfil)
        {
            List<OpcionBE> lista = new List<OpcionBE>();
            lista = new OpcionBL().AccesoPerfil(perfil);

            //RECORREMOS LA LISTA PARA AGREGAR LOS ELEMENTOS QUE ESTARÁN EN LA CABECERA DEL MENÚ
            foreach (var item in lista)
            {
                // SI ES UNA OPCIÓN PADRE
                if (item.OpcionesId == Convert.ToInt32(item.PadreId))
                {
                    // ITEM QUE SE AGREGA AL MENU
                    MenuItem mnuMenuItem = new MenuItem();
                    mnuMenuItem.Value = item.OpcionesId.ToString();
                    mnuMenuItem.Text = item.DescOpciones;
                    mnuMenuItem.NavigateUrl = item.URL;
                    mnuMenuItem.ImageUrl = item.Icono;

                    //AGREGAMOS EL ITEM AL MENÚ
                    Menu1.Items.Add(mnuMenuItem);

                    //AHORA MANDAMOS OTRO METODO, LO QUE HARA ES RECORRER NUEVAMENTE LA LISTA PARA VER CUALES SON SUS HIJO
                    //Y ASI PODER AGREGARLOS COMO SUBITEMS
                    //addSubItemMenu(mnuMenuItem, lista);

                }
            }

        }

        //static void addSubItemMenu(MenuItem mnuMenuItem, List<OpcionBE> lista)
        //{
        //    foreach (var item in lista)
        //    {

        //        //QUIERE DECIR QUE ES HIJO, SE HACE UNA CONDICIONAL NEGATIVO PARA EVITAR AL MISMO NODE PADRE
        //        if (item.PadreId.ToString().Equals(mnuMenuItem.Value) && !item.OpcionesId.ToString().Equals(mnuMenuItem.Value))
        //        {
        //            // ITEM QUE SE AGREGA AL SUB MENU
        //            MenuItem mnuHijoMenuItem = new MenuItem();
        //            MenuItem ParentItem = mnuMenuItem;

        //            mnuHijoMenuItem.Value = item.OpcionesId.ToString();
        //            mnuHijoMenuItem.Text = item.DescOpciones;
        //            mnuHijoMenuItem.NavigateUrl = item.URL;

        //            //AGREGAMOS EL ITEM AL MENÚ
        //            ParentItem.ChildItems.Add(mnuHijoMenuItem);

        //            //AQUI SE PODRIA LLAMAR AL METODO ADDSUBITEMMENU NUEVAMENTE, PARA VERIFICAR SI ESTE ESTE MENU HIJO TIENE MENU HIJOS
        //            //addSubItemMenu2(mnuHijoMenuItem, lstAcceso);

        //        }

        //    }

        //}

        protected void lknIniciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login/Login.aspx");
        }

        protected void lknRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login/RegisterAccount.aspx");
        }
    }
}