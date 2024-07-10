<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmRechazarOp.aspx.cs" Inherits="Web2020.frm.ordenPrestamo.frmRechazarOp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="tab">Rechazar Orden de Prestamo</div>
<div class="Formulario">
<table>
<tr>
<td>
    Observaciones Rechazo</td>
<td>
    &nbsp;</td>

</tr>
<tr>
<td>
    <asp:TextBox ID="txtObsRechazo" runat="server" Height="105px" 
        TextMode="MultiLine" Width="481px"></asp:TextBox>
</td>
<td>
    &nbsp;</td>

</tr>
<tr>
<td>
    <asp:ImageButton ID="btnOk" runat="server" ImageUrl="~/img/web/ok.gif" 
        onclick="btnOk_Click" ToolTip="Aceptar" Width="30px" />
    <asp:ImageButton ID="btnCancelar" runat="server" 
        ImageUrl="~/img/web/cancel.gif" onclick="btnCancelar_Click" 
        ToolTip="Cancelar" Width="30px" />
</td>
<td>
    &nbsp;</td>

</tr>


</table>


</div>
</asp:Content>