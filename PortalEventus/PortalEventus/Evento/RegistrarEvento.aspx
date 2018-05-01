<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RegistrarEvento.aspx.cs" Inherits="PortalEventus.Evento.RegistrarEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">



    <table class="w-100">
        <tr style="text-align: center; font-size: 23px">
            <td colspan="2">Registrar Evento</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Titulo:</td>

        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtTitulo" runat="server" Width="650px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Descripción:</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server" Width="650px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Descripción Adicional:</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtDescripcionAdicional" runat="server" Width="650px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Categoria:</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cboCategoria" runat="server" Width="650px"></asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Imagen:</td>
        </tr>
        <tr>
            <td>
                <input id="Upload" type="file" runat="server" style="width: 650px" />
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Fecha Inicio:</td>
        </tr>
        <tr>
            <td>
                <asp:Calendar ID="dtFechaInicio" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Fecha Fin:</td>
        </tr>
        <tr>
            <td>
                <asp:Calendar ID="dtFechaFin" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Width="300" OnClick="btnGrabar_Click" />
                <asp:Button ID="btnSalir" runat="server" Text="Salir" Width="300" />
            </td>
        </tr>
    </table>



</asp:Content>
