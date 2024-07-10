<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCambiarPassword.aspx.cs" Inherits="frm_logica_frmCambiarPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 386px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">
Formulario de Cambio de password
</div>

<div class="Formulario">
<table>
<tr>
<td>Password anterior</td>
<td class="style1">
    <asp:TextBox ID="txtAnterior" runat="server" 
        Width="336px" TextMode="Password"></asp:TextBox></td>
</tr>

<tr>
<td>Password nuevo</td>
<td class="style1"><asp:TextBox ID="txtNuevo" runat="server" Width="336px" 
        TextMode="Password"></asp:TextBox></td>
</tr>

<tr>
<td>Confirmacion Password </td>
<td class="style1"><asp:TextBox ID="txtConfirmacion" runat="server" Width="339px" 
        TextMode="Password"></asp:TextBox></td>
</tr>

<tr>
<td colspan="2" >
<asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
</td>
</tr>

<tr>
<td></td>
<td class="style1"><asp:Button runat="server" Text="Cambiar Password" 
        ID="btnCqmbiar" onclick="btnCqmbiar_Click" />
    <br />
    </td>
</tr>

</table>
<br />
</div>
</asp:Content>

