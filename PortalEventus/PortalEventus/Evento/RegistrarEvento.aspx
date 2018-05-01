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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtTitulo" runat="server" Width="650px"></asp:TextBox>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Descripción:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server" Width="650px"></asp:TextBox>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Descripción Adicional:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="650px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Categoria:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="650px"></asp:DropDownList>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Fecha Inicio:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: blue; font-size: 18px">Fecha Fin:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Width="300" OnClick="btnGrabar_Click" />
                <asp:Button ID="btnSalir" runat="server" Text="Salir" Width="300" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>



</asp:Content>
