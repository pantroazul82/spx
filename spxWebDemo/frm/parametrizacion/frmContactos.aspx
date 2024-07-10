<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmContactos.aspx.cs" Inherits="frm_parametrizacion_frmContactos" %>


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
<div class="tab">Contactos de Clientes!!!</div>
<div class="formulario">
<table style="width: 491px">
<tr>
<td class="style1"></td>
<td>
    <asp:Label ID="lblCodContacto" runat="server" Visible="False"></asp:Label>
    </td>
<td>
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td class="style1">Cliente</td>
<td colspan="3">
    <telerik:RadComboBox ID="cmbCliente" Runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombreCliente" 
        DataValueField="nitCliente" Width="400px">
    </telerik:RadComboBox>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT rtrim([nitCliente]) nitCliente, rtrim(nombreCliente)+' ('+rtrim(nitCliente)+')' 'nombreCliente' FROM [clientes]
order by nombreCliente"></asp:SqlDataSource>
    </td>
</tr>
<tr>
<td class="style1">Nombres</td>
<td>
    <asp:TextBox ID="txtNombreCliente" runat="server" Width="200px"></asp:TextBox>
    </td>
<td>
    Apellidos</td>
<td>
    <asp:TextBox ID="txtApellidosCliente" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">Tipo de Documento</td>
<td>
    <telerik:RadComboBox ID="cmbTipoDocumento" Runat="server" 
        DataSourceID="SqlDataSource2" DataTextField="nombreTipoDoc" 
        DataValueField="codTipoDoc">
    </telerik:RadComboBox>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [codTipoDoc], [nombreTipoDoc] FROM [tipoDocumento] ORDER BY [nombreTipoDoc]">
    </asp:SqlDataSource>
    </td>
<td>
    Documento</td>
<td>
    <asp:TextBox ID="txtDocumento" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">Telefono 1</td>
<td>
    <asp:TextBox ID="txtTelefono" runat="server" Width="200px"></asp:TextBox>
    </td>
<td>
    Telefono 2</td>
<td>
    <asp:TextBox ID="txtTelefono2" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">Cargo</td>
<td colspan="3">
    <asp:TextBox ID="txtCargo" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">Fax</td>
<td>
    <asp:TextBox ID="txtFax" runat="server" Width="200px"></asp:TextBox>
    </td>
<td>
    Celular</td>
<td>
    <asp:TextBox ID="txtCelular" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">Email</td>
<td colspan="3">
    <asp:TextBox ID="txtEmail" runat="server" Width="400px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <asp:CheckBox ID="chkActivo" runat="server" Text="Activo" />
    </td>
<td>
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>
    &nbsp;</td>
<td>
    &nbsp;</td>
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
<td>
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>
</table>

</div>

</asp:Content>


