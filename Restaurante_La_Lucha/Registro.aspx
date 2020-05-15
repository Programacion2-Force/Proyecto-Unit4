<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Restaurante.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Nombre"></asp:TextBox><br />
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Apellidos"></asp:TextBox><br />
    <asp:TextBox ID="TextBox3" runat="server" placeholder="UserName"></asp:TextBox><br />
    <asp:TextBox ID="TextBox4" runat="server" placeholder="Password"></asp:TextBox><br />
    <asp:TextBox ID="TextBox5" runat="server" placeholder="Email"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Registrarme" OnClick="Button1_Click" />
</asp:Content>
