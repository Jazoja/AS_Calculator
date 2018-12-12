<%@ Page Title="Atlantic" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atlantic.aspx.cs" Inherits="CalculatorWF.Atlantic" %>

<asp:Content runat="server" ID="Header" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>XML generáló oldal</h2>
            </hgroup>
            <p>
                Lorem ipsum
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="container-fluid">

        <div class="row">
            <div class="col-md-2">
            </div>
            <div class="col-md-4">
            </div>
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row">

            <div class="col-md-4" runat="server" id="divRendszerTipus">
                <asp:Label ID="lblRendszerTipus" runat="server" Text="Rendszer" />
                <br />
                <asp:DropDownList ID="ddlRendszerTipus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlRendszerTipus_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>


        </div>

        <div class="row">
            <div class="col-md-2">

            </div>

            <div class="col-md-2" runat="server" id="divAjtokSzama">
                <asp:Label ID="lblAjtokSzama" runat="server" Text="Ajtók száma [db]" />
                <br />
                <asp:DropDownList ID="ddlAjtokSzama" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAjtokSzama_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divBeepitesiMod">
                <asp:Label ID="lblBeepitesiMod" runat="server" Text="Beépítési mód" />
                <br />
                <asp:DropDownList ID="ddlBeepitesiMod" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBeepitesiMod_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divSinekSzama">
                <asp:Label ID="lblSinekSzama" runat="server" Text="Sínek száma [db]" />
                <br />
                <asp:DropDownList ID="ddlSinekSzama" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSinekSzama_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divSinHossza">
                <asp:Label ID="lblSinHossza" runat="server" Text="Sín hossza [mm]" />
                <br />
                <asp:TextBox ID="edSinHossza" runat="server" AutoPostBack="true" OnTextChanged="edSinHossza_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divNyitasIranya">
            <asp:Label ID="lblNyitasIranya" runat="server" Text="Nyitás iránya" />
                <br />
                <asp:DropDownList ID="ddlNyitasIrany" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNyitasIrany_SelectedIndexChanged"/>
            </div>

        </div>

        <div class="row" runat="server" id="divNyilasMeretek">
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblNyilasMagassag" runat="server" Text="Nyílás magasság" />
                <br />
                <asp:TextBox ID="edNyilasMagassag" runat="server" AutoPostBack="true" OnTextChanged="edNyilasMagassag_TextChanged" />
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblNyilasSzelesseg" runat="server" Text="Nyílás szélesség" />
                <br />
                <asp:TextBox ID="edNyilasSzelesseg" runat="server" AutoPostBack="true" OnTextChanged="edNyilasSzelesseg_TextChanged"/>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblFalvastagság" runat="server" Text="Fal vastagság [mm]" />
                <br />
                <asp:TextBox ID="edFalvastagsag" runat="server" AutoPostBack="true" OnTextChanged="edFalvastagsag_TextChanged"/>
            </div>
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row" runat="server" id="divAjtoMeret">
            <div class="col-md-2">
                <asp:Label ID="lblAjtoMeret" runat="server" Text="Ajtó méret" />
            </div>

            <div class="col-md-2" runat="server" id="divAjto1">
                <asp:Label ID="lblAjto1" runat="server" Text="Ajtó 1" />
            </div>

            <div class="col-md-2" runat="server" id="divAjto2">
                <asp:Label ID="lblAjto2" runat="server" Text="Ajtó 2" />
            </div>

            <div class="col-md-2" runat="server" id="divAjto3">
                <asp:Label ID="lblAjto3" runat="server" Text="Ajtó 3" />
            </div>

            <div class="col-md-2" runat="server" id="divAjto4">
                <asp:Label ID="lblAjto4" runat="server" Text="Ajtó 4" />
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row" runat="server" id="divAjtoMagassag">
            <div class="col-md-2">
                <asp:Label ID="lblMagassag" runat="server" Text="Magasság [mm]" />
            </div>

            <div class="col-md-2" runat="server" id="divMagassagAjto1">
                <asp:TextBox ID="edMagassagAjto1" runat="server" ToolTip="Ajtó1 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divMagassagAjto2">
                <asp:TextBox ID="edMagassagAjto2" runat="server" ToolTip="Ajtó2 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divMagassagAjto3">
                <asp:TextBox ID="edMagassagAjto3" runat="server" ToolTip="Ajtó3 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divMagassagAjto4">
                <asp:TextBox ID="edMagassagAjto4" runat="server" ToolTip="Ajtó4 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
            </div>
        </div>

        <div class="row" runat="server" id="divAjtoSzelesseg">
            <div class="col-md-2">
                <asp:Label ID="lblSzelesseg" runat="server" Text="Szélesség [mm]" />
            </div>

            <div class="col-md-2" runat="server" id="divSzelessegAjto1">
                <asp:TextBox ID="edSzelessegAjto1" runat="server" ToolTip="Ajtó1 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divSzelessegAjto2">
                <asp:TextBox ID="edSzelessegAjto2" runat="server" ToolTip="Ajtó2 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divSzelessegAjto3">
                <asp:TextBox ID="edSzelessegAjto3" runat="server" ToolTip="Ajtó3 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divSzelessegAjto4">
                <asp:TextBox ID="edSzelessegAjto4" runat="server" ToolTip="Ajtó4 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row" runat="server" id="divAjtoBetet">
            <div class="col-md-2">
                <asp:Label ID="lblAjtoBetet" runat="server" Text="Ajtó betét" />
            </div>

            <div class="col-md-2" runat="server" id="divAjtoBetet1">
                <asp:DropDownList ID="ddlAjtoBetet1" runat="server" AutoPostBack="true" ToolTip="Ajtó1 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divAjtoBetet2">
                <asp:DropDownList ID="ddlAjtoBetet2" runat="server" AutoPostBack="true" ToolTip="Ajtó2 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divAjtoBetet3">
                <asp:DropDownList ID="ddlAjtoBetet3" runat="server" AutoPostBack="true" ToolTip="Ajtó3 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divAjtoBetet4">
                <asp:DropDownList ID="ddlAjtoBetet4" runat="server" AutoPostBack="true" ToolTip="Ajtó4 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row" runat="server" id="divVasalat">
            <div class="col-md-2">
                <asp:Label ID="lblVasalat" runat="server" Text="Vasalat" />
            </div>

            <div class="col-md-2" runat="server" id="divVasalat1">
                <asp:DropDownList ID="ddlVasalat1" runat="server" AutoPostBack="true" ToolTip="Ajtó1 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divVasalat2">
                <asp:DropDownList ID="ddlVasalat2" runat="server" AutoPostBack="true" ToolTip="Ajtó2 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divVasalat3">
                <asp:DropDownList ID="ddlVasalat3" runat="server" AutoPostBack="true" ToolTip="Ajtó3 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divVasalat4">
                <asp:DropDownList ID="ddlVasalat4" runat="server" AutoPostBack="true" ToolTip="Ajtó4 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

        </div>

        <div class="row" runat="server" id="divOsztokSzamaAjto">
            <div class="col-md-2">
                <asp:Label ID="lblOsztokSzamaAjto" runat="server" Text="Osztók száma [db]" />
            </div>


            <div class="col-md-2" runat="server" id="divOsztokSzamaAjto1">
                <asp:DropDownList ID="ddlOsztokSzamaAjto1" runat="server" ToolTip="Ajtó1 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOsztokSzamaAjto2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto2" runat="server" ToolTip="Ajtó2 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOsztokSzamaAjto3">
                <asp:DropDownList ID="ddlOsztokSzamaAjto3" runat="server" ToolTip="Ajtó3 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOsztokSzamaAjto4">
                <asp:DropDownList ID="ddlOsztokSzamaAjto4" runat="server" ToolTip="Ajtó4 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row" runat="server" id="divOpciokToloAjto">
            <div class="col-md-2">
                <asp:Label ID="lblOpciokToloAjto" runat="server" Text="Tolóajtó opciók" />
            </div>

            <div class="col-md-2" runat="server" id="divOpciokToloAjto1">
                <asp:DropDownList ID="ddlOpciokToloAjto1" runat="server" AutoPostBack="true" ToolTip="Tolóajtó1 opciók" OnSelectedIndexChanged="ddlOpciokToloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOpciokToloAjto2">
                <asp:DropDownList ID="ddlOpciokToloAjto2" runat="server" AutoPostBack="true" ToolTip="Tolóajtó2 opciók" OnSelectedIndexChanged="ddlOpciokToloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOpciokToloAjto3">
                <asp:DropDownList ID="ddlOpciokToloAjto3" runat="server" AutoPostBack="true" ToolTip="Tolóajtó3 opciók" OnSelectedIndexChanged="ddlOpciokToloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOpciokToloAjto4">
                <asp:DropDownList ID="ddlOpciokToloAjto4" runat="server" AutoPostBack="true" ToolTip="Tolóajtó4 opciók" OnSelectedIndexChanged="ddlOpciokToloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row" runat="server" id="divOpciokNyiloAjto">
            <div class="col-md-2">
                <asp:Label ID="lblOpciokNyiloAjto" runat="server" Text="Nyílóajtó opciók" />
            </div>

            <div class="col-md-2" runat="server" id="divOpciokNyiloAjto1">
                <asp:DropDownList ID="ddlOpciokNyiloAjto1" runat="server" AutoPostBack="true" ToolTip="Nyílóajtó1 opciók" OnSelectedIndexChanged="ddlOpciokNyiloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOpciokNyiloAjto2">
                <asp:DropDownList ID="ddlOpciokNyiloAjto2" runat="server" AutoPostBack="true" ToolTip="Nyílóajtó2 opciók" OnSelectedIndexChanged="ddlOpciokNyiloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOpciokNyiloAjto3">
                <asp:DropDownList ID="ddlOpciokNyiloAjto3" runat="server" AutoPostBack="true" ToolTip="Nyílóajtó3 opciók" OnSelectedIndexChanged="ddlOpciokNyiloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2" runat="server" id="divOpciokNyiloAjto4">
                <asp:DropDownList ID="ddlOpciokNyiloAjto4" runat="server" AutoPostBack="true" ToolTip="Nyílóajtó4 opciók" OnSelectedIndexChanged="ddlOpciokNyiloAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

    </div>

</asp:Content>
