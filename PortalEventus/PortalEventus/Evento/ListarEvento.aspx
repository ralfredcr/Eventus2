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
                                <ItemStyle CssClass="text-center" Width="340px" />
                                <ItemTemplate>
                                    <asp:Image ID="imgEvent" CssClass="img-fluid" runat="server" Width="150px" ImageUrl='<%# ((Eval("RutaImagen") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("RutaImagen"))) %>'  />                                
                                    <br /><br />
                                    <asp:Label ID="lblTitulo" CssClass="font-weight-bold" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"titulo")  %>'></asp:Label>
                                    <br />
                                    <span class="alert-info">Categoría:</span>&nbsp;<asp:Label ID="lblCategoria" CssClass="font-weight-normal" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"descripcionCateg")  %>'></asp:Label>
                                    <br />
                                    <span class="alert-info">Fecha:</span>&nbsp;<asp:Label ID="lblFecInicio" CssClass="font-weight-light" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"fechaInicio", "{0:d/M/yyyy}")  %>'></asp:Label>
                                    <br />
                                    <span class="alert-info">Hora:</span>&nbsp;<asp:Label ID="Label1" CssClass="font-weight-light" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"fechaInicio", "{0: hh:mm tt}")  %>'></asp:Label>&nbsp;&nbsp;A&nbsp;&nbsp;<asp:Label ID="FecFin" CssClass="font-weight-light" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"fechaFin", "{0: hh:mm tt}")  %>'></asp:Label>
                                    <br /><br />
                                    <asp:LinkButton ID="lnkDetalle" CssClass="btn-info btn-sm" runat="server" PostBackUrl='<%# "DetalleEvento.aspx?eventoid="+Eval("eventoid") %>'>Ver Detalle</asp:LinkButton>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
