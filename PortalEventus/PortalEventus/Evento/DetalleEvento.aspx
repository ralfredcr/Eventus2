<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DetalleEvento.aspx.cs" Inherits="PortalEventus.Evento.DetalleEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <table class="w-100">
        <tr style="text-align: center; font-size: 23px">
            <td colspan="2">Detalle Evento</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Titulo:</td>

        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtTitulo" runat="server" Width="650px" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Descripción:</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server" Width="650px" Enabled="false"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Categoria:</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtCategoria" runat="server" Width="650px" Enabled="false"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Imagen:</td>
        </tr>
        <tr>
            <td>
               
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" Height="200px" Width="450px" />
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Fecha Inicio:</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtFechaInicio" runat="server"  TextMode="DateTimeLocal" Enabled="false"/>
            </td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Fecha Fin:</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtFechaFin" runat="server" TextMode="DateTimeLocal" Enabled="false" />
            </td>
        </tr>
        <tr>
            <td>
               &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                 <asp:Button ID="btnReservar" runat="server" Text="Reservar Evento" Width="300" />
                <asp:Button ID="btnSalir" runat="server" Text="Regresar" Width="300" OnClick="btnSalir_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
