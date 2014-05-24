using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclameAqui.WEB
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["AccessToken"] == null)
            //{
            //    Session["AccessToken"] = "isPostBack";
            //    //String adress = "https%3A%2F%2Fwww.decidipassar.com.br/game&scope=user_friends"; // Uncomment on deploy
            //    String adress = "https%3A%2F%2Flocalhost:49929"; // Comment on deploy
            //    Response.Redirect("https://www.facebook.com/dialog/oauth/?client_id=314407772044158&redirect_uri=" + adress, false);
            //}

            ////"search?q=detran&type=page"

            //if (Session["AccessToken"].ToString() == "isPostBack")
            //{
            //    Page.ClientScript.RegisterClientScriptInclude("auth", "Scripts/Auth.js");
            //}
        }
    }
}
