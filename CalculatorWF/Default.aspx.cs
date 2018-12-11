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

    public struct struSiteVariables
    {
        public string sHiba;
        public string sCalcID;

        public struRendfej rFej;
        [XmlIgnoreAttribute]
        public struCeg rCeg;
        [XmlIgnoreAttribute]
        public struUser rUser;

        [XmlIgnoreAttribute]
        public sbyte nTab;
        [XmlIgnoreAttribute]
        public sbyte nFocus;
        public struRendszer rRendszer;
        public struTetel[] rBontas;

        [XmlIgnoreAttribute]
        public double nErtek;

        [XmlIgnoreAttribute]
        public string sRendelesLap;

        [XmlIgnoreAttribute]
        public bool bRendelesOK;

        [XmlIgnoreAttribute]
        public string sMessage;
        [XmlIgnoreAttribute]
        public string sMegjegyzes;

        public struSiteVariables(struSiteVariables rSV)
        {
            this.sHiba = rSV.sHiba;
            this.sCalcID = rSV.sCalcID;
            this.rFej = rSV.rFej;
            this.rCeg = rSV.rCeg;
            this.rUser = rSV.rUser;
            this.nTab = rSV.nTab;
            this.nFocus = rSV.nFocus;
            this.rRendszer = rSV.rRendszer;

            this.rBontas = new struTetel[rSV.rBontas.Length];
            rSV.rBontas.CopyTo(this.rBontas, 0);

            this.nErtek = rSV.nErtek;
            this.sRendelesLap = rSV.sRendelesLap;
            this.bRendelesOK = rSV.bRendelesOK;
            this.sMessage = rSV.sMessage;
            this.sMegjegyzes = rSV.sMegjegyzes;

        }
    }

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}