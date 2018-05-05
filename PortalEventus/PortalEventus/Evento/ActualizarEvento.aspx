<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ActualizarEvento.aspx.cs" Inherits="PortalEventus.Evento.ActualizarEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div id="boxevent" class="container-fluid">
        <div class="container bkbox">
            <div class="frmbox">
                <div class="titlebox">
                    <p class="tittle">Actualizar Evento</p>
                </div>
                <div class="controlbox">
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2 text-left">Título del Evento:</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2"></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-10"><asp:TextBox ID="txtTitulo" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2 text-left">Descripción del Evento:</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2"></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-10"><asp:TextBox ID="txtDescripcion" CssClass="form-control form-control-sm" runat="server" TextMode="MultiLine" Height="100px"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2 text-left">Palabras Claves:</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2"></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-10"><asp:TextBox ID="txtDescripcionAdicional" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-5">
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Fecha y Hora de Inicio:</div>
                            </div>
                            <div class="row pb-3">
                                <div class="col-md-12"><asp:TextBox ID="txtFechaInicio" CssClass="form-control form-control-sm" runat="server"  TextMode="DateTimeLocal" /></div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Fecha y Hora de Termino:</div>
                            </div>
                            <div class="row pb-3">
                                <div class="col-md-12"><asp:TextBox ID="txtFechaFin" CssClass="form-control form-control-sm" runat="server" TextMode="DateTimeLocal" /></div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Cetegoría del Evento:</div>
                            </div>
                            <div class="row pb-3">
                                <div class="col-md-12"><asp:DropDownList ID="cboCategoria" CssClass="form-control form-control-sm" runat="server"></asp:DropDownList></div>
                            </div>
                        </div>
                        <div class="col-md-5">
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Imagen del Evento:</div>
                            </div>
                            <div class="row pb-3">
                                <asp:FileUpload ID="FileUpload1" CssClass="form-control form-control-sm" runat="server" />
                                <asp:Image ID="Image1" runat="server" CssClass="img-fluid" Height="250px"/>
                            </div>
                        </div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-10 linetopbox"></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2 text-left">Listar Eventos</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2"></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-10">
                            <asp:GridView ID="gZona" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="num" HeaderText="Nro" />
                                    <asp:TemplateField HeaderText="Zona">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtZona" CssClass="form-control form-control-sm" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"zona")  %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Precio">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtPrecio" CssClass="form-control form-control-sm" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"precio") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Cantidad Máximo">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtCantidad" CssClass="form-control form-control-sm" runat="server" Text='<%# Eval("cantidadMax") %>'></asp:TextBox>
                                        </ItemTemplate>

                                    </asp:TemplateField>
                                </Columns>
                                <HeaderStyle Height="20px" />
                            </asp:GridView>
                        </div>
                        <div class="col-md-1"></div>
                    </div>
                </div>
                <div class="footerbox">
                    <div class="row">
                        <div class="col-md-12"></div>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class="row pb-5 pt-4">
                <div class="col-md-4"></div>
                <div class="col-md-2">
                    <asp:Button ID="btnGrabar" runat="server" CssClass="form-control btn-info" Text="Grabar" OnClick="btnGrabar_Click" />
                </div>
                <div class="col-md-2">
                    <asp:Button ID="btnSalir" runat="server" CssClass="form-control btn-light" Text="Cancelar" />
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </div>
</asp:Content>
