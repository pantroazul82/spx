<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmAnular.aspx.cs" Inherits="frm_revision_frmAnular" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Formulario de anulacion</div>
<div class="Formulario">
<table>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Anulado Por</td>
<td>
    <asp:DropDownList ID="cmbAnuladoPor" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" 
        DataValueField="cod_usuario" Enabled="False">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    </td>
<td>Fecha de anulacion</td>
<td>
    <telerik:RadDatePicker ID="calAnulacion" Runat="server" Enabled="False">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Motivo de Anulacion</td>
<td></td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td colspan="4">
    <asp:TextBox ID="txtMotivo" runat="server" Height="65px" TextMode="MultiLine" 
        Width="519px"></asp:TextBox>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td colspan="4">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Anular" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    </td>
<td>&nbsp;</td>
</tr>
</table>


</div>
</asp:Content>

