using System;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace CalculatorWF
{
    public static class Vars
    {
        public static struSiteVariables SiteVars
        {
            get { try { return (struSiteVariables)System.Web.HttpContext.Current.Session["SiteVariables"]; } catch { return default(struSiteVariables); } }
            set { try { System.Web.HttpContext.Current.Session["SiteVariables"] = value; } catch { } }
        }
    }
    public struct struCeg
    {
        public int nCegKey;
        public int nSzulo;
        public int nCegSzint;
        public string sSzuloEmail;
        public int nSzuloEmailLang;
        public string sGyerekEmail;
        public string sMegnevezes,
                      sIrszam,
                      sTelepules,
                      sUtcaHazszam,
                      sEmail1,
                      sEmail2,
                      sTelefon,
                      sTelefax;
        public int nArTip;
        public string sValuta;
        public double nRes,
                      nAFA,
                      nArvaltozas,
                      nArf;
        public string sSAP, sVKOD, sEXPORT_MAIL1, sEXPORT_MAIL2, sEXPORT_MAIL3;
        public int nEmailLang;
        public bool bFelvehet;
    }

    public struct struRendfej
    {
        [XmlIgnoreAttribute]
        public int nRendFejKey,
                   nSorszam,
                   nEv;

        public string sRendelesSzam,
                      sKomisszio,
                      sDatum,
                      sHatarido,
                      sSzallitasiHatarido;

        [XmlIgnoreAttribute]
        public string sRendelo_Nev,
                      sCegnev,
                      sTelepules,
                      sIrszam,
                      sUtca,
                      sTelefon,
                      sEmail;

        public string sValuta,
                      sArkepzoSzam,
                      sGyujtoSzam,
                      sMegjegyzes,
                      sSajatRendelesSzam,
                      sKezelo;
        public string sPartnerKod;
        [XmlIgnoreAttribute]
        public string sRendeloRendszam;
        [XmlIgnoreAttribute]
        public int nArTip,
                   nAllapot,
                   nEmailLang,
                   nCeg,
                   nUser,
                   nSzulo,
                   nRendeloCegKey,
                   nRendeloFejKey;
        public int nGyartasMunkanapok,
                   nSzallitasMunkanapok;
        [XmlIgnoreAttribute]
        public double nArf,
                      nAFA,
                      nRes,
                      nExtraRes;

        public string sTermekNev;
        public string sTechnologiaKod;

        [XmlIgnoreAttribute]
        public int nTetelDarabSzam;
        public int nTetelSzam;

        public int nVAMTSZ;
        public int nAruTipus;
        public string sTermekBesorolasKod;
        public string sTermekBesorolasNev;
        public string sTipusTermek;
        public string sRaktarkod;
        public string sRajzURL;

    }

    public struct struTetel
    {
        public string sHiba;
        public string sCikksz;
        public string sCikkszamWD;
        public string sCikkszamRaktar;
        public string sCikkszamKalk;
        public string sMegjegyzes;
        public string sNev;
        public string sSzettCikkszam;

        public string sMeret;
        public string sME;
        public string sMuveletNev;

        [XmlIgnoreAttribute]
        public string sKijeloltVegtermek;
        [XmlIgnoreAttribute]
        public double dblMennyiseg;

        public decimal dMennyiseg;

        [XmlIgnoreAttribute]
        public decimal dEgysegAr;
        [XmlIgnoreAttribute]
        public decimal dAr;
        [XmlIgnoreAttribute]
        public decimal dErtek;
        [XmlIgnoreAttribute]
        public int nSorszam;
        [XmlIgnoreAttribute]
        public int nLevel;
        [XmlIgnoreAttribute]
        public int nCikktip;
        [XmlIgnoreAttribute]
        public int nRaktarCikktip;
        [XmlIgnoreAttribute]
        public int nDarab;
        [XmlIgnoreAttribute]
        public int nHosszusag;
        [XmlIgnoreAttribute]
        public int nMagassag;
        [XmlIgnoreAttribute]
        public int nSzelesseg;
        [XmlIgnoreAttribute]
        public int nVastagsag;
        [XmlIgnoreAttribute]
        public int nMelyseg;
        [XmlIgnoreAttribute]
        public int nHatarIdo;

        public string sMagassag;
        public string sSzelesseg;
        public string sVastagsag;
        public string sBetetVastagsagKod;
        public string sBetetKod;
        public string sBetetUzemiNev;
        public string sSpec;
        public string sBetTipKieg;
        public string sBiztonsag;
        public string sFeluletkialakitas;
        public string sElkialakitas;
        public string sMegmunkalas;
        public string sSzalirany;
        public string sEgyeb; //0 - nem, E - ha igen

        [XmlIgnoreAttribute]
        public struTetel[] rBontas;
    }

    public struct struAjto
    {
        public int nSzelesseg;
        public int nMagassag;
        public string sBetetID;
        public string sVasalatID;
        public int nOsztokSzama;
        public string sOpciokToloAjtoID;
        public string sOpciokNyiloAjtoID;
    }

    public struct struRendszer
    {
        public string sRendszerTipus;
        public string sBeepitesiMod;
        public string sSin;
        public string sTok;

        public int nNyilasMagassag;
        public int nNyilasSzelesseg;
        public int nFalVastagsag;

        public string sNyitasIranyID;

        public int nSinekSzama;
        public int nSinHossz;
        public int nAjtokSzama;

        public short nDarab;
        public decimal dSuly;
        
        public decimal dAr;

        public struAjto[] rAjto;

        public struRendszer(string sState = "default")
        {
            this.sRendszerTipus = "";
            this.sBeepitesiMod = "";

            this.sSin = "";
            this.sTok = "";

            this.nNyilasMagassag = 0;
            this.nNyilasSzelesseg = 0;
            this.nFalVastagsag = 0;

            this.nSinekSzama = 0;
            this.nSinHossz = 0;
            this.nAjtokSzama = 0;

            this.sNyitasIranyID = "";

            this.nDarab = 0;
            this.dSuly = 0;

            this.dAr = 0;

            this.rAjto = new struAjto[5];
        }

        public void SetAjtokSzama(int nAjtokSzama)
        {
            this.nAjtokSzama = nAjtokSzama;
            //Array.Resize(ref this.rAjto, nAjtokSzama + 1);
        }
        public struRendszer(struRendszer rRendszer)
        {
            this.sRendszerTipus = rRendszer.sRendszerTipus;
            this.sBeepitesiMod = rRendszer.sBeepitesiMod;
            
            this.sSin = rRendszer.sSin;
            this.sTok = rRendszer.sTok;

            this.nNyilasMagassag = rRendszer.nNyilasMagassag;
            this.nNyilasSzelesseg = rRendszer.nNyilasSzelesseg;
            this.nFalVastagsag = rRendszer.nFalVastagsag;

            this.nSinekSzama = rRendszer.nSinekSzama;
            this.nSinHossz = rRendszer.nSinHossz;
            this.nAjtokSzama = rRendszer.nAjtokSzama;

            this.sNyitasIranyID = rRendszer.sNyitasIranyID;

            this.nDarab = rRendszer.nDarab;
            this.dSuly = rRendszer.dSuly;
            
            this.dAr = rRendszer.dAr;

            this.rAjto = new struAjto[rRendszer.rAjto.Length];
            rRendszer.rAjto.CopyTo(this.rAjto,0);
        }
    }

    public struct struSiteVariables
    {
        public string sHiba;
        public string sCalcID;
        public struRendfej rFej;

        public struRendszer rRendszer;
        public struTetel[] rBontas;

        public struSiteVariables(string sMode = "default")
        {
            sHiba = null;
            sCalcID = "AT";
            rFej = new struRendfej();

            rRendszer = new struRendszer(sMode);
            rBontas = new struTetel[0];
        }

        public struSiteVariables(struSiteVariables rSV)
        {
            this.sHiba = rSV.sHiba;
            this.sCalcID = rSV.sCalcID;
            this.rFej = rSV.rFej;

            this.rRendszer = new struRendszer(rSV.rRendszer);
            this.rBontas = new struTetel[rSV.rBontas.Length];
            rSV.rBontas.CopyTo(this.rBontas, 0);
        }
    }

    public static class Common
    {
        public static string sWDConnection = "user id=Calculator;" +
                       @"password=Calc;server=AS-WINDIRECT\WINDIRECT;" +
                       "Trusted_Connection=no;" +
                       "database=WD_eles; " +
                       "connection timeout=30";

        public static string sMSCalcConnection = "user id=Calculator;" +
               @"password=Calc;server=AS-WINDIRECT\WINDIRECT;" +
               "Trusted_Connection=no;" +
               "database=Calculator; " +
               "connection timeout=30";

        public static string sWD_ServerFolder = @"\\AS-WINDIRECT\WinDirect\";
        public static string sWD_XML_LocalFolder = @"c:\complete\WinDirekt\XML\";
        public static string sXMLFileSaveFolderURL = "";

        public static bool bTestMode = true; //teszt vagy éles? (adatbázis, emilek, stb.)
        public static bool bTestFunction;
        public static bool bTestData = false;
        public static bool bLocalMode = false; //a gépemen fut-e a szoftver vagy a szerveren?
        public static bool bDebugMode = true; //Adatbázisba extra adatokat is kiír (üveg ára, munkadíj és bruttó fedezet)

        public static string Init(string serverMapPath)
        {
            string sResult = "";

            if (serverMapPath.Contains(@"G:\VOL2\Braun\www\ledspiegel")) //ha a szoftver az éles mappában van
                bTestMode = false; //akkor kikapcsolom a teszt módot

            bTestFunction = bTestMode;

            //bTestMode = false; //teszt mód esetén teszt adatbázis, amúgy éles

            if (serverMapPath.Contains(@"VS_projects")) //ha a szoftver a gépemen van
                bLocalMode = true; //akkor bekapcsolom a local módot

            sXMLFileSaveFolderURL = bLocalMode ? sWD_XML_LocalFolder : sWD_ServerFolder + (bTestMode ? @"XML\" : @"WD_ELESXML\");
            return sResult;
        }
        
        public static string getWDcikk(ref NameValueCollection nvcCikkWD)
        {
            bool bCikkszamFound = false;
            string sResult = "";

            string sCikkszam = nvcCikkWD["pridentifier"];

            SqlConnection myConnection = new SqlConnection(sWDConnection);

            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                sResult += " Database connection error: " + ex.ToString() + ";";
            }

            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT top (10) product.PRIDENTIFIER, product.PRODUCTNAME, product.PRODUCTGROUPID, PRODUCTGROUPNAME, product.P_CUSTOMCODE FROM [WD_eles].[dbo].[PRODUCT] join [WD_eles].[dbo].[PRODUCTGROUP] on PRODUCT.PRODUCTGROUPID = PRODUCTGROUP.PRODUCTGROUPID where pridentifier ='" + sCikkszam + "'", myConnection);

                myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    bCikkszamFound = true;
                    foreach(string sFieldID in myReader)
                    {
                        nvcCikkWD[sFieldID] = myReader[sFieldID].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                sResult += " Database query error: " + ex.ToString() + ";";
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                sResult += " Database close error: " + ex.ToString() + ";";
            }

            if(!bCikkszamFound)
                sResult += " Product ID not found in database: " + sCikkszam + ";";

            return sResult;
        }

        public static string getKalkCikk(ref NameValueCollection nvcCikkIn)
        {
            bool bCikkszamFound = false;
            string sResult = "";

            string sCikkszam = nvcCikkIn["CIKKSZAM_KALK"];

            SqlConnection myConnection = new SqlConnection(sMSCalcConnection);

            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                sResult += " Database connection error: " + ex.ToString() + ";";
            }

            string sFields = "";

            foreach (string sFieldName in nvcCikkIn)
            {
                sFields += sFieldName + ", ";
            }
            sFields = sFields.TrimEnd(new char[]{' ', ','});
             
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT top (10) " + sFields + " FROM cikktorzs where cikkszam_kalk = '" + sCikkszam + "'", myConnection);

                myReader = myCommand.ExecuteReader();
                NameValueCollection nvcCikkOut = new NameValueCollection();
                if (myReader.Read())
                {
                    bCikkszamFound = true;
                    foreach (string sFieldID in nvcCikkIn)
                    {
                        nvcCikkOut[sFieldID] = myReader[sFieldID].ToString();
                    }
                }
                nvcCikkIn = nvcCikkOut;
            }
            catch (Exception ex)
            {
                sResult += " Database query error: " + ex.ToString() + ";";
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                sResult += " Database close error: " + ex.ToString() + ";";
            }

            if (!bCikkszamFound)
                sResult += " Product ID not found in database: " + sCikkszam + ";";

            return sResult;
        }

        public static string getSzett(ref NameValueCollection[] nvcSzettIn)
        {
            bool bCikkszamFound = false;
            string sResult = "";

            string sCikkszam = nvcSzettIn[0]["CIKKSZAM_SZETT"];

            SqlConnection myConnection = new SqlConnection(sMSCalcConnection);

            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                sResult += " Database connection error: " + ex.ToString() + ";";
            }

            string sFields = "";

            foreach (string sFieldName in nvcSzettIn[0])
            {
                sFields += sFieldName + ", ";
            }
            sFields = sFields.TrimEnd(new char[] { ' ', ',' });

            try
            {

                NameValueCollection[] nvcSzettOut = default(NameValueCollection[]);

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT top (20) " + sFields + " FROM szett_bontas where cikkszam_szett = '" + sCikkszam + "'", myConnection);

                myReader = myCommand.ExecuteReader();
                
                NameValueCollection nvcCikkOut = new NameValueCollection();
                while (myReader.Read())
                {
                    bCikkszamFound = true;
                    int i = 0;
                    foreach (string sFieldID in nvcSzettIn[0])
                    {
                        nvcCikkOut[sFieldID] = myReader[sFieldID].ToString();
                    }
                    Array.Resize(ref nvcSzettOut, i + 1);
                    nvcSzettOut[i] = nvcCikkOut;
                    i++;
                }
                nvcSzettIn = nvcSzettOut;
            }
            catch (Exception ex)
            {
                sResult += " Database query error: " + ex.ToString() + ";";
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                sResult += " Database close error: " + ex.ToString() + ";";
            }

            if (!bCikkszamFound)
                sResult += " Product ID not found in database: " + sCikkszam + ";";

            return sResult;
        }

        public static string AddTetel(struTetel rTetel, ref struTetel[] rBontas)
        {
            string sResult ="";

            if (rTetel.dMennyiseg > 0)
            {
                Array.Resize(ref rBontas, rBontas.Length + 1);
                rBontas[rBontas.Length - 1] = rTetel;
            }

            return sResult;
        }

        public static string AddTetel(struTetel[] rTetelek, ref struTetel[] rBontas)
        {
            string sResult = "";
            int nOrigSize = rBontas.Length;
            Array.Resize(ref rBontas, rBontas.Length + rTetelek.Length);
            rTetelek.CopyTo(rBontas, nOrigSize);

            return sResult;
        }

        public static string calculate(ref struSiteVariables rSV)
        {
            string sResult = "";

            struRendszer rRendszer = rSV.rRendszer;
            struTetel[] rBontas = new struTetel[0];
            
            if (rRendszer.sRendszerTipus == "sliding_door_external" || rRendszer.sRendszerTipus == "sliding_door_internal" || rRendszer.sRendszerTipus == "swing_door_only_normal" || rRendszer.sRendszerTipus == "swing_door_only_fix" || rRendszer.sRendszerTipus == "screen")
            {


                if (rRendszer.sRendszerTipus == "sliding_door_external")
                {
                    if (rSV.rRendszer.sBeepitesiMod == "P1")
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.160.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000 * rRendszer.nSinekSzama;
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.110.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000 * 2;
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.112.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000 * (rRendszer.nSinekSzama - 1);
                        AddTetel(rTetel, ref rBontas);

                    }

                    if (rSV.rRendszer.sBeepitesiMod == "P2")
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.160.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000 * rRendszer.nSinekSzama;
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.161.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000 * 2;
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "6116";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000 * rRendszer.nSinekSzama;
                        AddTetel(rTetel, ref rBontas);

                    }

                    if (rSV.rRendszer.sBeepitesiMod == "F1")
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.160.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000;
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.100.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000;
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "110.110.00";
                        rTetel.dMennyiseg = rRendszer.nSinHossz / 1000;
                        AddTetel(rTetel, ref rBontas);

                    }

                    if (rSV.rRendszer.sBeepitesiMod.StartsWith("P")) //sín végzáró elem
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "140.180.00";
                        rTetel.dMennyiseg = rRendszer.nSinekSzama * 2;
                        AddTetel(rTetel, ref rBontas);
                    }

                    int nFekezok = 0;
                    for (int nAjto = 1; nAjto <= rRendszer.nAjtokSzama; nAjto++)
                    {
                        short nFekezo = 0;
                        Int16.TryParse(rRendszer.rAjto[nAjto].sVasalatID, out nFekezo);
                        nFekezok += nFekezo;
                    }
                    int nFekezosVasalat = nFekezok;
                    int nFekezoNelkuliVasalat = rRendszer.nAjtokSzama * 2 - nFekezosVasalat;

                    if (nFekezosVasalat > 0)
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "430.101.00";
                        rTetel.dMennyiseg = nFekezosVasalat;
                        AddTetel(rTetel, ref rBontas);
                    }

                    if (nFekezoNelkuliVasalat > 0)
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "430.111.00";
                        rTetel.dMennyiseg = nFekezoNelkuliVasalat;
                        AddTetel(rTetel, ref rBontas);
                    }

                    if (rSV.rRendszer.sBeepitesiMod.StartsWith("P")) //sín rögzítő csavar szett
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "650.020.11";
                        rTetel.dMennyiseg = rRendszer.nSinekSzama * Math.Round((decimal)(2 + (rRendszer.nSinHossz / 1000) * 3));
                        AddTetel(rTetel, ref rBontas);
                    }

                    if (rSV.rRendszer.sBeepitesiMod == "F1")
                    {
                        struTetel rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "150.000.11";
                        rTetel.dMennyiseg = rRendszer.nSinekSzama * Math.Round((decimal)(2 + (rRendszer.nSinHossz / 1000) * 3));
                        AddTetel(rTetel, ref rBontas);

                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "150.010.11";
                        rTetel.dMennyiseg = rRendszer.nSinekSzama * Math.Round((decimal)(2 + (rRendszer.nSinHossz / 1000) * 3));
                        AddTetel(rTetel, ref rBontas);

                    }
                }

                for (int nAjto = 1; nAjto <= rSV.rRendszer.nAjtokSzama; nAjto++ )
                {
                    struAjto rAjto = rSV.rRendszer.rAjto[nAjto];
                    if (rSV.rRendszer.sRendszerTipus == "swing_door_only_normal" || rSV.rRendszer.sRendszerTipus == "swing_door_only_fix")
                    {
                        //nyitásirány
                    }

                    struTetel rTetel = new struTetel();
                    rTetel.sCikkszamKalk = "ATL-200";
                    rTetel.dMennyiseg = (rAjto.nSzelesseg + rAjto.nMagassag) / 1000 * 2;
                    AddTetel(rTetel, ref rBontas);

                    rTetel = new struTetel();
                    rTetel.sCikkszamKalk = "ATL-210";
                    rTetel.dMennyiseg = (rAjto.nMagassag) / 1000 * 2;
                    AddTetel(rTetel, ref rBontas);
                    

                    if (rSV.rRendszer.sRendszerTipus == "sliding_door_in_wall") //extra profil az ajtó oldalára
                    {
                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "ATL-161";
                        rTetel.dMennyiseg = (rAjto.nSzelesseg + rAjto.nMagassag) / 1000 * 2;
                        AddTetel(rTetel, ref rBontas);
                    
                        //itt van még valami jobb/bal cucc
                    }

                    //betét
                    rTetel = new struTetel();
                    rTetel.sCikkszamKalk = rAjto.sBetetID;
                    rTetel.dMennyiseg = (rAjto.nMagassag * rAjto.nSzelesseg) / 1000; //betét felülete
                    AddTetel(rTetel, ref rBontas);

                    //osztó
                    if(rAjto.nOsztokSzama > 0)
                    {
                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = "510.331.00";
                        rTetel.nDarab = rAjto.nOsztokSzama;
                        rTetel.nHosszusag = rAjto.nSzelesseg - 62;
                        rTetel.dMennyiseg = (rTetel.nHosszusag) / 1000 * rTetel.nDarab;
                        AddTetel(rTetel, ref rBontas);
                    }


                    if(!string.IsNullOrEmpty(rAjto.sBetetID))
                    {
                        rTetel = new struTetel();
                        rTetel.sCikkszamKalk = rAjto.sBetetID.StartsWith("B5") ? "PUXV5" : "U7X4M";
                        rTetel.dMennyiseg = (rAjto.nMagassag + rAjto.nSzelesseg) / 1000 * 2;
                        AddTetel(rTetel, ref rBontas);
                    }

                    rTetel = new struTetel();
                    rTetel.sCikkszamKalk = "U2P";
                    rTetel.dMennyiseg = rAjto.nMagassag / 1000 * 2;
                    AddTetel(rTetel, ref rBontas);

                    if (rSV.rRendszer.sRendszerTipus == "sliding_door_external" || rSV.rRendszer.sRendszerTipus == "sliding_door_in_wall")
                    {
                        
                        rTetel = new struTetel();
                        switch(rAjto.sOpciokToloAjtoID)
                        {
                            case "one_side_handle_on_right":
                                rTetel.sCikkszamKalk = "ATL-H1";
                                rTetel.sMegjegyzes = "jobb";
                                break;
                            case "one_side_handle_on_left":
                                rTetel.sCikkszamKalk = "ATL-H1";
                                rTetel.sMegjegyzes = "bal";
                                break;
                            case "two_side_handle_on_right":
                                rTetel.sCikkszamKalk = "ATL-H2";
                                rTetel.sMegjegyzes = "jobb";
                                break;
                            case "two_side_handle_on_left":
                                rTetel.sCikkszamKalk = "ATL-H2";
                                rTetel.sMegjegyzes = "bal";
                                break;
                            case "slide_door_lock_on_right":
                                rTetel.sCikkszamKalk = "ATL-H3";
                                rTetel.sMegjegyzes = "jobb";
                                break;
                            case "slide_door_lock_on_left":
                                rTetel.sCikkszamKalk = "ATL-H3";
                                rTetel.sMegjegyzes = "bal";
                                break;
                        }
                        
                        rTetel.dMennyiseg = 1;
                        AddTetel(rTetel, ref rBontas);
                    }

                    if (rSV.rRendszer.sRendszerTipus == "swing_door_only_normal")
                    {
                        rTetel = new struTetel();
                        switch (rAjto.sOpciokNyiloAjtoID)
                        {
                            case "0":
                                rTetel.sCikkszamKalk = "ATL-KS";
                                break;
                            case "1":
                                rTetel.sCikkszamKalk = "ATL-KK";
                                break;
                            case "2":
                                rTetel.sCikkszamKalk = "ATL-KWC";
                                break;
                        }
                        rTetel.dMennyiseg = 1;
                        AddTetel(rTetel, ref rBontas);
                    }

                    if (rSV.rRendszer.sRendszerTipus == "sliding_door_external")
                    {
                        rTetel = new struTetel();
                        switch (rAjto.sOpciokNyiloAjtoID)
                        {
                            case "0":
                                rTetel.sCikkszamKalk = "ATL-SL";
                                break;
                            case "1":
                                rTetel.sCikkszamKalk = "ATL-FF";
                                break;

                            case "2":
                                rTetel.sCikkszamKalk = "ATL-SW";
                                break;
                            case "3":
                                rTetel.sCikkszamKalk = "ATL-SWF";
                                break;

                            case "4":
                                rTetel.sCikkszamKalk = "ATL-SC";
                                break;
                        }
                        rTetel.dMennyiseg = 1;
                        AddTetel(rTetel, ref rBontas);
                    }

                }

            }

            //tolóajtó vége
            //tok

            if (rSV.rRendszer.sRendszerTipus == "swing_door_with_slim_alu_case" || rSV.rRendszer.sRendszerTipus == "swing_door_with_thin_alu_case")
            {
                struAjto rAjto = rRendszer.rAjto[1];

                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "ATL-801";
                rTetel.dMennyiseg = ((rRendszer.nNyilasMagassag + 27) * 2 + (rRendszer.nNyilasSzelesseg + 54)) / 1000;
                AddTetel(rTetel, ref rBontas);

                rTetel = new struTetel();
                rTetel.sCikkszamKalk = "ATL-802";
                rTetel.dMennyiseg = ((rRendszer.nNyilasMagassag + 40) * 2 + (rRendszer.nNyilasSzelesseg + 80)) / 1000;
                AddTetel(rTetel, ref rBontas);

                rTetel = new struTetel();
                rTetel.sCikkszamKalk = rRendszer.sRendszerTipus == "swing_door_with_slim_alu_case" ? "ATL-804" : "ATL-803";
                rTetel.dMennyiseg = ((rRendszer.nNyilasMagassag + 40) * 2 + (rRendszer.nNyilasSzelesseg + 80)) / 1000;
                AddTetel(rTetel, ref rBontas);

                rTetel = new struTetel();
                rTetel.sCikkszamKalk = "ATL-SWJ";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);

            } //tok vége
            
            //gyártási és csomagolási költség
            if (rRendszer.sRendszerTipus == "sliding_door_external")
            {
                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-SLT";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);

                rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-SL";
                rTetel.dMennyiseg = rRendszer.nAjtokSzama;
                AddTetel(rTetel, ref rBontas);
            }

            if (rRendszer.sRendszerTipus == "sliding_door_internal")
            {
                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-FF";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);
            }

            if (rRendszer.sRendszerTipus == "swing_door_only_normal")
            {
                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-SW";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);
            }

            if (rRendszer.sRendszerTipus == "swing_door_only_fix")
            {
                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-SWF";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);
            }

            if (rRendszer.sRendszerTipus == "screen")
            {
                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-SC";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);
            }

            if (rRendszer.sRendszerTipus == "swing_door_with_slim_alu_case" || rRendszer.sRendszerTipus == "swing_door_with_thin_alu_case")
            {
                struTetel rTetel = new struTetel();
                rTetel.sCikkszamKalk = "SERV-SWJ";
                rTetel.dMennyiseg = 1;
                AddTetel(rTetel, ref rBontas);
            }

            NameValueCollection nvcCikkKalk = new NameValueCollection();
            nvcCikkKalk["CIKKSZAM_KALK"] = "";
            nvcCikkKalk["CIKKSZAM_WD"] = "";
            nvcCikkKalk["ME"] = "";
            nvcCikkKalk["EGYSEGAR"] = "";

            rRendszer.dAr = 0;
            for (int i = 0; i < rBontas.Length; i++ )
            {
                struTetel rTetel = new struTetel();
                rTetel = rBontas[i];

                nvcCikkKalk["CIKKSZAM_KALK"] = rTetel.sCikkszamKalk;
                sResult += getKalkCikk(ref nvcCikkKalk);

                rTetel.sME = nvcCikkKalk["ME"];
                rTetel.sCikkszamKalk = nvcCikkKalk["CIKKSZAM_KALK"];
                rTetel.sCikkszamWD = nvcCikkKalk["CIKKSZAM_WD"];
                bool bSiker = Decimal.TryParse(nvcCikkKalk["EGYSEGAR"], out rTetel.dEgysegAr);
                rTetel.dAr = rTetel.dEgysegAr * rTetel.dMennyiseg;
                rRendszer.dAr += rTetel.dAr;

                if (rTetel.sME == "szet")
                {
                    NameValueCollection[] nvcSzett = new NameValueCollection[1];
                    NameValueCollection nvcSzettCikk = new NameValueCollection();

                    nvcSzettCikk["CIKKSZAM_SZETT"] = rTetel.sCikkszamKalk;
                    nvcSzettCikk["CIKKSZAM_WD"] = "";
                    nvcSzettCikk["MEGNEVEZES"] = "";
                    nvcSzettCikk["MENNYISEG"] = "";
                    nvcSzettCikk["ME"] = "";
                    nvcSzettCikk["E_ATXML81110SE"] = "";

                    nvcSzett[0] = nvcSzettCikk;

                    sResult += getSzett(ref nvcSzett);

                    rTetel.rBontas = new struTetel[0];
                    foreach (NameValueCollection nvcCikk in nvcSzett)
                    {
                        struTetel rSzettBontas = new struTetel();
                        rSzettBontas.sCikkszamWD = nvcCikk["CIKKSZAM_WD"];
                        rSzettBontas.sSzettCikkszam = nvcCikk["CIKKSZAM_SZETT"];
                        rSzettBontas.sNev = nvcCikk["MEGNEVEZES"];
                        rSzettBontas.sME = nvcCikk["ME"];
                        rSzettBontas.sMuveletNev = nvcCikk["E_ATXML81110SE"];
                        sResult += AddTetel(rSzettBontas, ref rTetel.rBontas);
                    }
                    

                }
                
                rBontas[i] = rTetel;

            }

            struTetel[] rBovitettBontas = new struTetel[0];
            foreach (struTetel rTetel in rBontas)
            {
                if (rTetel.rBontas == null)
                    AddTetel(rTetel, ref rBovitettBontas);
                else
                    AddTetel(rTetel.rBontas, ref rBovitettBontas);
            }

            for (int i = 0; i < rBovitettBontas.Length; i++)
            {
                if (string.IsNullOrEmpty(rBovitettBontas[i].sNev))
                    rBovitettBontas[i].sNev = rBovitettBontas[i].sCikkszamKalk;

                rBovitettBontas[i].sCikksz = rBovitettBontas[i].sCikkszamWD;
            }

                rSV.rBontas = rBovitettBontas;

            rSV.rRendszer = rRendszer;

           return sResult;

        }

        public static bool checkWDTechKod(string sTechKod)
        {
            bool bCikkszamFound = false;
            //string sPRname = "";

            SqlConnection myConnection = new SqlConnection(Common.sWDConnection);

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT [TI_IDENTIFIER] FROM[WD_eles].[dbo].[PC_TECHINSTRUCTIONS] Where [TI_IDENTIFIER] = '" + sTechKod + "'", myConnection);

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string sFoundTechKod = myReader["TI_IDENTIFIER"].ToString();
                    bCikkszamFound = sFoundTechKod.Equals(sTechKod);

                    Console.WriteLine(sTechKod);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return bCikkszamFound;
            //return sPRname;
        }

        public static bool validateTags(ref struSiteVariables rSV, bool bClean = true)
        {
            bool bHiba = false;
            rSV.sHiba = null;

            string sEmpty = null;

            rSV.sHiba += rSV.rFej.sPartnerKod == "C01071" ? "Ismeretlen partnerkód" : sEmpty;

            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sTechnologiaKod) ? " sTechnologiaKod" : sEmpty;

            string sRegex = "";
            //sRegex = @"^(E_)?[A-Z]{2}XML[0-9]{5}[A-Z]{2}$";
            sRegex = @"^(LSXML91110)(SR|ST|CS)(_E)?$";

            Regex rgxTechKod = new Regex(sRegex);
            bool bRgxTechKod = rgxTechKod.IsMatch(rSV.rFej.sTechnologiaKod);
            rSV.sHiba += bRgxTechKod ? sEmpty : " Érvénytelen formátumú sTechnologiaKod";

            bool bTechKodFoundInWD = checkWDTechKod(rSV.rFej.sTechnologiaKod);
            rSV.sHiba += bTechKodFoundInWD ? sEmpty : " sTechnologiaKod értéke hiányzik WD-ből";

            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sArkepzoSzam) ? " sArkepzoSzam" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sRendelesSzam) ? " sRendelesSzam" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sTermekNev) ? " sTermekNev" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sPartnerKod) ? " sPartnerKod" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sDatum) ? " sDatum" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sValuta) ? " sValuta" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sHatarido) ? " sHatarido" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sRaktarkod) ? " sRaktarkod" : sEmpty;
            rSV.sHiba += string.IsNullOrEmpty(rSV.rFej.sRajzURL) ? " sRajzURL" : sEmpty;

            rSV.sHiba += rSV.rFej.nGyartasMunkanapok == 0 ? " nGyartasMunkanapok" : sEmpty;
            rSV.sHiba += rSV.rFej.nSzallitasMunkanapok == 0 ? " nSzallitasMunkanapok" : sEmpty;
            rSV.sHiba += rSV.rFej.nVAMTSZ == 0 ? " nVAMTSZ" : sEmpty;
            rSV.sHiba += rSV.rRendszer.nDarab == 0 ? " nDarab" : sEmpty;
            rSV.sHiba += rSV.rRendszer.dSuly == 0 ? " dSuly" : sEmpty;
            rSV.sHiba += rSV.rRendszer.dAr == 0 ? " dAr" : sEmpty;

            if (rSV.rBontas != null)
                for (int i = 0; i < rSV.rBontas.Length; i++)
                {
                    rSV.rBontas[i].sHiba = null;

                    rSV.rBontas[i].sHiba += string.IsNullOrEmpty(rSV.rBontas[i].sCikksz) ? " sCikksz" : sEmpty;
                    rSV.rBontas[i].sHiba += string.IsNullOrEmpty(rSV.rBontas[i].sMuveletNev) ? " sMuveletNev" : sEmpty;
                    rSV.rBontas[i].sHiba += string.IsNullOrEmpty(rSV.rBontas[i].sME) ? " sME" : sEmpty;
                    rSV.rBontas[i].sHiba += string.IsNullOrEmpty(rSV.rBontas[i].sNev) ? " sNev" : sEmpty;
                    //rSV.rBontas[i].dMennyiseg = (decimal)rSV.rBontas[i].dblMennyiseg;
                    rSV.rBontas[i].sHiba += rSV.rBontas[i].dMennyiseg == 0 ? " dMennyiseg" : sEmpty;

                    if (bClean)
                    {
                        rSV.rBontas[i].sCikkszamKalk = sEmpty;
                        rSV.rBontas[i].sCikkszamRaktar = sEmpty;
                        rSV.rBontas[i].sCikkszamWD = sEmpty;
                        rSV.rBontas[i].sSzettCikkszam = sEmpty;
                    }

                    rSV.rBontas[i].sMeret = string.IsNullOrWhiteSpace(rSV.rBontas[i].sMeret) ? sEmpty : rSV.rBontas[i].sMeret;

                    rSV.rBontas[i].sHiba = string.IsNullOrEmpty(rSV.rBontas[i].sHiba) ? null : rSV.rBontas[i].sHiba;
                    bHiba |= !string.IsNullOrEmpty(rSV.rBontas[i].sHiba);
                }

            rSV.sHiba = string.IsNullOrEmpty(rSV.sHiba) ? null : rSV.sHiba;

            bHiba |= !string.IsNullOrEmpty(rSV.sHiba);

            return bHiba;
        }

        public static string RemoveIllegalChars(string input)
        {
            string pattern = "[\\~#%&@*{}/:<>?!.,;'|\"]";
            string replacement = "_";

            Regex regEx = new Regex(pattern);
            string sanitized = Regex.Replace(regEx.Replace(input, replacement), @"\s+", " ");
            return sanitized;
        }

        public static void SaveToWD(struSiteVariables rSVin)
        {
            struSiteVariables rSV = new struSiteVariables(rSVin);

            rSV.rFej.sTechnologiaKod = "E_ATXML81110SE";

            string sCalcName = rSV.sCalcID;
            string sArkepzoSzam = rSV.rFej.sArkepzoSzam; //.Trim();
            string sSajatRendelesSzam = rSV.rFej.sSajatRendelesSzam; //.Trim();
            string sRendelesSzam = rSV.rFej.sRendelesSzam; //.Trim();

            rSV.rFej.sPartnerKod = "C01088";
            /*
            if (rSV.rFej.sPartnerKod == "" || rSV.rFej.sPartnerKod == null || rSV.rFej.sPartnerKod == "C01071")
                rSV.rFej.sPartnerKod = getWDPKod(rSV.rFej.nCeg == 1 ? rSV.rFej.nRendeloCegKey : rSV.rFej.nCeg);
             */

            string sPartnerKod = rSV.rFej.sPartnerKod;
            string sEv = rSV.rFej.nEv.ToString();
            string sRendSrsz = rSV.rFej.nSorszam.ToString().PadLeft(5, '0');
            string sTetsz = rSV.rFej.nTetelSzam.ToString().PadLeft(2, '0');
            
            string sFileName = sCalcName + "_" + sRendelesSzam + "_" + sTetsz + "_" + sPartnerKod + "_" + sSajatRendelesSzam;
            sFileName = RemoveIllegalChars(sFileName);

            bool bMissingTags = validateTags(ref rSV, !(Common.bDebugMode && Common.bLocalMode));
            bool bTimeStamp = true;
            string sTimeStamp = bTimeStamp ? DateTime.Now.ToString("yyyyMMdd_HHmmss") : null;
            string sXMLPath = Common.sXMLFileSaveFolderURL + (bMissingTags ? @"HIANYOS\" : @"IMPORT\") + sFileName + "_" + sTimeStamp + ".xml";
            
          
            
            SaveToXml(rSV, sXMLPath);

        }

        public static string SaveToXml(struSiteVariables rSV, string sXMLPath)
        {
            string sResult = "";

            XmlSerializer writer = new XmlSerializer(rSV.GetType());

            try
            {
                StreamWriter file = new StreamWriter(sXMLPath);

                try
                {
                    writer.Serialize(file, rSV);
                }
                catch (Exception ex)
                {
                    sResult = ex.ToString();
                    sResult += sXMLPath;
                }
                finally
                {
                    file.Close();
                }

            }
            catch
            {

            }

            return sResult;

        }

    }
}

