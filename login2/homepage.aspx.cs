using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login2
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("loginpage.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Server.Transfer("registration.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Server.Transfer("CreateNewAccount.aspx");
        }
    }
}