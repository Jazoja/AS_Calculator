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
    public partial class Atlantic : Page
    {
        struSiteVariables rSV;

        


        public Atlantic()
        {

        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            rSV = Vars.SiteVars;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Page.IsPostBack)
            {

            }
            else
            {
                edPartnerCode.Text = rSV.rFej.sPartnerKod;
                
                ddlPartner.Items.Add("");
                ddlPartner.Items.Add("Alu-Style");
                ddlPartner.Items.Add("InForma");
                ddlPartner.Items.Add("SpeedMaster");

                divRendszerTipus.Visible = true;

                divBeepitesiMod.Visible = false;
                divSinekSzama.Visible = false;
                divSinHossza.Visible = false;
                divAjtokSzama.Visible = false;
                divNyitasIranya.Visible = false;
                divAjtoMeret.Visible = false;
                divNyilasMeretek.Visible = false;
                divAjtoMagassag.Visible = false;
                divAjtoSzelesseg.Visible = false;
                divAjtoBetet.Visible = false;
                divVasalat.Visible = false;
                divOsztokSzamaAjto.Visible = false;
                divOpciokToloAjto.Visible = false;
                divOpciokNyiloAjto.Visible = false;

                divAjto1.Visible = divAjto2.Visible = divAjto3.Visible = divAjto4.Visible = false;
                divMagassagAjto1.Visible = divMagassagAjto2.Visible = divMagassagAjto3.Visible = divMagassagAjto4.Visible = false;
                divSzelessegAjto1.Visible = divSzelessegAjto2.Visible = divSzelessegAjto3.Visible = divSzelessegAjto4.Visible = false;
                divAjtoBetet1.Visible = divAjtoBetet2.Visible = divAjtoBetet3.Visible = divAjtoBetet4.Visible = false;
                divOsztokSzamaAjto1.Visible = divOsztokSzamaAjto2.Visible = divOsztokSzamaAjto3.Visible = divOsztokSzamaAjto4.Visible = false;
                lblOpciokNyiloAjto.Visible = divOpciokNyiloAjto.Visible = divOpciokNyiloAjto1.Visible = divOpciokNyiloAjto2.Visible = divOpciokNyiloAjto3.Visible = divOpciokNyiloAjto4.Visible = false;
                lblOpciokToloAjto.Visible = divOpciokToloAjto.Visible = divOpciokToloAjto1.Visible = divOpciokToloAjto2.Visible = divOpciokToloAjto3.Visible = divOpciokToloAjto4.Visible = false;

                if (rSV.rRendszer.sRendszerTipus == "sliding_door_external")
                {
                    divBeepitesiMod.Visible = true;
                    divSinekSzama.Visible = true;
                    divSinHossza.Visible = true;
                    divAjtokSzama.Visible = true;
                    divAjtoMeret.Visible = true;
                    divAjtoMagassag.Visible = true;
                    divAjtoSzelesseg.Visible = true;
                    divAjtoBetet.Visible = true;
                    divVasalat.Visible = true;
                    lblOsztokSzamaAjto.Visible = divOsztokSzamaAjto.Visible = true;
                    lblOpciokToloAjto.Visible = divOpciokToloAjto.Visible = true;

                    divOpciokToloAjto1.Visible = divOsztokSzamaAjto1.Visible = divVasalat1.Visible = divAjtoBetet1.Visible = divSzelessegAjto1.Visible = divMagassagAjto1.Visible = divAjto1.Visible = rSV.rRendszer.nAjtokSzama >= 1;
                    divOpciokToloAjto2.Visible = divOsztokSzamaAjto2.Visible = divVasalat2.Visible = divAjtoBetet2.Visible = divSzelessegAjto2.Visible = divMagassagAjto2.Visible = divAjto2.Visible = rSV.rRendszer.nAjtokSzama >= 2;
                    divOpciokToloAjto3.Visible = divOsztokSzamaAjto3.Visible = divVasalat3.Visible = divAjtoBetet3.Visible = divSzelessegAjto3.Visible = divMagassagAjto3.Visible = divAjto3.Visible = rSV.rRendszer.nAjtokSzama >= 3;
                    divOpciokToloAjto4.Visible = divOsztokSzamaAjto4.Visible = divVasalat4.Visible = divAjtoBetet4.Visible = divSzelessegAjto4.Visible = divMagassagAjto4.Visible = divAjto4.Visible = rSV.rRendszer.nAjtokSzama >= 4;
                   
                }

                if (rSV.rRendszer.sRendszerTipus == "sliding_door_in_wall")
                {
                    divAjtokSzama.Visible = true;
                    divAjtoMeret.Visible = true;
                    divAjtoMagassag.Visible = true;
                    divAjtoSzelesseg.Visible = true;
                    divAjtoBetet.Visible = true;

                    lblOsztokSzamaAjto.Visible = divOsztokSzamaAjto.Visible = true;
                    lblOpciokToloAjto.Visible = divOpciokToloAjto.Visible = true;

                    divOpciokToloAjto1.Visible = divOsztokSzamaAjto1.Visible = divAjtoBetet1.Visible = divSzelessegAjto1.Visible = divMagassagAjto1.Visible = divAjto1.Visible = rSV.rRendszer.nAjtokSzama >= 1;
                    divOpciokToloAjto2.Visible = divOsztokSzamaAjto2.Visible = divAjtoBetet2.Visible = divSzelessegAjto2.Visible = divMagassagAjto2.Visible = divAjto2.Visible = rSV.rRendszer.nAjtokSzama >= 2;
                    divOpciokToloAjto3.Visible = divOsztokSzamaAjto3.Visible = divAjtoBetet3.Visible = divSzelessegAjto3.Visible = divMagassagAjto3.Visible = divAjto3.Visible = rSV.rRendszer.nAjtokSzama >= 3;
                    divOpciokToloAjto4.Visible = divOsztokSzamaAjto4.Visible = divAjtoBetet4.Visible = divSzelessegAjto4.Visible = divMagassagAjto4.Visible = divAjto4.Visible = rSV.rRendszer.nAjtokSzama >= 4;

                }

                if (rSV.rRendszer.sRendszerTipus == "swing_door_normal")
                {
                    divNyitasIranya.Visible = true;
                    divAjtokSzama.Visible = true;
                    divAjtoMeret.Visible = true;
                    divAjtoMagassag.Visible = true;
                    divAjtoSzelesseg.Visible = true;
                    divAjtoBetet.Visible = true;

                    divOsztokSzamaAjto.Visible = true;
                    divOpciokNyiloAjto.Visible = true;

                    divAjto1.Visible = true;
                    divMagassagAjto1.Visible = true;
                    divSzelessegAjto1.Visible = true;
                    divAjtoBetet1.Visible = true;
                    divOsztokSzamaAjto1.Visible = true;
                    lblOpciokNyiloAjto.Visible = divOpciokNyiloAjto1.Visible = true;

                }

                if (rSV.rRendszer.sRendszerTipus == "swing_door_fix")
                {
                    divNyitasIranya.Visible = true;
                    divAjtokSzama.Visible = true;
                    divAjtoMeret.Visible = true;
                    divAjtoMagassag.Visible = true;
                    divAjtoSzelesseg.Visible = true;
                    divAjtoBetet.Visible = true;

                    divOsztokSzamaAjto.Visible = true;
                    divOpciokNyiloAjto.Visible = true;

                    divAjto1.Visible = true;
                    divMagassagAjto1.Visible = true;
                    divSzelessegAjto1.Visible = true;
                    divAjtoBetet1.Visible = true;
                    divOsztokSzamaAjto1.Visible = true;
                }

                if (rSV.rRendszer.sRendszerTipus == "screen")
                {
                    divAjtokSzama.Visible = true;
                    divAjtoMeret.Visible = true;
                    divAjtoMagassag.Visible = true;
                    divAjtoSzelesseg.Visible = true;
                    divAjtoBetet.Visible = true;

                    divOsztokSzamaAjto.Visible = true;
                    divOpciokNyiloAjto.Visible = true;

                    divAjto1.Visible = true;
                    divMagassagAjto1.Visible = true;
                    divSzelessegAjto1.Visible = true;
                    divAjtoBetet1.Visible = true;
                    divOsztokSzamaAjto1.Visible = true;
                }

                if (rSV.rRendszer.sRendszerTipus == "swing_slim")
                {
                    divNyilasMeretek.Visible = true;

                    divAjtoMeret.Visible = true;

                    divAjto1.Visible = true;
                    divAjtoMagassag.Visible = divMagassagAjto1.Visible = true;
                    divAjtoSzelesseg.Visible = divSzelessegAjto1.Visible = true;
                    divOsztokSzamaAjto1.Visible = true;
                }

                if (rSV.rRendszer.sRendszerTipus == "swing_thin")
                {
                    divNyilasMeretek.Visible = true;

                    divAjtoMeret.Visible = true;

                    divAjto1.Visible = true;
                    divAjtoMagassag.Visible = divMagassagAjto1.Visible = true;
                    divAjtoSzelesseg.Visible = divSzelessegAjto1.Visible = true;
                    divOsztokSzamaAjto1.Visible = true;
                }

                ddlBeepitesiMod.Visible = true;
                ddlSinekSzama.Visible = true;
                edSinHossza.Visible = true;
                ddlAjtokSzama.Visible = true;

                edMagassagAjto1.Visible = true;
                edSzelessegAjto1.Visible = true;
                ddlAjtoBetet1.Visible = true;
                ddlVasalat1.Visible = true;
                ddlOsztokSzamaAjto1.Visible = true;
                ddlOpciokToloAjto1.Visible = true;

                edMagassagAjto2.Visible = true;
                edSzelessegAjto2.Visible = true;
                ddlAjtoBetet2.Visible = true;
                ddlVasalat2.Visible = true;
                ddlOsztokSzamaAjto2.Visible = true;
                ddlOpciokToloAjto2.Visible = true;

                edMagassagAjto3.Visible = true;
                edSzelessegAjto3.Visible = true;
                ddlAjtoBetet3.Visible = true;
                ddlVasalat3.Visible = true;
                ddlOsztokSzamaAjto3.Visible = true;
                ddlOpciokToloAjto3.Visible = true;

                edMagassagAjto4.Visible = true;
                edSzelessegAjto4.Visible = true;
                ddlAjtoBetet4.Visible = true;
                ddlVasalat4.Visible = true;
                ddlOsztokSzamaAjto4.Visible = true;
                ddlOpciokToloAjto4.Visible = true;

                NameValueCollection nvcRendszerTipusok = new NameValueCollection();

                nvcRendszerTipusok[""] = "";
                nvcRendszerTipusok["sliding_door_external"] = "Tolóajtó";
                nvcRendszerTipusok["sliding_door_in_wall"] = "Falban futó tolóajtó";
                nvcRendszerTipusok["swing_door_only_normal"] = "Nyíló ajtó - Csak ajtó normál szárny";
                nvcRendszerTipusok["swing_door_only_fix"] = "Nyíló ajtó - Csak ajtó fix szárny";
                nvcRendszerTipusok["screen"] = "Screen";
                nvcRendszerTipusok["swing_door_with_slim_alu_case"] = "Nyíló ajtó aluminium tok 100-125";
                nvcRendszerTipusok["swing_door_with_thin_alu_case"] = "Nyíló ajtó aluminium tok 125 -";

                foreach (string sRendszerTipusID in nvcRendszerTipusok)
                {
                    string sRendszerTipusNev = nvcRendszerTipusok[sRendszerTipusID];
                    ListItem liRendszerTipus = new ListItem(sRendszerTipusNev, sRendszerTipusID);
                    ddlRendszerTipus.Items.Add(liRendszerTipus);
                }
                ddlRendszerTipus.SelectedValue = rSV.rRendszer.sRendszerTipus;

                string[] sBeepitesiModok = { "", "P1", "F1", "P2" };
                foreach (string sBeepMod in sBeepitesiModok)
                {
                    ddlBeepitesiMod.Items.Add(sBeepMod);
                }
                ddlBeepitesiMod.SelectedValue = rSV.rRendszer.sBeepitesiMod;

                int nMaxSinekSzama = 4;
                for (int nSinekSzama = 0; nSinekSzama <= nMaxSinekSzama; nSinekSzama++)
                {
                    ddlSinekSzama.Items.Add(nSinekSzama.ToString());
                }
                ddlSinekSzama.SelectedValue = rSV.rRendszer.nSinekSzama.ToString();

                int nMaxAjtokSzama = 4;
                for (int nAjtokSzama = 0; nAjtokSzama <= nMaxAjtokSzama; nAjtokSzama++)
                {
                    ddlAjtokSzama.Items.Add(nAjtokSzama.ToString());
                }
                ddlAjtokSzama.SelectedValue = rSV.rRendszer.nAjtokSzama.ToString();

                NameValueCollection nvcNyitasIranyok = new NameValueCollection();

                nvcNyitasIranyok[""] = "";
                nvcNyitasIranyok["din_right"] = "DIN jobb";
                nvcNyitasIranyok["din_left"] = "DIN bal";
                
                foreach(string sNyitasIranyID in nvcNyitasIranyok)
                {
                    string sNyitasIranyNev = nvcNyitasIranyok[sNyitasIranyID];
                    ListItem liNyitasIrany = new ListItem(sNyitasIranyNev, sNyitasIranyID);
                    ddlNyitasIrany.Items.Add(liNyitasIrany);
                }
                ddlNyitasIrany.SelectedValue = rSV.rRendszer.sNyitasIranyID;

                string[] sBetetTipusok = { "", "B5 D3s", "B5 Es", "B6 P7s", "B6 P1s", "B5 EsMILL", "B5 D3sMILL", "B6 P1Ss", "B6 STS BRs" };
                foreach (string sBetetTipus in sBetetTipusok)
                {
                    ddlAjtoBetet1.Items.Add(sBetetTipus);
                    ddlAjtoBetet2.Items.Add(sBetetTipus);
                    ddlAjtoBetet3.Items.Add(sBetetTipus);
                    ddlAjtoBetet4.Items.Add(sBetetTipus);
                }
                ddlAjtoBetet1.SelectedValue = rSV.rRendszer.rAjto[1].sBetetID;
                ddlAjtoBetet2.SelectedValue = rSV.rRendszer.rAjto[2].sBetetID;
                ddlAjtoBetet3.SelectedValue = rSV.rRendszer.rAjto[3].sBetetID;
                ddlAjtoBetet4.SelectedValue = rSV.rRendszer.rAjto[4].sBetetID;

                NameValueCollection nvcVasalatok = new NameValueCollection() { { "", "" }, {"0", "Fékező nélkül" }, { "1", "1 fékezővel" }, { "2", "2 fékezővel" } };

                foreach (string sVasalatID in nvcVasalatok)
                {
                    string sVasalatNev = nvcVasalatok[sVasalatID];

                    ListItem liVasalat = new ListItem(sVasalatNev, sVasalatID);
                    ddlVasalat1.Items.Add(liVasalat);
                    liVasalat = new ListItem(sVasalatNev, sVasalatID);
                    ddlVasalat2.Items.Add(liVasalat);
                    liVasalat = new ListItem(sVasalatNev, sVasalatID);
                    ddlVasalat3.Items.Add(liVasalat);
                    liVasalat = new ListItem(sVasalatNev, sVasalatID);
                    ddlVasalat4.Items.Add(liVasalat);
                }
                ddlVasalat1.SelectedValue = rSV.rRendszer.rAjto[1].sVasalatID;
                ddlVasalat2.SelectedValue = rSV.rRendszer.rAjto[2].sVasalatID;
                ddlVasalat3.SelectedValue = rSV.rRendszer.rAjto[3].sVasalatID;
                ddlVasalat4.SelectedValue = rSV.rRendszer.rAjto[4].sVasalatID;

                int nMaxOsztokSzama = 4;
                for (int nOsztokSzama = 0; nOsztokSzama <= nMaxOsztokSzama; nOsztokSzama++)
                {
                    string sOsztokSzama = nOsztokSzama.ToString();
                    ddlOsztokSzamaAjto1.Items.Add(sOsztokSzama);
                    ddlOsztokSzamaAjto2.Items.Add(sOsztokSzama);
                    ddlOsztokSzamaAjto3.Items.Add(sOsztokSzama);
                    ddlOsztokSzamaAjto4.Items.Add(sOsztokSzama);
                }
                ddlOsztokSzamaAjto1.SelectedValue = rSV.rRendszer.rAjto[1].nOsztokSzama.ToString();
                ddlOsztokSzamaAjto2.SelectedValue = rSV.rRendszer.rAjto[2].nOsztokSzama.ToString();
                ddlOsztokSzamaAjto3.SelectedValue = rSV.rRendszer.rAjto[3].nOsztokSzama.ToString();
                ddlOsztokSzamaAjto4.SelectedValue = rSV.rRendszer.rAjto[4].nOsztokSzama.ToString();

                NameValueCollection nvcOpciokToloAjto = new NameValueCollection();
                nvcOpciokToloAjto[""] = "";
                nvcOpciokToloAjto["one_side_handle_on_right"] = "Egyoldalas húzó jobb oldalon";
                nvcOpciokToloAjto["one_side_handle_on_left"] = "Egyoldalas húzó bal oldalon";
                nvcOpciokToloAjto["two_side_handle_on_right"] = "Kétoldalas húzó jobb oldalon";
                nvcOpciokToloAjto["two_side_handle_on_left"] = "Kétoldalas húzó bal oldalon";
                nvcOpciokToloAjto["slide_door_lock_on_right"] = "Tolóajtó zár jobb oldalon";
                nvcOpciokToloAjto["slide_door_lock_on_left"] = "Tolóajtó zár bal oldalon";

                foreach (string sOpcioID in nvcOpciokToloAjto)
                {
                    string sOpcioNev = nvcOpciokToloAjto[sOpcioID];

                    ListItem liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokToloAjto1.Items.Add(liOpcio);
                    liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokToloAjto2.Items.Add(liOpcio);
                    liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokToloAjto3.Items.Add(liOpcio);
                    liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokToloAjto4.Items.Add(liOpcio);

                }
                ddlOpciokToloAjto1.SelectedValue = rSV.rRendszer.rAjto[1].sOpciokToloAjtoID;
                ddlOpciokToloAjto2.SelectedValue = rSV.rRendszer.rAjto[2].sOpciokToloAjtoID;
                ddlOpciokToloAjto3.SelectedValue = rSV.rRendszer.rAjto[3].sOpciokToloAjtoID;
                ddlOpciokToloAjto4.SelectedValue = rSV.rRendszer.rAjto[4].sOpciokToloAjtoID;

                NameValueCollection nvcOpciokNyiloAjto = new NameValueCollection();
                nvcOpciokNyiloAjto[""] = "";
                nvcOpciokNyiloAjto["handle_without_lock"] = "Kilincs zár nélkül";
                nvcOpciokNyiloAjto["handle_with_key_lock"] = "Kilincs kulcsos zárral";
                nvcOpciokNyiloAjto["handle_with_toilet_lock"] = "Kilincs WC zárral";

                foreach (string sOpcioID in nvcOpciokNyiloAjto)
                {
                    string sOpcioNev = nvcOpciokNyiloAjto[sOpcioID];

                    ListItem liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokNyiloAjto1.Items.Add(liOpcio);
                    liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokNyiloAjto2.Items.Add(liOpcio);
                    liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokNyiloAjto3.Items.Add(liOpcio);
                    liOpcio = new ListItem(sOpcioNev, sOpcioID);
                    ddlOpciokNyiloAjto4.Items.Add(liOpcio);
                     
                }
                
                ddlOpciokNyiloAjto1.SelectedValue = rSV.rRendszer.rAjto[1].sOpciokNyiloAjtoID;
                ddlOpciokNyiloAjto2.SelectedValue = rSV.rRendszer.rAjto[2].sOpciokNyiloAjtoID;
                ddlOpciokNyiloAjto3.SelectedValue = rSV.rRendszer.rAjto[3].sOpciokNyiloAjtoID;
                ddlOpciokNyiloAjto4.SelectedValue = rSV.rRendszer.rAjto[4].sOpciokNyiloAjtoID;

                edSinHossza.Text = rSV.rRendszer.nSinHossz.ToString();
                
                edMagassagAjto1.Text = rSV.rRendszer.rAjto[1].nMagassag.ToString();
                edMagassagAjto2.Text = rSV.rRendszer.rAjto[2].nMagassag.ToString();
                edMagassagAjto3.Text = rSV.rRendszer.rAjto[3].nMagassag.ToString();
                edMagassagAjto4.Text = rSV.rRendszer.rAjto[4].nMagassag.ToString();

                edSzelessegAjto1.Text = rSV.rRendszer.rAjto[1].nSzelesseg.ToString();
                edSzelessegAjto2.Text = rSV.rRendszer.rAjto[2].nSzelesseg.ToString();
                edSzelessegAjto3.Text = rSV.rRendszer.rAjto[3].nSzelesseg.ToString();
                edSzelessegAjto4.Text = rSV.rRendszer.rAjto[4].nSzelesseg.ToString();

                edNyilasMagassag.Text = rSV.rRendszer.nNyilasMagassag.ToString();
                edNyilasSzelesseg.Text = rSV.rRendszer.nNyilasSzelesseg.ToString();
                edFalvastagsag.Text = rSV.rRendszer.nFalVastagsag.ToString();
            }

        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            Vars.SiteVars = rSV;

            
            if (Page.IsPostBack)
            {
                string sURL = System.Web.HttpContext.Current.Request.RawUrl;
                HttpContext.Current.Response.Redirect(sURL);
            }
                
        }

        public void Calculate()
        {
                
        }

        protected void ddlRendszerTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.sRendszerTipus = ddlRendszerTipus.SelectedValue;
        }

        protected void ddlBeepitesiMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.sBeepitesiMod = ddlBeepitesiMod.SelectedValue;
        }

        protected void ddlSinekSzama_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.nSinekSzama = Int32.Parse(ddlSinekSzama.SelectedValue);
        }

        protected void ddlAjtokSzama_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nAjtokSzama = Int32.Parse(ddlAjtokSzama.SelectedValue);
            rSV.rRendszer.SetAjtokSzama(nAjtokSzama);
        }

        protected void ddlNyitasIrany_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.sNyitasIranyID = ddlNyitasIrany.SelectedValue;
        }

        protected void edNyilasMagassag_TextChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.nNyilasMagassag = Int32.Parse(edNyilasMagassag.Text);
            rSV.rRendszer.rAjto[1].nMagassag = rSV.rRendszer.nNyilasMagassag - 45;
        }

        protected void edNyilasSzelesseg_TextChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.nNyilasSzelesseg = Int32.Parse(edNyilasSzelesseg.Text);
            rSV.rRendszer.rAjto[1].nSzelesseg = rSV.rRendszer.nNyilasSzelesseg - 78;
        }

        protected void edFalvastagsag_TextChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.nFalVastagsag = Int32.Parse(edFalvastagsag.Text);
        }

        protected void edMagassagAjto_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(edMagassagAjto1.Text, out rSV.rRendszer.rAjto[1].nMagassag);
            Int32.TryParse(edMagassagAjto2.Text, out rSV.rRendszer.rAjto[2].nMagassag);
            Int32.TryParse(edMagassagAjto3.Text, out rSV.rRendszer.rAjto[3].nMagassag);
            Int32.TryParse(edMagassagAjto4.Text, out rSV.rRendszer.rAjto[4].nMagassag);

        }

        protected void edSzelessegAjto_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(edSzelessegAjto1.Text, out rSV.rRendszer.rAjto[1].nSzelesseg);
            Int32.TryParse(edSzelessegAjto2.Text, out rSV.rRendszer.rAjto[2].nSzelesseg);
            Int32.TryParse(edSzelessegAjto3.Text, out rSV.rRendszer.rAjto[3].nSzelesseg);
            Int32.TryParse(edSzelessegAjto4.Text, out rSV.rRendszer.rAjto[4].nSzelesseg);
        }

        protected void ddlAjtoBetet_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.rAjto[1].sBetetID = ddlAjtoBetet1.SelectedValue;
            rSV.rRendszer.rAjto[2].sBetetID = ddlAjtoBetet2.SelectedValue;
            rSV.rRendszer.rAjto[3].sBetetID = ddlAjtoBetet3.SelectedValue;
            rSV.rRendszer.rAjto[4].sBetetID = ddlAjtoBetet4.SelectedValue;
        }

        protected void ddlVasalat_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.rAjto[1].sVasalatID = ddlVasalat1.SelectedValue;
            rSV.rRendszer.rAjto[2].sVasalatID = ddlVasalat2.SelectedValue;
            rSV.rRendszer.rAjto[3].sVasalatID = ddlVasalat3.SelectedValue;
            rSV.rRendszer.rAjto[4].sVasalatID = ddlVasalat4.SelectedValue;
        }

        protected void ddlOsztokSzamaAjto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(ddlOsztokSzamaAjto1.SelectedValue, out rSV.rRendszer.rAjto[1].nOsztokSzama);
            Int32.TryParse(ddlOsztokSzamaAjto2.SelectedValue, out rSV.rRendszer.rAjto[2].nOsztokSzama);
            Int32.TryParse(ddlOsztokSzamaAjto3.SelectedValue, out rSV.rRendszer.rAjto[3].nOsztokSzama);
            Int32.TryParse(ddlOsztokSzamaAjto4.SelectedValue, out rSV.rRendszer.rAjto[4].nOsztokSzama);
        }

        protected void ddlOpciokToloAjto_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.rAjto[1].sOpciokToloAjtoID = ddlOpciokToloAjto1.SelectedValue;
            rSV.rRendszer.rAjto[2].sOpciokToloAjtoID = ddlOpciokToloAjto2.SelectedValue;
            rSV.rRendszer.rAjto[3].sOpciokToloAjtoID = ddlOpciokToloAjto3.SelectedValue;
            rSV.rRendszer.rAjto[4].sOpciokToloAjtoID = ddlOpciokToloAjto4.SelectedValue;
        }

        protected void ddlOpciokNyiloAjto_SelectedIndexChanged(object sender, EventArgs e)
        {
            rSV.rRendszer.rAjto[1].sOpciokNyiloAjtoID = ddlOpciokNyiloAjto1.SelectedValue;
            rSV.rRendszer.rAjto[2].sOpciokNyiloAjtoID = ddlOpciokNyiloAjto2.SelectedValue;
            rSV.rRendszer.rAjto[3].sOpciokNyiloAjtoID = ddlOpciokNyiloAjto3.SelectedValue;
            rSV.rRendszer.rAjto[4].sOpciokNyiloAjtoID = ddlOpciokNyiloAjto4.SelectedValue;
        }


        protected void edSinHossza_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(edSinHossza.Text, out rSV.rRendszer.nSinHossz);
        }

        protected void ddlPartnerKod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void edPartnerCode_TextChanged(object sender, EventArgs e)
        {
            rSV.rFej.sPartnerKod = edPartnerCode.Text;
        }



    }
}
