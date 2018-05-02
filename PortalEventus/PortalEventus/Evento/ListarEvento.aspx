﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ListarEvento.aspx.cs" Inherits="PortalEventus.Evento.ListarEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 710px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <table class="w-100">
        <tr style="text-align: center; font-size: 23px">
            <td colspan="2">Listar Evento</td>
        </tr>
        <tr>
            <td class="auto-style1">Descripción:</td>
            <td>Categoria;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:TextBox ID="txtDescripcion" runat="server" Width="396px"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="234px"></asp:DropDownList>
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
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
