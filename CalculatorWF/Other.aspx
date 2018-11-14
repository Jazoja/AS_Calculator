<%@ Page Title="Egyéb alkatrész és szálanyag" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Other.aspx.cs" Inherits="CalculatorWF.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

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
    <hgroup class="title">
    </hgroup>
</asp:Content>