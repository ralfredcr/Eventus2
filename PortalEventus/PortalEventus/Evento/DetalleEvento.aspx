<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DetalleEvento.aspx.cs" Inherits="PortalEventus.Evento.DetalleEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    
    <div id="boxevent" class="container-fluid">
        <div class="container bkbox">
            <div class="frmbox">
                <div class="titlebox">
                    <p class="tittle">Detalle Evento</p>
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
                        <div class="col-md-10"><asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control form-control-sm" Enabled="false"></asp:TextBox></div>
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
                        <div class="col-md-10"><asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control form-control-sm" Enabled="false" TextMode="MultiLine" Height="100px" ></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-5">
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Imagen del Evento:</div>
                            </div>
                            <div class="row pb-3">
                                <asp:Image ID="Image1" runat="server" CssClass="img-fluid" Height="250px"/>
                            </div>
                        </div>
                        <div class="col-md-5">
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Fecha y Hora de Inicio:</div>
                            </div>
                            <div class="row pb-3">
                                <div class="col-md-12"><asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control form-control-sm" TextMode="DateTimeLocal" Enabled="false"/></div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Fecha y Hora de Termino:</div>
                            </div>
                            <div class="row pb-3">
                                <div class="col-md-12"><asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control form-control-sm" TextMode="DateTimeLocal" Enabled="false" /></div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 ml-2 text-left">Cetegoría del Evento:</div>
                            </div>
                            <div class="row pb-3">
                                <div class="col-md-12"><asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control form-control-sm" Enabled="false"></asp:TextBox></div>
                            </div>
                        </div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-10 linetopbox"></div>
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
				    <asp:Button ID="btnReservar" runat="server" CssClass="form-control btn-info" Text="Reservar Evento" />
                    <asp:Button ID="btnActualizar" runat="server" CssClass="form-control btn-info" Text="Actualizar" OnClick="btnActualizar_Click" />
                </div>
                <div class="col-md-2">
                    <asp:Button ID="btnSalir" runat="server" CssClass="form-control btn-light" Text="Regresar" OnClick="btnSalir_Click" />
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </div>
</asp:Content>
