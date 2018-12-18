using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace CalculatorWF
{
    public struct struUser
    {
        public int nUserKey;
        public string sLoginName,
                      sPassword,
                      sFullName,
                      sPhone,
                      sFax,
                      sEmail;
        public string sLang;
        public string sKod;
        public string sAuthLevel;
    }

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string serverMapPath = Server.MapPath(".");
            Common.Init(serverMapPath);
            
            struSiteVariables rSV = new struSiteVariables("default");
            Vars.SiteVars = rSV;
        }
    }
}