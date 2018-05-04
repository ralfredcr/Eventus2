<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ListarEvento.aspx.cs" Inherits="PortalEventus.Evento.ListarEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <table class="w-100">
        <tr style="text-align: center; font-size: 23px">
            <td colspan="2">Listar Evento</td>
        </tr>
        <tr>
            <td>Descripción:</td>
            <td>Categoria;</td>
        </tr>
        <tr>
            <td >
                <asp:TextBox ID="txtDescripcion" runat="server" Width="396px"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="cboCategoria" runat="server" Width="234px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Fecha Inicio:</td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtFechaInicio" runat="server"  TextMode="DateTimeLocal" />
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar Eventos" OnClick="btnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gEvento" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="titulo" HeaderText="titulo" />
                        <asp:BoundField DataField="descripcion" HeaderText="descripcion" />
                        <asp:BoundField DataField="descripcionAdicional" HeaderText="descripcionAdicional" />
                        <asp:BoundField DataField="descripcionCateg" HeaderText="descripcionCateg" />
                        <asp:BoundField DataField="fechaInicio" HeaderText="fechaInicio" />
                        <asp:BoundField DataField="fechaFin" HeaderText="fechaFin" />
                        <asp:BoundField DataField="estado" HeaderText="estado" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
