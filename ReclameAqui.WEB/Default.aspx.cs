using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclameAqui.WEB
{
    public partial class _Default : System.Web.UI.Page
    {
        String[] UFS = {"AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"};

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlEstado.DataSource = UFS;
            ddlEstado.DataBind();
        }
    }
}
