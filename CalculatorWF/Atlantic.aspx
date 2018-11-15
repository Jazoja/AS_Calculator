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
        
          <div class="col-md-4">
            <asp:Label ID="lblRendszerTipus" runat="server" Text="Rendszer"/>
            <br />
            <asp:DropDownList ID="ddlRendszerTipus" runat="server" AutoPostBack="true"/>
          </div>
        
          <div class="col-md-2">
            <asp:Label ID="lblBeepitesiMod" runat="server" Text="Beépítési mód"/>
            <br />
            <asp:DropDownList ID="ddlBeepitesiMod" runat="server" AutoPostBack="true"/>
          </div>

        <div class="col-md-2">
            <asp:Label ID="lblSinekSzama" runat="server" Text="Sínek száma"/>
            <br />
            <asp:DropDownList ID="ddlSinekSzama" runat="server" AutoPostBack="true"/>
        </div>

        <div class="col-md-2">
            <asp:Label ID="lblSinHossza" runat="server" Text="Sín hossza"/>
            <br />
            <asp:TextBox ID="edSinHossza" runat="server"/>
        </div>

        <div class="col-md-2">
            <asp:Label ID="lblAjtokSzama" runat="server" Text="Ajtók száma"/>
            <br />
            <asp:DropDownList ID="ddlAjtokSzama" runat="server" AutoPostBack="true"/>
        </div>

      </div>
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
            <div class="col-md-2">
                <asp:Label ID="lblAjtoMeret" runat="server" Text="Ajtó méret"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto1" runat="server" Text="Ajtó 1"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto2" runat="server" Text="Ajtó 2"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto3" runat="server" Text="Ajtó 3"/>
            </div>

            <div class="col-md-2">
                <asp:Label ID="lblAjto4" runat="server" Text="Ajtó 4"/>
            </div>

            <div class="col-md-2">
                
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblMagassag" runat="server" Text="Magasság"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto1" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto2" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto3" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edMagassagAjto4" runat="server"/>
            </div>

            <div class="col-md-2">
                
            </div>
        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblSzelesseg" runat="server" Text="Szélesség"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto1" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto2" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto3" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:TextBox ID="edSzelessegAjto4" runat="server"/>
            </div>

            <div class="col-md-2">
                
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblAjtoBetet" runat="server" Text="Ajtó betét"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet1" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet2" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet3" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlAjtoBetet4" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblVasalat" runat="server" Text="Vasalat"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat1" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat2" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat3" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlVasalat4" runat="server" AutoPostBack="true"/>
            </div>

        </div>

        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblOsztokSzama" runat="server" Text="Osztók száma"/>
            </div>

            
            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto1" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto2" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto3" runat="server"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOsztokSzamaAjto4" runat="server"/>
            </div>

            <div class="col-md-2">
                
            </div>

        </div>
        
        <div class="row">
            <div class="col-md-2">
                <asp:Label ID="lblOpciok" runat="server" Text="Opciók"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto1" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto2" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto3" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
                <asp:DropDownList ID="ddlOpciokAjto4" runat="server" AutoPostBack="true"/>
            </div>

            <div class="col-md-2">
            </div>

        </div>

    </div>

</asp:Content>