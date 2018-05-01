<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAccount.aspx.cs" Inherits="PortalEventus.Registro.RegisterAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<div style="position: absolute; left:30%; top:20%" id="capa1">
    <form id="form" runat="server">
        <table>
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>Apellido</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
                <td>Contrase;a</td>
                <td>
                    <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
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
                        <asp:ListItem Value="rbMasculino" Text="Masculino"></asp:ListItem>
                        <asp:ListItem Value="rbFememnino" Text="Femenino"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>Nacionalidad</td>
                <td>
                    <asp:RadioButtonList ID="rbNacionalidad" runat="server">
                        <asp:ListItem Value="rbPeruana" Text="Peruana"></asp:ListItem>
                        <asp:ListItem Value="rbExtranjera" Text="Extranjera"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Tipo documento</td>
                <td>
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server"></asp:DropDownList>
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
            <tr>
                <td>Pais</td>
                <td>
                    <asp:DropDownList ID="ddlPais" runat="server"></asp:DropDownList>
                </td>
                <td>Departamento</td>
                <td>
                    <asp:DropDownList ID="ddlDepartamento" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Provincia</td>
                <td>
                    <asp:DropDownList ID="ddlProvincia" runat="server"></asp:DropDownList>
                </td>
                <td>Distrito</td>
                <td>
                    <asp:DropDownList ID="ddlDistrito" runat="server"></asp:DropDownList>
                </td>
            </tr>

        </table>
       </form>
    </div>
</body>
</html>
