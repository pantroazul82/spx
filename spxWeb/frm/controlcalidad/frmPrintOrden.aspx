<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmPrintOrden.aspx.cs" Inherits="frm_controlcalidad_frmPrintOrden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <p>
        <br />
        <strong>Seleccione el formato de impresion</strong></p>
    <p>
        <asp:LinkButton ID="linkBasica" runat="server" onclick="linkBasica_Click">Impresion Standar</asp:LinkButton>
    </p>
    <p>
        <asp:LinkButton ID="linkImpresionCompleta" runat="server" 
            onclick="linkImpresionCompleta_Click">Impresion Completa</asp:LinkButton>
    </p>
    <p>
        &nbsp;</p>



</asp:Content>

