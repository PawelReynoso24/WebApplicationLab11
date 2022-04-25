<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationLab11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Alumnos</h1>
        <p>Universidad:&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Mesoamericana</asp:ListItem>
                <asp:ListItem>Landívar</asp:ListItem>
                <asp:ListItem>San Carlos</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Alumnos:</p>
        <p>Nombre:&nbsp;
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p>Apellido:&nbsp;
            <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        </p>
        <p>Notas:</p>
        <p>Curso:&nbsp;
            <asp:TextBox ID="TextBoxCurso" runat="server"></asp:TextBox>
        </p>
        <p>Punteo:&nbsp;
            <asp:TextBox ID="TextBoxPunteo" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonAgregarNota" runat="server" OnClick="ButtonAgregarNota_Click" Text="Agregar Nota del Alumno" Width="285px" />
        </p>
        <p>
            <asp:Button ID="ButtonAgregarUni" runat="server" Text="Agregar Alumno a la Universidad" />
        </p>
        <p>
            <asp:Button ID="ButtonAgregarUniconsusAlumnos" runat="server" Text="Agregar Universidad con sus Alumnos" Width="454px" />
        </p>
    </div>

</asp:Content>
