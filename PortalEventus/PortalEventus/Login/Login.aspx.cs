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
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertStyles(val);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            panalert.Style.Add("height", "0px;");
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


    }
}