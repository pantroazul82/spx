<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmNuevaRevision.aspx.cs" Inherits="frm_revision_frmNuevaRevision" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<br />
<div class="Formulario">
<table>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td></td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td>
<asp:Label runat="server" ID="lblinge" Text="Ingeniero que Entrega" Width="190px"></asp:Label></td>
<td><asp:DropDownList runat="server" ID="cmbIngenieroRecibe" AppendDataBoundItems="true"
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
</td>
<td>&nbsp;</td>
<td>Colaborador&nbsp; que recibe</td>
<td><asp:DropDownList runat="server" ID="cmbAsesorRecibe" AppendDataBoundItems="true" 
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
    <asp:RadioButton ID="rdEquipoNuevo" runat="server" GroupName="r" 
        Text="Equipo Nuevo" />
</td>
<td>&nbsp;&nbsp;&nbsp;</td>
<td>
    <asp:RadioButton ID="rdEquipoNoNuevo" runat="server" GroupName="r" Width="120px" 
        oncheckedchanged="RadioButton2_CheckedChanged" Text="Equipo Usado" />
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Serial</td>
<td colspan="4">
    <uc1:controlSerial ID="controlSerial1" runat="server" />
</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
  <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline" UpdateMode="Conditional">
    <ContentTemplate>

    <br />Modelo:
    <asp:Label ID="lblInformacionFabricanteModelo" runat="server"></asp:Label>
    <br />
    <br />
    Orden de Servicio: <asp:DropDownList ID="cmbOrdenServicio" runat="server">
    </asp:DropDownList>
    </ContentTemplate>
    </asp:UpdatePanel>
    </td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td></td>
<td>
    
    </td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Observaciones Iniciales</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td colspan="5">
    <asp:TextBox ID="txtObservacionesiniciales" runat="server" Height="65px" 
        TextMode="MultiLine" Width="575px"></asp:TextBox>
    </td>
</tr>
<tr>
<td></td>
<td colspan="4">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td></td>
<td>
    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Aceptar" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    </td>
<td></td>
<td></td>
<td></td>
</tr>
</table>
<asp:SqlDataSource ID="SqlDataSourceIngenieroRecibe" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] WHERE ([es_bloqueado] = @es_bloqueado) ORDER BY [nombre]">
        <SelectParameters>
            <asp:Parameter DefaultValue="false" Name="es_bloqueado" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSourceOrigen" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_origen_revision_equipos], [nombre_origen_revision_equipos] FROM [origen_revision_equipos] WHERE ([activo] = @activo2) ORDER BY [nombre_origen_revision_equipos]">
        <SelectParameters>
            <asp:Parameter DefaultValue="true" Name="activo2" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
</asp:Content>

