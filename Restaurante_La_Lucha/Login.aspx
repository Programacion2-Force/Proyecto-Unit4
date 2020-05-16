<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Restaurante.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Username"></asp:TextBox><br />
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox><br />
    &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Entrar" CommandArgument='<%# Eval("username") %>' OnClick="Button1_Click"/>
    <br /><a href="Registro.aspx">No tengo cuenta</a>

</asp:Content>
