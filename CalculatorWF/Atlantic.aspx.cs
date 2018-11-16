using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Collections.Specialized;


namespace CalculatorWF
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            { 
            
            }
            else
            {
                
                NameValueCollection nvcRendszerTipusok = new NameValueCollection();
                nvcRendszerTipusok[""] = "";
                nvcRendszerTipusok["slide_out"] = "Tolóajtó";
                nvcRendszerTipusok["slide_in"] = "Falban futó tolóajtó";
                nvcRendszerTipusok["swing_slim"] = "Nyíló ajtó aluminium tok 100-125";
                nvcRendszerTipusok["swing_thin"] = "Nyíló ajtó aluminium tok 125 -";
                nvcRendszerTipusok["swing_door_normal"] = "Nyíló ajtó - Csak ajtó normál szárny";
                nvcRendszerTipusok["swing_door_fix"] = "Nyíló ajtó - Csak ajtó fix szárny";
                nvcRendszerTipusok["screen"] = "Screen";
                
                string[] sRendszerTipusok = { "", "Tolóajtó", "Falban futó tolóajtó", "Nyíló ajtó - Csak ajtó normál szárny", "Nyíló ajtó - Csak ajtó fix szárny", "Screen", "Nyíló ajtó aluminium tok 100-125", "Nyíló ajtó aluminium tok 125 -" };
                //foreach (string sRendszerTipus in sRendszerTipusok)
                foreach (string sRendszerTipus in nvcRendszerTipusok)
                {
                    string sRendszerTipusNev = nvcRendszerTipusok[sRendszerTipus];
                    ListItem liRendszerTipus = new ListItem(sRendszerTipusNev, sRendszerTipus);
                    ddlRendszerTipus.Items.Add(liRendszerTipus);
                }

                string[] sBeepitesiModok = {"", "P1", "F1", "P2"};
                foreach (string sBeepMod in sBeepitesiModok)
                {
                    ddlBeepitesiMod.Items.Add(sBeepMod);
                }

                int nMaxSinekSzama = 4;
                for (int nSinekSzama = 0; nSinekSzama <= nMaxSinekSzama; nSinekSzama++)
                {
                    ddlSinekSzama.Items.Add(nSinekSzama.ToString());
                }

                int nMaxAjtokSzama = 4;
                for (int nAjtokSzama = 0; nAjtokSzama <= nMaxAjtokSzama; nAjtokSzama++)
                {
                    ddlAjtokSzama.Items.Add(nAjtokSzama.ToString());
                }

                string[] sBetetTipusok = { "", "B5 D3s", "B5 Es", "B6 P7s", "B6 P1s", "B5 EsMILL", "B5 D3sMILL", "B6 P1Ss", "B6 STS BRs" };
                foreach (string sBetetTipus in sBetetTipusok)
                {
                    ddlAjtoBetet1.Items.Add(sBetetTipus);
                    ddlAjtoBetet2.Items.Add(sBetetTipus);
                    ddlAjtoBetet3.Items.Add(sBetetTipus);
                    ddlAjtoBetet4.Items.Add(sBetetTipus);
                }

                string[] sVasalatok = { "", "Fékező nélkül", "1 fékezővel", "2 fékezővel" };
                foreach (string sVasalat in sVasalatok)
                {
                    ddlVasalat1.Items.Add(sVasalat);
                    ddlVasalat2.Items.Add(sVasalat);
                    ddlVasalat3.Items.Add(sVasalat);
                    ddlVasalat4.Items.Add(sVasalat);
                }

                int nMaxOsztokSzama = 4;
                for (int nOsztokSzama = 0; nOsztokSzama <= nMaxOsztokSzama; nOsztokSzama++)
                {
                    string sOsztokSzama = nOsztokSzama.ToString();
                    ddlOsztokSzamaAjto1.Items.Add(sOsztokSzama);
                    ddlOsztokSzamaAjto2.Items.Add(sOsztokSzama);
                    ddlOsztokSzamaAjto3.Items.Add(sOsztokSzama);
                    ddlOsztokSzamaAjto4.Items.Add(sOsztokSzama);
                }

                string[] sOpciok = { "", "Egyoldalas húzó jobb oldalon", "Egyoldalas húzó bal oldalon", "Kétoldalas húzó jobb oldalon", "Kétoldalas húzó bal oldalon", "Tolóajtó zár jobb oldalon", "Tolóajtó zár bal oldalon", "Kilincs zár nélkül", "Kilincs kulcsos zárral", "Kilincs WC zárral" };
                foreach (string sOpcio in sOpciok)
                {
                    ddlOpciokAjto1.Items.Add(sOpcio);
                    ddlOpciokAjto2.Items.Add(sOpcio);
                    ddlOpciokAjto3.Items.Add(sOpcio);
                    ddlOpciokAjto4.Items.Add(sOpcio);
                }


            }

        }
    }
}