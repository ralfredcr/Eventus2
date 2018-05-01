<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PortalEventus.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container rounded idxbox">
        <div class="row d-flex flex-column">
            <h1>Vive más intensamente!</h1>
            <h3>¡Tenemos el plan perfecto para Tí!</h3>
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <%--<form class="form-inline justify-content-center d-flex flex-column flex-md-row">     --%>
                    <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control mt-3"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success mt-3" OnClick="btnBuscar_Click" />
                    <%-- </form>--%>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </div>
</asp:Content>
