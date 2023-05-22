<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UAI_SAP_ParcialPractice._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
            <h1 id="aspnetTitle">SAP practica pre parcial</h1>
            <p class="lead">Sistema de registro de clientes</p>

            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Button ID="Button1" runat="server" Text="Registrarse" OnClick="Button1_Click" />
            <br><br/>
            <asp:Label ID="lbl_info" runat="server" Text=""></asp:Label>
    </main>

</asp:Content>
