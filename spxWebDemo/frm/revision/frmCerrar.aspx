<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCerrar.aspx.cs" Inherits="frm_revision_frmCerrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">

    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br />
<br />
<br />
<div class="tab">Cierre de revision<asp:SqlDataSource ID="SqlDataSource1" 
        runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    </div>
<div class="Formulario">
<table>
<tr>
<td>Concepto Cientifico</td>
<td class="style1">
<asp:RadioButton runat="server" ID="rdAdecuado" Text="Adecuado" GroupName="r" />
</td>
<td></td>
<td>
<asp:RadioButton runat="server" ID="rdNoAdecuado" Text="No Adecuado" GroupName="r" />
</td>
<td></td>
</tr>

<tr>
<td>
    <asp:Label ID="Label1" runat="server" 
        Width="200px" style="margin-bottom: 13px"></asp:Label>
    </td>
<td class="style1">
    &nbsp;</td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td>Observaciones
</td>
<td class="style1">
    &nbsp;</td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td class="style1" colspan="3">
    <asp:TextBox ID="txtObservaciones" runat="server" Height="42px" Width="840px" 
        TextMode="MultiLine"></asp:TextBox>
</td>
<td>&nbsp;</td>
</tr>

<tr>
<td colspan="5">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>

<tr>
<td></td>
<td class="style1">

</td>
<td></td>
<td>

    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
        onclick="btnAceptar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
        onclick="btnCancelar_Click" />

</td>
<td></td>
</tr>
</table>
</div>
</asp:Content>

