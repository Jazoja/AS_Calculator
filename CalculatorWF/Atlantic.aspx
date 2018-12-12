<%@ Page Title="Atlantic" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atlantic.aspx.cs" Inherits="CalculatorWF.About" %>

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

            <div class="col-md-4">
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
            <div class="col-md-2">
                <asp:Label ID="lblBeepitesiMod" runat="server" Text="Beépítési mód" />
                <br />
                <asp:DropDownList ID="ddlBeepitesiMod" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBeepitesiMod_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblSinekSzama" runat="server" Text="Sínek száma" />
                <br />
                <asp:DropDownList ID="ddlSinekSzama" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSinekSzama_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblSinHossza" runat="server" Text="Sín hossza" />
                <br />
                <asp:TextBox ID="edSinHossza" runat="server" AutoPostBack="true" OnTextChanged="edSinHossza_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjtokSzama" runat="server" Text="Ajtók száma" />
                <br />
                <asp:DropDownList ID="ddlAjtokSzama" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAjtokSzama_SelectedIndexChanged"/>
            </div>
            <div class="col-md-2">
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblNyilasMagassag" runat="server" Text="Nyílás magasság" />
                <br />
                <asp:TextBox ID="edNyilasMagassag" runat="server" OnTextChanged="edNyilasMagassag_TextChanged" />
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblNyilasSzelesseg" runat="server" Text="Nyílás szélesség" />
                <br />
                <asp:TextBox ID="edNyilasSzelesseg" runat="server" OnTextChanged="edNyilasSzelesseg_TextChanged"/>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblFalvastagság" runat="server" Text="Fal vastagság" />
                <br />
                <asp:TextBox ID="edFalvastagsag" runat="server" OnTextChanged="edFalvastagsag_TextChanged"/>
            </div>
            <div class="col-md-2">
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblAjtoMeret" runat="server" Text="Ajtó méret" />
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto1" runat="server" Text="Ajtó 1" />
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto2" runat="server" Text="Ajtó 2" />
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto3" runat="server" Text="Ajtó 3" />
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto4" runat="server" Text="Ajtó 4" />
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblMagassag" runat="server" Text="Magasság" />
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto1" runat="server" ToolTip="Ajtó1 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto2" runat="server" ToolTip="Ajtó2 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto3" runat="server" ToolTip="Ajtó3 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto4" runat="server" ToolTip="Ajtó4 magasság" AutoPostBack="true" OnTextChanged="edMagassagAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
            </div>
        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblSzelesseg" runat="server" Text="Szélesség" />
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto1" runat="server" ToolTip="Ajtó1 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto2" runat="server" ToolTip="Ajtó2 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto3" runat="server" ToolTip="Ajtó3 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto4" runat="server" ToolTip="Ajtó4 szélesség" AutoPostBack="true" OnTextChanged="edSzelessegAjto_TextChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblAjtoBetet" runat="server" Text="Ajtó betét" />
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet1" runat="server" AutoPostBack="true" ToolTip="Ajtó1 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet2" runat="server" AutoPostBack="true" ToolTip="Ajtó2 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet3" runat="server" AutoPostBack="true" ToolTip="Ajtó3 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet4" runat="server" AutoPostBack="true" ToolTip="Ajtó4 betét" OnSelectedIndexChanged="ddlAjtoBetet_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblVasalat" runat="server" Text="Vasalat" />
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat1" runat="server" AutoPostBack="true" ToolTip="Ajtó1 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat2" runat="server" AutoPostBack="true" ToolTip="Ajtó2 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat3" runat="server" AutoPostBack="true" ToolTip="Ajtó3 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat4" runat="server" AutoPostBack="true" ToolTip="Ajtó4 vasalat" OnSelectedIndexChanged="ddlVasalat_SelectedIndexChanged"/>
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblOsztokSzama" runat="server" Text="Osztók száma" />
            </div>


            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto1" runat="server" ToolTip="Ajtó1 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto2" runat="server" ToolTip="Ajtó2 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto3" runat="server" ToolTip="Ajtó3 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto4" runat="server" ToolTip="Ajtó4 osztók száma" OnSelectedIndexChanged="ddlOsztokSzamaAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblOpciok" runat="server" Text="Opciók" />
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto1" runat="server" AutoPostBack="true" ToolTip="Ajtó1 opciók" OnSelectedIndexChanged="ddlOpciokAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto2" runat="server" AutoPostBack="true" ToolTip="Ajtó2 opciók" OnSelectedIndexChanged="ddlOpciokAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto3" runat="server" AutoPostBack="true" ToolTip="Ajtó3 opciók" OnSelectedIndexChanged="ddlOpciokAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto4" runat="server" AutoPostBack="true" ToolTip="Ajtó4 opciók" OnSelectedIndexChanged="ddlOpciokAjto_SelectedIndexChanged"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

    </div>

</asp:Content>
