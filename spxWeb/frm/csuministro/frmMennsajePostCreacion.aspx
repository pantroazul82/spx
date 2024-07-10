<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmMennsajePostCreacion.aspx.cs" Inherits="frm_csuministro_frmMennsajePostCreacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label runat="server" ID="Label1" Text="Mensaje de confirmación" Font-Bold="true"></asp:Label>
    <br />
    <asp:Label runat="server" ID="lblMensaje" Font-Bold="false" Text="Se creo el contrato de suministro "></asp:Label>
    <asp:Label runat="server" ID="lblContrato" Text="" Font-Bold="true"></asp:Label>
    <asp:Label runat="server" ID="lbl2" Font-Bold="false" Text=" Satisfactoriamente" ></asp:Label>
    <br />
    <asp:Label runat="server" ID="Label2" Font-Bold="false" Text="Codigo Interno:"></asp:Label>
    <asp:Label runat="server" ID="lblCodInterno" Text="" Font-Bold="true"></asp:Label>
    


    <asp:HyperLink runat="server" ID="lnkContinuar" NavigateUrl="~/frm/csuministro/frmListadoContratos.aspx"
       text="Continuar" ></asp:HyperLink>

</asp:Content>

