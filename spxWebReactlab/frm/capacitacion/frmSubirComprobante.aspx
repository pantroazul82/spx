<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmSubirComprobante.aspx.cs" Inherits="frm_capacitacion_frmSubirComprobante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div class="tab">
Adjuntar o Modificar Comprobante
</div>
<div class="Formulario ">
<table>
<tr>
<td></td>
<td></td>
</tr>


<tr>
<td> <asp:Label runat="server" ID="lblArchivoActual" Text="Archivo Actual" 
        Visible="False"></asp:Label> 
&nbsp; 
<asp:HyperLink runat="server" ID="lnkArhivo" Text="Ver Archivo" Visible="False" ></asp:HyperLink>
</td>
<td></td>
</tr>

<tr>
<td>Modificar / Adjuntar Archivo</td>
<td> <asp:FileUpload runat="server" id="fileUpload1" Width="381px" /> </td>
</tr>

<tr>
<td>&nbsp;
<asp:Label runat="server" ID="lblError" ForeColor="Red" Text=""></asp:Label>
</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td></td>
<td>
<asp:Button runat="server" ID="btnAceptar" Text="Aceptar" 
        onclick="btnAceptar_Click" />
<asp:Button runat="server" ID="btnCancelar" Text="Cancelar" 
        onclick="btnCancelar_Click" />

</td>
</tr>
</table>

</div>
</asp:Content>

