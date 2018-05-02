<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Security.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PortalEventus.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodylogin" runat="server">
    <div id="boxlogin" class="container-fluid">
        <div class="container bkbox">
            <div class="lbox">
                <div class="ibox">
                    <div class="imgbox">
                        <img src="../Assets/img/eventus.png" />
                    </div>
                    <div>
                        <h3>Bienvenido</h3>
                    </div>
                    <div>
                        <h6>Inicia sesión para ver más</h6>
                    </div>
                </div>
                <div class="formbox">
                    <p>Usuario:</p>
                    <div>
                        <asp:TextBox ID="tctUsuario" runat="server" CssClass="form-control" placeholder="Ingrese su usuario..."></asp:TextBox>
                    </div>
                    <br />
                    <p>Contraseña</p>
                    <div>
                        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" placeholder="Ingrese su contraseña..." TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="btnbox">
                    <div>
                        <asp:Button ID="btnLogin" runat="server" CssClass="form-control btn-info" Text="Iniciar Sesión" />
                    </div>
                </div>
                <div id="forgetbox" class="justify-content-end">
                    <div>
                        <asp:Button ID="lknForget" runat="server" CssClass="form-control btn-light btn-sm" Text="¿Olvidaste tu contraseña?" />
                    </div>
                </div>
                <div id="newbox">
                    ¿Todavía no estás en Eventus?&nbsp;&nbsp;<asp:LinkButton ID="lknSignUp" runat="server" CssClass="btn btn-outline-success btn-sm">Regístrate</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>