<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Cpresentacion.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="login-S"> 
     <div class="login-box">
        <img class="User-L" src="imagenes/user.png"/>
        <h1>Iniciar Sesion</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="TxtUsuario" runat="server" placeholder="Usuario"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="TxtPass" runat="server" placeholder="Contraseña" MaxLength="16" TextMode="Password"></asp:TextBox>
            <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
            <a href="#">Recuperar contraseña</a>
        </div>
    </div>
    </section>
</asp:Content>
