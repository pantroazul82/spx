<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmControlesCalidadInterno.aspx.cs" Inherits="Web2020.frm.parametrizacion.frmControlesCalidadInterno" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 112px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Formulario controles de calidad origen Interno</div>
<div class="formulario">
<table style="width: 491px">
<tr>
<td class="style1"></td>
<td>
    <asp:Label ID="lblCodTipo" runat="server" Visible="False"></asp:Label>
    </td>
</tr>
<tr>
<td class="style1">Descripcion</td>
<td>
    <asp:TextBox ID="txtDescripcion" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <asp:CheckBox ID="chkActivo" runat="server" Text="Activo" />
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <telerik:RadButton ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Aceptar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar">
    </telerik:RadButton>
    </td>
</tr>
</table>

</div>

</asp:Content>
