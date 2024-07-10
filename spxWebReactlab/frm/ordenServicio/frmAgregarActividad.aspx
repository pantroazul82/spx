<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmAgregarActividad.aspx.cs" Inherits="frm_ordenServicio_frmAgregarActividad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="tab">Actividad de La orden de Servicio</div>
<div class="formulario">


    <asp:Label ID="Label1" runat="server" 
        Text="Ingrese la descripcion de la actividad realizada"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="chkConfidencial" runat="server" Text="Confidencial" />
    <br />
    <asp:TextBox ID="txtObservaciones" runat="server" Height="168px" 
        TextMode="MultiLine" Width="431px"></asp:TextBox>
    <br />
     <asp:Label ID="lblError" runat="server"></asp:Label>
     <asp:Button ID="btnGuardarCrearOtra" runat="server" onclick="btnGuardarOtra_Click" 
        Text="Guardar y Crear Otra" />
    <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click" 
        Text="Guardar" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />


</div>
</asp:Content>

