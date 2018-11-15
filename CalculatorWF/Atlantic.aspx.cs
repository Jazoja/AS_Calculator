using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWF
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            { }
            else
            {
                ddlSystems.Items.Add("");
                ddlSystems.Items.Add("Tolóajtó");
                ddlSystems.Items.Add("Falban futó tolóajtó");
                ddlSystems.Items.Add("Nyíló ajtó - Csak ajtó normál szárny");
                ddlSystems.Items.Add("Nyíló ajtó - Csak ajtó fix szárny");
                ddlSystems.Items.Add("Screen");
                ddlSystems.Items.Add("Nyíló ajtó aluminium tok 100-125");
                ddlSystems.Items.Add("Nyíló ajtó aluminium tok 125 -");

                ddlBeepitesiMod.Items.Add("");
                ddlBeepitesiMod.Items.Add("P1");
                ddlBeepitesiMod.Items.Add("F1");
                ddlBeepitesiMod.Items.Add("P2");

            }




        }
    }
}