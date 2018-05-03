<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAccount.aspx.cs" Inherits="PortalEventus.Registro.RegisterAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<div style="position: absolute; left:10%; top:20%" id="capa1">
    <form id="form" runat="server">
        <table>
            <tr>
                <td>Nombres</td>
                <td colspan="3">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Apellido Paterno</td>
                <td>
                    <asp:TextBox ID="txtApeparterno" runat="server"></asp:TextBox>
                </td>
                <td>Apellido Materno</td>
                <td>
                    <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ingrese Contrase;a</td>
                <td>
                    <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
                </td>
                <td>Confirmar contrase;a</td>
                <td>
                    <asp:TextBox ID="txtContrasena2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Correo</td>
                <td colspan="3">
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Sexo</td>
                <td>
                    <asp:RadioButtonList ID="rbSexo" runat="server">
                        <asp:ListItem Value="1" Text="Masculino"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Femenino"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>Nacionalidad</td>
                <td>
                    <asp:RadioButtonList ID="rbNacionalidad" runat="server"  AutoPostBack="true"
                        OnSelectedIndexChanged="rbNacionalidad_SelectedIndexChanged">
                        <asp:ListItem Value="1" Text="Peruana"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Extranjera"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Tipo documento</td>
                <td>
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server">
                        <asp:ListItem Value="1" Text="DNI"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Carnet Extranjeria"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Pasaporte"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>Nro. documento</td>
                <td>
                    <asp:TextBox ID="txtNumeroDoc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefono</td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
                <td>Celular</td>
                <td>
                    <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha nacimiento</td>
                <td>
                    <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr id="trPais" runat="server">
                <td>Pais</td>
                <td colspan="3">
                    <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="true"
                        OnSelectedIndexChanged="ddlPais_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr id="trDepartamento" runat="server">
                <td>Departamento</td>
                <td>
                    <asp:DropDownList ID="ddlDepartamento" runat="server" AutoPostBack="true"
                        OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr id="trProvincia" runat="server">
                <td>Provincia</td>
                <td>
                    <asp:DropDownList ID="ddlProvincia" runat="server"  AutoPostBack="true"
                        OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                </td>
                <td>Distrito</td>
                <td>
                    <asp:DropDownList ID="ddlDistrito" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Ciudad</td>
                <td colspan="3">
                    <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Direccion</td>
                <td colspan="3">
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                </td>
                <td colspan="2">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
       </form>
    </div>
</body>
</html>
