﻿<%@ Page Title="Atlantic" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atlantic.aspx.cs" Inherits="CalculatorWF.About" %>

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