<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Security.Master" AutoEventWireup="true" CodeBehind="RegisterAccount.aspx.cs" Inherits="PortalEventus.Registro.RegisterAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodylogin" runat="server">
    <div id="boxregister" class="container-fluid">
        <div class="container bkbox">
            <div class="lbox">
                <div class="ibox">
                    <div class="imgbox">
                        <img src="../Assets/img/eventus.png" />
                    </div>
                    <div>
                        <h6>Bienvenido</h6>
                        <span>Registrate y se parte de la comunidad de Eventus.</span>
                    </div>
                </div>
                <div class="formbox">
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2">Usuario</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2">Email</div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtUsuario" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtCorreo" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2">Contraseña</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2">Confirmar Contraseña</div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtContrasena" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtContrasena2" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-10 linetopbox"></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2">Nombres</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2">Sexo</div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtNombre" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4">
                            <asp:RadioButtonList ID="rbSexo" CssClass="form-check-input ml-1" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="1" Text="Masculino"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Femenino"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2">Apellido Paterno</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2">Apellido Materno</div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtApeparterno" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtApeMaterno" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2">Tipo Documento</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2">Número Documento</div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlTipoDocumento" CssClass="form-control form-control-sm" runat="server">
                                <asp:ListItem Value="1" Text="DNI"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Carnet Extranjeria"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtNumeroDoc" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-4 ml-2">Fecha Nacimiento</div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4 ml-2">Nacionalidad</div>
                        <div class="col-md-1"></div>
                    </div>
                    <div class="row pb-3">
                        <div class="col-md-1"></div>
                        <div class="col-md-4"><asp:TextBox ID="txtFechaNacimiento" CssClass="form-control form-control-sm" runat="server"></asp:TextBox></div>
                        <div class="col-md-2"></div>
                        <div class="col-md-4">
                            <asp:RadioButtonList ID="rbNacionalidad" CssClass="form-check-input ml-1" runat="server" RepeatDirection="Horizontal" AutoPostBack="false" OnSelectedIndexChanged="rbNacionalidad_SelectedIndexChanged">
                                <asp:ListItem Value="1" Text="Peruana"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Extranjera"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                        <div class="col-md-1"></div>
                    </div>
                </div>
                <div class="btnbox">                    
                    <div class="row pt-3">
                        <div class="col-md-12"></div>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class="row pb-5">
                <div class="col-md-4"></div>
                <div class="col-md-2"><asp:Button ID="btnRegistrar" runat="server" CssClass="form-control btn-info" Text="Registrar" OnClick="btnRegistrar_Click" /></div>
                <div class="col-md-2"><asp:Button ID="btnCancelar" runat="server" CssClass="form-control btn-light" Text="Cancelar" /></div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </div>
</asp:Content>