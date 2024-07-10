<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmEditarRevision.aspx.cs" Inherits="frm_revision_frmEditarRevision" %>
<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
  <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br />
<asp:Button ID="btnCliente"   runat="server" onclick="btnCliente_Click" 
    style="visibility:hidden; " Text="Cargar" Width="0px" />
<asp:Button ID="btnClienteFinal"   runat="server" onclick="btnClienteFinal_Click" 
    style="visibility:hidden; " Text="Cargar" Width="0px" />


<div class="tab">Editar Revision de equipos </div>
    <asp:CheckBox runat="server" ID="chkEditaSerial" Visible="false" />
<div class="Formulario">

    
<table>
<tr>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td>Estado</td>
<td>
    <asp:Label ID="lblEstado" runat="server"></asp:Label>
</td>
<td>&nbsp;</td>
<td>Codigo Revision</td>
<td>
    <asp:Label ID="lblCodigoRevision" runat="server"></asp:Label>
    </td>
</tr>
    <tr>
        <td>
            Creado Por:</td>
        <td>
            <asp:Label ID="lblCreadoPor" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>
            Fecha de Creacion</td>
        <td>
            <asp:Label ID="lblFechaCreacion" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Origen Solicitud</td>
        <td>
            <asp:DropDownList ID="cmbOrigen" runat="server" AppendDataBoundItems="true" 
                DataSourceID="SqlDataSourceOrigen" 
                DataTextField="nombre_origen_revision_equipos" 
                DataValueField="cod_origen_revision_equipos" Width="200px">
                <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
            Id FO</td>
        <td>
            <asp:TextBox ID="txtIdFo" runat="server" ></asp:TextBox>
    
        </td>
    </tr>
<tr>
<td>
<asp:Label runat="server" ID="lblinge" Text="Ingeniero que Entrega" Width="150px"></asp:Label></td>
<td><asp:DropDownList runat="server" ID="cmbIngenieroRecibe" AppendDataBoundItems="true"
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario" Width="200px">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
</td>
<td>&nbsp;</td>
<td>Colaborador que recibe</td>
<td><asp:DropDownList runat="server" ID="cmbAsesorRecibe" AppendDataBoundItems="true" 
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>
<tr>
<td>Asignado A:</td>
<td>
    <asp:DropDownList runat="server" ID="cmbAsignadoA" AppendDataBoundItems="true" 
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario" Width="200px">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
    </td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Programacion:</td>
<td>
    <telerik:RadDateTimePicker ID="calInicio" Runat="server" Height="24px">

<Calendar runat="server" ID="calendar1">

    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>


    </telerik:RadDateTimePicker>




    </td>
<td>&nbsp;</td>
<td>
    Fin Programacion</td>
<td>
    <telerik:RadDateTimePicker ID="calFin" Runat="server">
 <Calendar runat="server" ID="calendar2" >

    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
</tr>
<tr>
<td>Cliente Local</td>
<td>
    <asp:TextBox ID="txtCliente" runat="server" Width="280px"></asp:TextBox>
    </td>
<td>&nbsp;</td>
<td>
    Sucursal</td>
<td>
    <asp:DropDownList ID="cmbSucursal" runat="server">
    </asp:DropDownList>
    </td>
</tr>

<tr>
<td>Cliente final:</td>
<td>
    <asp:TextBox ID="txtClienteFinal" runat="server" Width="280px"></asp:TextBox>
    </td>
<td>&nbsp;</td>
<td>
    Sucursal final:</td>
<td>
    <asp:DropDownList ID="cmbSucursalFinal" runat="server">
    </asp:DropDownList>
    </td>
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
         Text="Equipo Usado" />
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Serial</td>
<td colspan="4">
    <uc1:controlSerial ID="controlSerial1" runat="server"  />
    <asp:Label ID="lblInformacionSerial" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td>Orden de Servicio</td>
<td colspan="4">
    <asp:DropDownList ID="cmbOrdenServicio" runat="server">
    </asp:DropDownList>
</td>
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
<td colspan="5">
    &nbsp;</td>
</tr>
<tr>
<td colspan="5">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td colspan="5">
&nbsp;<asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
        onclick="btnGuardar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
        onclick="btnCancelar_Click" />
    
    
    &nbsp;</td>
</tr>
<tr>
<td></td>
<td>
    &nbsp;</td>
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
