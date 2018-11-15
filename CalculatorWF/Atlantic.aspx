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


    <asp:Label ID="lblRendszer" runat="server" Text="Rendszer"/>
    <asp:DropDownList ID="ddlSystems" runat="server" AutoPostBack="true"/>

    <asp:Label ID="lblBeepitesiMod" runat="server" Text="Beépítési mód"/>
    <asp:DropDownList ID="ddlBeepitesiMod" runat="server" AutoPostBack="true"/>

    <asp:Label ID="lblSinekSzama" runat="server" Text="Sínek száma"/>

    <asp:Label ID="lblSinHossza" runat="server" Text="Sín hossza"/>

    <asp:Label ID="lblAjtokSzama" runat="server" Text="Ajtók száma"/>

    <asp:Label ID="lblAjtoMeret" runat="server" Text="Ajtó méret"/>

    <asp:Label ID="lblmagassag" runat="server" Text="Sín hossza"/>
    
    <asp:Label ID="lblSzelesseg" runat="server" Text="Sín hossza"/>

    <asp:Label ID="lblAjtoBetet" runat="server" Text="Ajtó betét"/>

    <asp:Label ID="lblVasalat" runat="server" Text="Vasalat"/>

    <asp:Label ID="lblOsztokSzama" runat="server" Text="Osztók száma"/>

    <asp:Label ID="lblOpciok" runat="server" Text="Opciók"/>

<br />

</asp:Content>