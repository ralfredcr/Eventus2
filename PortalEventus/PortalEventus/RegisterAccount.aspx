<%@ Page Title="" Language="C#" MasterPageFile="~/Secondary.Master" AutoEventWireup="true" CodeBehind="RegisterAccount.aspx.cs" Inherits="PortalEventus.RegisterAccount" %>


<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <script type="text/javascript">
        function SelectradioSexo(rb) {
            if (document.getElementById(rb) = 'rFemenino') {
                document.getElementById('rMasculino').checked = false;
            }
            else if (document.getElementById(rb) = 'rFemenino') {
                document.getElementById('rFemenino').checked = false;
            }
        }
        function SelectradioNacionalidad(rb1) {
            if (document.getElementById(rb1) = 'rPeruana') {
                document.getElementById('rExtranjera').checked = false;
            }
            else if (document.getElementById(rb1) = 'rPeruana') {
                document.getElementById('rPeruana').checked = false;
            }
        }
        $(function () {
            $('#datetimepicker1').datetimepicker();
        });
    </script>

    <div class="panel" runat="server">
    </div>
    <div style="position: absolute; z-index: 1;" id="capa1">
        <div class="form-group">
            <label for="nombre">Nombres</label>
            <input type="text" class="form-control" id="txtNombre" placeholder="Nombre" runat="server" />
            <label for="apellido">Apellidos</label>
            <input type="text" class="form-control" id="txtApellido" placeholder="Apellido" runat="server" />
            <label for="usuario">Nombre de usuario</label>
            <input type="text" class="form-control" id="txtUsusario" placeholder="UsuarioEventus" runat="server" />
            <label for="correo">Correo electrónico</label>
            <input type="text" class="form-control" id="txtCorreo" placeholder="correoejemplo@email.com" runat="server" />
            <label for="contraseña">Contraseña</label>
            <input type="password" class="form-control" id="txtContraseña" placeholder="UsuarioEventus" runat="server" />
            <label for="sexo">Sexo</label>
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <input type="radio" id="rMasculino" aria-label="Masculino" runat="server" onclick="SelectradioSexo(this);" />
                    </div>
                </div>
                <input type="text" class="form-control" placeholder="Masculino" readonly="true" />
            </div>
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <input type="radio" id="rFemenino" aria-label="Masculino" runat="server" onclick="SelectradioSexo(this);" />
                    </div>
                </div>
                <input type="text" class="form-control" placeholder="Femenino" readonly="true" />
            </div>

            <label for="nacionalidad">País</label>
            <div class="dropdown">
                <a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="ddPais"
                    data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Pais
                </a>
                <div class="dropdown-menu" aria-labelledby="País" runat="server">
                </div>
            </div>

            <label for="nacionalidad">Nacionalidad</label>
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <input type="radio" id="rPeruana" aria-label="Peruana" runat="server" onclick="SelectradioNacionalidad(this);" />
                    </div>
                </div>
                <input type="text" class="form-control" placeholder="Peruana" readonly="true" />
            </div>
            <div class="input-group">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <input type="radio" id="rExtranjero" aria-label="Extranjera" runat="server" onclick="SelectradioNacionalidad(this);" />
                    </div>
                </div>
                <input type="text" class="form-control" placeholder="Extranjera" readonly="true" />
            </div>

            <label for="tipodoc">Tipo documento</label>
            <div class="dropdown">
                <a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="ddTipoDocumento"
                    data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Tipo documento
                </a>
                <div class="dropdown-menu" aria-labelledby="Tipo documento" runat="server">
                </div>
            </div>

            <label for="nombre">Número documento</label>
            <input type="text" class="form-control" id="txtNumeroDoc" placeholder="Numero documento" runat="server" />

            <label for="nombre">Fecha nacimiento</label>
            <div class="container">
                <div class="row">
                    <div class='col-sm-6'>
                        <div class="form-group">
                            <div class='input-group date' id='dtpFechaNacimiento'>
                                <input type='text' class="form-control" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <label for="telefono">Teléfono</label>
            <input type="text" class="form-control" id="txtTelefono" placeholder="Ingrese teléfono" runat="server" />

            <label for="celular">Celular</label>
            <input type="text" class="form-control" id="txtCelular" placeholder="Ingrese celular" runat="server" />
            <label for="direccion">Dirección</label>
            <input type="text" class="form-control" id="txtDireccion" placeholder="Ingrese dirección" runat="server" />

            <label for="Departamento">Departamento</label>
            <div class="dropdown">
                <a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="ddDepartamento"
                    data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Departamento
                </a>
<%--                <div class="dropdown-menu" runat="server">
                </div>--%>
            </div>

            <label for="Departamento">Provincia</label>
            <div class="dropdown">
                <a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="ddProvincia"
                    data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Provincia
                </a>
            </div>

            <label for="Departamento">Distrito</label>
            <div class="dropdown">
                <a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="ddDistrito"
                    data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Distrito
                </a>
            </div>
        </div>
    </div>
</asp:Content>
