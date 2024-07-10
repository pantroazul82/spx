<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmProductosExperiencia.aspx.cs" Inherits="frm_csuministro_frmProductosExperiencia" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 112px;
        }
        .auto-style1
        {
            width: 238px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div class="tab">Formulario productos experiencia!</div>
<div class="formulario">
<table style="width: 491px">
<tr>
<td class="auto-style1"></td>
<td>
    <asp:Label ID="lblCodTipo" runat="server" Visible="False"></asp:Label>
    </td>
</tr>
<tr>
<td class="auto-style1">Fabricante</td>
<td>
    <asp:DropDownList ID="cmbFabricante" runat="server" DataSourceID="SqlDataSourceFabricante" DataTextField="nombre_fabricante" DataValueField="cod_fabricante">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSourceFabricante" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_fabricante], [nombre_fabricante] FROM [fabricante] ORDER BY [nombre_fabricante]"></asp:SqlDataSource>
    </td>
</tr>
<tr>
<td class="auto-style1">Nombre Producto</td>
<td>
    <asp:TextBox ID="txtNombreProducto" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="auto-style1">Codigo Manual (referencia)</td>
<td>
    <asp:TextBox ID="txtCodManual" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="auto-style1">&nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td class="auto-style1">&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td class="auto-style1">&nbsp;</td>
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
