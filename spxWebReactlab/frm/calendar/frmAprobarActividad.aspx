<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmAprobarActividad.aspx.cs" Inherits="frm_calendar_frmAprobarActividad" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="tab">Aprobar Actividad <asp:Label runat="server" ID="lblCodActividad"></asp:Label></div>
<div class="Formulario">

<table>
<tr>
<td></td>
<td></td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Observaciones Aprobacion</td>
<td>&nbsp;</td>
</tr>

<tr>
<td></td>
<td>
    <asp:TextBox ID="txtObservacionesAprobacion" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px"></asp:TextBox>
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td></td>
<td>
    <telerik:RadButton ID="btnAprobar" runat="server" onclick="btnAprobar_Click" 
        Text="Aprobar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnNoAprobar" runat="server" 
        onclick="btnNoAprobar_Click" Text="No Aprobar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar">
    </telerik:RadButton>
    </td>
<td>&nbsp;</td>
</tr>
</table>
</div>


</asp:Content>

