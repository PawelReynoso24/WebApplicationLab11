<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WebApplicationLab11.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    Actualizar</p>
<p>
    &nbsp;</p>
<p>
    Carné:&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar Alumno" />
</p>
<p>
    Nombre:&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    Apellido:&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button2" runat="server" Text="Modificar Alumno" />
</p>
</asp:Content>
