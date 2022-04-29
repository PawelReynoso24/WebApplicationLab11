<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationLab11.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Borrar</p>
    <p>
        &nbsp;</p>
    <p>
        Carné:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Buscar" />
    </p>
    <p>
        Nombre:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        Apellido:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Eliminar Alumno" />
    </p>
</asp:Content>
