<%@ Page Title="" Language="C#" MasterPageFile="~/Secondary.Master" AutoEventWireup="true" CodeBehind="RegisterAccount.aspx.cs" Inherits="PortalEventus.RegisterAccount" %>


<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <script type="text/javascript">
        function Selectradio(rb) {
            if (document.getElementById(rb) = 'rFemenino') {
                document.getElementById('rMasculino').checked = false;
            }
            else {
                document.getElementById('rFemenino').checked = false;
            }
        }
    </script>

    <div class="panel" runat="server">
    </div>
    <div style="position: absolute; z-index: 1;" id="capa1">
        <div class="form-group">
            <label for="nombre">Nombres</label>
            <input type="text" class="form-control" id="txtNombre" placeholder="Nombre" />
            <label for="apellido">Apellidos</label>
            <input type="text" class="form-control" id="txtApellido" placeholder="Apellido" />
            <label for="usuario">Nombre de usuario</label>
            <input type="text" class="form-control" id="txtUsusario" placeholder="UsuarioEventus" />
            <label for="correo">Correo electrónico</label>
            <input type="text" class="form-control" id="txtCorreo" placeholder="correoejemplo@email.com" />
            <label for="contraseña">Contraseña</label>
            <input type="password" class="form-control" id="txtContraseña" placeholder="UsuarioEventus" />
            <label for="contraseña">Sexo</label>
            <%--            <input type="radio" class="form-control" id="rbMasculino" title="Masculino" />
            <input type="radio" class="form-control" id="rbFemenino" title="Femenino" />--%>
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <input type="radio" id="rMasculino" aria-label="Masculino" onclick="Selectradio(this);"/>
                    </div>
                </div>
                <input type="text" class="form-control" placeholder="Masculino" readonly="true"/>
            </div>
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <input type="radio" id="rFemenino" aria-label="Masculino"  onclick="Selectradio(this);"/>
                    </div>
                </div>
                <input type="text" class="form-control" placeholder="Femenino" readonly="true" />
            </div>
            <div></div>
        </div>
    </div>
</asp:Content>
