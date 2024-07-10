<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmNewArchivoRevision.aspx.cs" Inherits="frm_revision_frmNewArchivoRevision" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
<link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />

<table>
<tr>
<td>
Tipo de Archivo
</td>
<td>

    <asp:TextBox ID="txtTipoArchivo" runat="server"></asp:TextBox>

</td>

</tr>

<tr>
<td>
Fecha De Archivo Manual
</td>
<td>

    <telerik:RadDatePicker ID="calFechaManual" Runat="server">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>

</td>

</tr>

<tr>
<td>
    Archivo</td>
<td>

    <asp:FileUpload ID="FileUpload1" runat="server" />

</td>

</tr>

<tr>
<td>
    &nbsp;</td>
<td>

    &nbsp;</td>

</tr>

<tr>
<td colspan="2">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
</td>

</tr>

<tr>
<td>
    &nbsp;</td>
<td>

    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Aceptar" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />

</td>

</tr>
</table>
</asp:Content>


