

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebsiteForParadigms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <asp:textbox runat="server" ID="Lab22_Textbox" OnTextChanged="Unnamed1_TextChanged"></asp:textbox>
        <asp:Button ID="Lab22_button" runat="server" OnClick="Lab22_button_Click" Text="Lab22" Width="101px" />
        <asp:Button ID="Lab51_button" runat="server" Height="25px" OnClick="Button1_Click" Text="Lab51" Width="103px" />
        <asp:Button ID="Lab24_button" runat="server" OnClick="Lab24_button_Click" Text="Lab2.4" Width="90px" />
    </div>

    <div class="row">
        <div class="col-md-4">
        <p>
            <asp:Label ID="Lab22_Label" runat="server" Text="Label"></asp:Label>
        </p>
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
