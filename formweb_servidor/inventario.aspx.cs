using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace formweb_servidor
{
    public partial class inventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string p1;
            if (!IsPostBack)
            {
                if (Request.Params != null && Request.Params[0] != null)
                {
                    p1 = Request.Params[0].ToString();
                    Response.Write(p1);
                }
            }
        }
    }
}