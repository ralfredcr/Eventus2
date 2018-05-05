<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ListarEvento.aspx.cs" Inherits="PortalEventus.Evento.ListarEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container-fluid">
        <div class="container bkboxvw">
            <div class="frmbox">                
                <div class="titlebox">
                    <p class="tittle">Listado de Eventos</p>
                </div>
                <div class="controlbox">
                    <div class="row">
                        <div class="col-md-4 ml-2 text-left">Descripción:</div>
                        <div class="col-md-3 ml-2 text-left">Fecha de Inicio:</div>
                        <div class="col-md-3 ml-2 text-left">Categoría</div>
                        <div class="col-md-2"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-4"><asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control form-control-sm"></asp:TextBox></div>
                        <div class="col-md-3"><asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control form-control-sm" TextMode="DateTimeLocal" /></div>
                        <div class="col-md-3"><asp:DropDownList ID="cboCategoria" runat="server" CssClass="form-control form-control-sm"></asp:DropDownList></div>
                        <div class="col-md-2"><asp:Button ID="btnBuscar" CssClass="btn btn-info btn-sm" runat="server" Text="Buscar Eventos" OnClick="btnBuscar_Click" /></div>
                    </div>
                </div>
                <div class="viewbox">
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataList ID="dtlEvents" runat="server" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal">
                                <ItemStyle BackColor="White" ForeColor="Black" BorderWidth="2px" CssClass="text-center" />
                                <ItemTemplate>
                                    <asp:Image ID="imgEvent" runat="server" Width="100px" ImageUrl='<%# ((Eval("RutaImagen") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("RutaImagen"))) %>'  />                                
                                    <br />
                                    <asp:Label ID="lblTitulo" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"titulo")  %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblCategoria" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"descripcionCateg")  %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="lblFecInicio" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"fechaInicio")  %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="FecFin" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"fechaFin")  %>'></asp:Label>
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <table class="w-100">
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
