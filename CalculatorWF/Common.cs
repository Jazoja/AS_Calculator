using System;
using System.Xml.Serialization;

namespace CalculatorWF
{
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
        public double dEgysegAr;
        [XmlIgnoreAttribute]
        public double dErtek;
        [XmlIgnoreAttribute]
        public int nSorszam;
        [XmlIgnoreAttribute]
        public int nLevel;
        [XmlIgnoreAttribute]
        public int nCikktip;
        [XmlIgnoreAttribute]
        public int nRaktarCikktip;
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
        public short nSzelesseg;
        public short nMagassag;
        public string sBetet;
        public string sVasalat;
        public int nOsztokSzama;
        public string sOpciok;
    }

    public struct struRendszer
    {
        public string sRendszerTipus;
        
        public string sSin;
        public string sTok;

        public int nSinekSzama;
        public int nSinHossz;
        public int nAjtokSzama;

        public struAjto[] rAjto;

        public struRendszer(struRendszer rRendszer)
        {
            this.sRendszerTipus = rRendszer.sRendszerTipus;
            
            this.sSin = rRendszer.sSin;
            this.sTok = rRendszer.sTok;

            this.nSinekSzama = rRendszer.nSinekSzama;
            this.nSinHossz = rRendszer.nSinHossz;
            this.nAjtokSzama = rRendszer.nAjtokSzama;

            this.rAjto = new struAjto[rRendszer.rAjto.Length];
            rRendszer.rAjto.CopyTo(this.rAjto,0);
        }
    }

    public struct struSitevariables
    {
        public string sHiba;
        public string sCalcID;
        public struRendfej rFej;

        public struRendszer rRendszer;
        public struTetel[] rBontas;
    }

    public static class Common
    {
        public static void Calculate()
        {

        }
    }
}

