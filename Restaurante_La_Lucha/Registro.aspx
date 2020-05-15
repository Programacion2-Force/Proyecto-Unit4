<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Restaurante.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Nombre"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Digite su nombre"></asp:RequiredFieldValidator>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Apellidos"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Digite sus apellidos"></asp:RequiredFieldValidator>
    <br />
    <asp:TextBox ID="TextBox3" runat="server" placeholder="UserName"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Cree nombre su de Usuario"></asp:RequiredFieldValidator>
    <br />
    <asp:TextBox ID="TextBox4" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Cree una contraseña"></asp:RequiredFieldValidator>
    <br />
    <asp:TextBox ID="TextBox5" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Proporcione su Email"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Registrarme" OnClick="Button1_Click" />
    <br />
    <a href="Login.aspx">Ya tengo una cuenta</a>

</asp:Content>
