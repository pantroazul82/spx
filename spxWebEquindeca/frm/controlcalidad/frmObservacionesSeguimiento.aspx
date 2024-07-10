<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmObservacionesSeguimiento.aspx.cs" Inherits="frm_controlcalidad_frmObservacionesSeguimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br />
<div class="tab">Observaciones Seguimiento</div>
    <asp:TextBox ID="txtObservacion" runat="server" Height="150px" 
        TextMode="MultiLine" Width="700px"></asp:TextBox>
    <br />
    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Aceptar" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    <br />

</asp:Content>

