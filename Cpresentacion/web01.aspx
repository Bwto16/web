<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Cpresentacion.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login-box">
        <img  src="imagenes/user.png"/>
        <h1>Iniciar Sesion</h1>
        <form>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="TxtUsuario" runat="server" Text="Usuario"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TxtPass" runat="server" Text="Password" MaxLength="16" TextMode="Password"></asp:TextBox>
            <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" />
            <a href="#">Recuperar contraseña</a>
        </form>
    </div>

    </asp:Content>
