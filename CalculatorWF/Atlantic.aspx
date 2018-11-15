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
            <asp:Label ID="lblRendszer" runat="server" Text="Rendszer"/>
            <br />
            <asp:DropDownList ID="ddlSystems" runat="server" AutoPostBack="true"/>
          </div>
        
          <div class="col-md-2">
            <asp:Label ID="lblBeepitesiMod" runat="server" Text="Beépítési mód"/>
            <br />
            <asp:DropDownList ID="ddlBeepitesiMod" runat="server" AutoPostBack="true"/>
          </div>

        <div class="col-md-2">
            <asp:Label ID="lblSinekSzama" runat="server" Text="Sínek száma"/>
            <br />
            <asp:DropDownList ID="ddlSinekSZama" runat="server" AutoPostBack="true"/>
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
        </div>

        <div class="row">
            <div class="col-md-2">

            </div>
        </div>

        <div class="row">
            <div class="col-md-2">

            </div>
        </div>



    </div>


    
    

    


    

    

    

    

    <asp:Label ID="lblMagassag" runat="server" Text="Sín hossza"/>
    
    <asp:Label ID="lblSzelesseg" runat="server" Text="Sín hossza"/>

    <asp:Label ID="lblAjtoBetet" runat="server" Text="Ajtó betét"/>

    <asp:Label ID="lblVasalat" runat="server" Text="Vasalat"/>

    <asp:Label ID="lblOsztokSzama" runat="server" Text="Osztók száma"/>

    <asp:Label ID="lblOpciok" runat="server" Text="Opciók"/>

<br />

</asp:Content>