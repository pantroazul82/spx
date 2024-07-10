<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmAnularTarea.aspx.cs" Inherits="frm_calendar_frmAnularTarea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br /><br />
<div class="tab">Formulario de Anulacion</div>
<div class="Formulario">
<table>
<tr>
<td colspan="2">
    <asp:Label ID="lblDescription" runat="server"></asp:Label>
    </td>
</tr>

<tr>
<td>Observaciones de anulacion</td>
<td></td>
</tr>

<tr>
<td colspan="2">
    <asp:TextBox ID="txtObservaciones" runat="server" Height="73px" Width="415px"></asp:TextBox>
    </td>
</tr>

<tr>
<td></td>
<td>
    <asp:Button ID="btnanular" runat="server" onclick="btnanular_Click" 
        Text="Anular" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    </td>
</tr>
</table>

</div>
</asp:Content>

