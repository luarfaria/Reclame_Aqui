using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclameAqui.WEB
{
    /// <summary>
    /// Summary description for FacebookLogin
    /// </summary>
    public class FacebookLogin : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            var accessToken = context.Request["accessToken"];
            String[] parameters = accessToken.Split('|');
            context.Session["AccessToken"] = parameters[0];
            context.Session["UID"] = parameters[1];
            context.Response.Redirect("~/Default.aspx");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}