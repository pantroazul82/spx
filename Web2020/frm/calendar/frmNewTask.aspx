<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmNewTask.aspx.cs" Inherits="Web2020.frm.calendar.frmNewTask" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../css/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../../css/default.css" rel="stylesheet" type="text/css" />   <style type="text/css">
    
    <style type="text/css">
        .style1
        {
            width: 70px;
        }
                                                                                             .style1
                                                                                             {
                                                                                                 width: 8px;
                                                                                             }
                                                                                             .style2
                                                                                             {
                                                                                                 width: 11px;
                                                                                             }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><asp:Button ID="btnCliente" style="visibility:hidden;" runat="server" onclick="btnCliente_Click" 
                    Text="Cargar" Width="0px" />
         <asp:Button ID="btnModelo" style="visibility:hidden;" runat="server" onclick="btnModelo_Click" 
                    Text="Cargar" Width="0px" />
                  <asp:Label ID="lblFechaCreacion" runat="server"></asp:Label>  <br />
<div class="tab">
    
    Actividad
    <asp:Label ID="lblCodACtividad" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
<div class="Formulario">
<table>
<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkPendientes" runat="server" Text="Tiene Pendientes" 
        Visible="False" Enabled="False" />
    </td>
<td>
    <asp:RadioButton ID="rdInterna" runat="server" Checked="True" 
        GroupName="interna" Text="Interna" />
    <asp:RadioButton ID="rdExterna" runat="server" GroupName="interna" 
        Text="Externa" />
    </td>
<td>
    <asp:CheckBox ID="chkActiva" runat="server" Checked="true" Text="Activa" />
    &nbsp;</td>
<td class="style1">
    <telerik:RadButton ID="btnAceptadaxUsuario" runat="server" 
        onclick="btnAceptadaxUsuario_Click" Text="Aceptar Tarea" Visible="False">
    </telerik:RadButton>
    <telerik:RadButton ID="btnNoAceptar" runat="server" 
        onclick="btnNoAceptar_Click" Text="No Aceptar Tarea" Visible="False">
    </telerik:RadButton>
    <asp:Label ID="lblTittuloAceptacion" runat="server" Text="No Aceptada" 
        Visible="False"></asp:Label>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblEstado" runat="server" Text="Estado" 
        Visible="False"></asp:Label>
    </td>
<td>
<asp:DropDownList runat="server" ID="cmbEstado" DataSourceID="ObjectDataSource1" DataTextField="nombre_estado_tarea" 
        DataValueField="cod_estado_tarea_calendario" Enabled="False" Width="200px" 
        Visible="False" ></asp:DropDownList>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_estado_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_cod_manual" Type="Int32" />
            <asp:Parameter Name="Original_nombre_estado_tarea" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_manual" Type="Int32" />
            <asp:Parameter Name="nombre_estado_tarea" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_manual" Type="Int32" />
            <asp:Parameter Name="nombre_estado_tarea" Type="String" />
            <asp:Parameter Name="Original_cod_estado_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_cod_manual" Type="Int32" />
            <asp:Parameter Name="Original_nombre_estado_tarea" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
<td>
    <asp:Label ID="lblFechaCierre" runat="server" Text="Fecha Cierre" 
        Visible="False"></asp:Label>
    </td>
<td class="style1">
    <telerik:RadDateTimePicker ID="calCierre" Runat="server" Visible="False" 
        Enabled="False">
        <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblResponsable" runat="server" Text="Responsable" 
        Visible="False"></asp:Label>
    </td>
<td>
    <asp:DropDownList ID="cmbResponsable" runat="server" 
        DataSourceID="ObjectDataSourceUser" DataTextField="nombre" 
        DataValueField="cod_usuario" Visible="False">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSourceUser" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="getDataByPermiso" 
        TypeName="SPXSeguridad.data.cls.clsTusuario">
        <SelectParameters>
            <asp:Parameter DefaultValue="2010" Name="cod_funcionalidad" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    </td>
<td>
    &nbsp;</td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Tipo de Actividad</td>
<td>
    <asp:DropDownList ID="cmbtipoActividad" runat="server" 
        DataSourceID="odsTipoActividad" DataTextField="descripcion" 
        DataValueField="cod_tipo_tarea_calendario" AutoPostBack="True">
    </asp:DropDownList>
    &nbsp;<asp:Label ID="lblConsecutivo" runat="server"></asp:Label>
    </td>
<td>
    <asp:CheckBox ID="chkRequiereAprobacion" runat="server" 
        Text="Requiere Aceptación" Width="159px" Height="20px" />
    </td>
<td class="style1">
    <asp:Label ID="lblEstadoAprobacion" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Sub tipo de Actividad</td>
<td>
    <asp:DropDownList ID="cmbSubtipoActividad" runat="server" 
        DataSourceID="odsSubTipoActividad" DataTextField="descripcion" 
        DataValueField="cod_subtipo_tarea_calendario">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsSubTipoActividad" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCod_tipo_tarea_calendarioActivo" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_subtipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_url" Type="String" />
            <asp:Parameter Name="Original_activo" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="url" Type="String" />
            <asp:Parameter Name="activo" Type="Boolean" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbtipoActividad" 
                Name="cod_tipo_tarea_calendario" PropertyName="SelectedValue" Type="Int32" />
            <asp:Parameter DefaultValue="True" Name="activo" Type="Boolean" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="url" Type="String" />
            <asp:Parameter Name="activo" Type="Boolean" />
            <asp:Parameter Name="Original_cod_subtipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_url" Type="String" />
            <asp:Parameter Name="Original_activo" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
<td>
    &nbsp;</td>
<td class="style1">

    &nbsp;</td>
<td class="style2">
    </td>
</tr>

<tr>
<td></td>
<td>Fecha de Inicio</td>
<td>
    <telerik:RadDateTimePicker ID="calInicio" Runat="server">

<Calendar runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
</telerik:RadDateTimePicker>

    </td>
<td>
    <asp:Label ID="lblFechaEjecucion" runat="server" Text="Fecha Ejecucion" 
        Visible="False"></asp:Label>
    </td>
<td class="style1">
    <telerik:RadDateTimePicker ID="calEjecucion" Runat="server" Visible="False" 
        Enabled="False">
        <Calendar ID="Calendar4" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td></td>
<td>Fecha de Terminacion</td>
<td>
    <telerik:RadDateTimePicker ID="calFin" Runat="server">
 <Calendar ID="Calendar3" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td>
    <asp:Label ID="lblFechaFinEjecucion" runat="server" Text="Fecha Fin Ejecucion" 
        Visible="False"></asp:Label>
    </td>
<td class="style1">
    <telerik:RadDateTimePicker ID="calFinEjecucion" Runat="server" Visible="False" 
        Enabled="False">
       <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td></td>
<td>Descripcion</td>
<td>
    <asp:TextBox ID="txtDescripcion" runat="server" Width="300px" MaxLength="150"></asp:TextBox>
    </td>
<td>
    &nbsp;</td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaCliente" runat="server" Text="Atada a Cliente" />
    </td>
<td colspan="4">
    <asp:TextBox ID="txtCliente" runat="server" style="visibility:hidden;" 
        Width="200px"></asp:TextBox>
&nbsp;<asp:Label ID="lblSucursal" runat="server" Text="Sucursal" style="visibility:hidden;"></asp:Label>
&nbsp;<asp:DropDownList ID="cmbSucursal" runat="server" style="visibility:hidden;">
    </asp:DropDownList>
&nbsp;<asp:Label ID="lblContacto" runat="server" Text="Contacto" style="visibility:hidden;"></asp:Label>
&nbsp;
    <asp:DropDownList ID="cmbContacto" runat="server" style="visibility:hidden;">
    </asp:DropDownList>
    <asp:ImageButton ID="btnCargarContactos" runat="server" 
        ImageUrl="~/img/web/GoBack.gif" onclick="btnCargarContactos_Click" 
        ToolTip="Cargar Contactos" Width="28px" />
    <asp:HyperLink ID="lnkNuevoContaco" runat="server" 
        ImageUrl="~/img/web/insert.gif" 
        NavigateUrl="~/frm/parametrizacion/frmContactos.aspx" Target="_blank">Nuevo Contacto</asp:HyperLink>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaModelo" runat="server" Text="Atada a Modelo(s)" />
    </td>
<td colspan="4">
    <asp:TextBox ID="txtModelo" runat="server" Width="300px"  style="visibility:hidden;"></asp:TextBox>
    <asp:ImageButton ID="btnAgregarModelo" runat="server" style= "visibility:hidden;"
        ImageUrl="~/img/Crystal_Clear_action_edit_add.png" 
        onclick="btnAgregarModelo_Click" ToolTip="Agregar Modelo" Width="20px" />
    <asp:ImageButton ID="btnQuitarModelo" runat="server" 
        ImageUrl="~/img/web/cancel.gif" style= "visibility:hidden;"
        onclick="btnQuitarModelo_Click" ToolTip="Limpiar Modelo" Width="20px" 
        onclientclick="return confirm(&quot;Esta seguro de limpiar modelos&quot;);" />
    <asp:Label ID="lblModelos" runat="server" style= "visibility:hidden;"></asp:Label>
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaSerial" runat="server" Text="Atada a Serial" />
    </td>
<td colspan="4">
    <uc1:controlSerial ID="txtSerial" runat="server" />
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaReactivo" runat="server" Text="Atada a Reactivo(s)" />
    </td>
<td colspan="4">
    <asp:DropDownList ID="cmbFabricanteReactivo" runat="server" style= "visibility:hidden;"
        DataSourceID="odsFabricante" DataTextField="nombre_fabricante" 
        DataValueField="codFabricante" AutoPostBack="True">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsFabricante" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByComBox" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codFabricante" Type="String" />
            <asp:Parameter Name="Original_nombre_fabricante" Type="String" />
            <asp:Parameter Name="Original_numero_nit" Type="String" />
            <asp:Parameter Name="Original_pagina_web" Type="String" />
            <asp:Parameter Name="Original_email_contacto" Type="String" />
            <asp:Parameter Name="Original_telefono1" Type="String" />
            <asp:Parameter Name="Original_telefono2" Type="String" />
            <asp:Parameter Name="Original_nombre_contacto" Type="String" />
            <asp:Parameter Name="Original_tituloContacto" Type="String" />
            <asp:Parameter Name="Original_cod_linea" Type="Int32" />
            <asp:Parameter Name="Original_cod_fabricante" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codFabricante" Type="String" />
            <asp:Parameter Name="nombre_fabricante" Type="String" />
            <asp:Parameter Name="numero_nit" Type="String" />
            <asp:Parameter Name="pagina_web" Type="String" />
            <asp:Parameter Name="email_contacto" Type="String" />
            <asp:Parameter Name="telefono1" Type="String" />
            <asp:Parameter Name="telefono2" Type="String" />
            <asp:Parameter Name="nombre_contacto" Type="String" />
            <asp:Parameter Name="tituloContacto" Type="String" />
            <asp:Parameter Name="logo" Type="Object" />
            <asp:Parameter Name="cod_linea" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="codFabricante" Type="String" />
            <asp:Parameter Name="nombre_fabricante" Type="String" />
            <asp:Parameter Name="numero_nit" Type="String" />
            <asp:Parameter Name="pagina_web" Type="String" />
            <asp:Parameter Name="email_contacto" Type="String" />
            <asp:Parameter Name="telefono1" Type="String" />
            <asp:Parameter Name="telefono2" Type="String" />
            <asp:Parameter Name="nombre_contacto" Type="String" />
            <asp:Parameter Name="tituloContacto" Type="String" />
            <asp:Parameter Name="logo" Type="Object" />
            <asp:Parameter Name="cod_linea" Type="Int32" />
            <asp:Parameter Name="Original_codFabricante" Type="String" />
            <asp:Parameter Name="Original_nombre_fabricante" Type="String" />
            <asp:Parameter Name="Original_numero_nit" Type="String" />
            <asp:Parameter Name="Original_pagina_web" Type="String" />
            <asp:Parameter Name="Original_email_contacto" Type="String" />
            <asp:Parameter Name="Original_telefono1" Type="String" />
            <asp:Parameter Name="Original_telefono2" Type="String" />
            <asp:Parameter Name="Original_nombre_contacto" Type="String" />
            <asp:Parameter Name="Original_tituloContacto" Type="String" />
            <asp:Parameter Name="Original_cod_linea" Type="Int32" />
            <asp:Parameter Name="Original_cod_fabricante" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <asp:DropDownList ID="cmbReactivo" runat="server" DataSourceID="odsReactivo" 
        DataTextField="nombre_referencia_reactivo" style= "visibility:hidden;"
        DataValueField="cod_referencia_reactivo">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsReactivo" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataBycodFabricante" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_referencia_reactivo" Type="Int32" />
            <asp:Parameter Name="Original_codFabricante" Type="String" />
            <asp:Parameter Name="Original_codigo_manual" Type="String" />
            <asp:Parameter Name="Original_nombre_referencia_reactivo" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codFabricante" Type="String" />
            <asp:Parameter Name="codigo_manual" Type="String" />
            <asp:Parameter Name="nombre_referencia_reactivo" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbFabricanteReactivo" Name="codFabricante" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="codFabricante" Type="String" />
            <asp:Parameter Name="codigo_manual" Type="String" />
            <asp:Parameter Name="nombre_referencia_reactivo" Type="String" />
            <asp:Parameter Name="Original_cod_referencia_reactivo" Type="Int32" />
            <asp:Parameter Name="Original_codFabricante" Type="String" />
            <asp:Parameter Name="Original_codigo_manual" Type="String" />
            <asp:Parameter Name="Original_nombre_referencia_reactivo" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
&nbsp;<asp:ImageButton ID="btnAgregarReactivo" runat="server" 
        ImageUrl="~/img/Crystal_Clear_action_edit_add.png" style= "visibility:hidden;"
        onclick="btnAgregarReactivo_Click" ToolTip="Agregar Reactivo" 
        Width="20px" />
    <asp:ImageButton ID="btnQuitarReactivo" runat="server" 
        ImageUrl="~/img/web/cancelar.png" style= "visibility:hidden;"
        onclick="btnQuitarReactivo_Click" ToolTip="Limpiar Reactivos" Width="20px" 
        onclientclick="return confirm('Esta seguro de limpiar los reactivos');" />
    <asp:Label ID="lblReactivo" runat="server"></asp:Label>
    <br />
    </td>
</tr>

<tr>
<td></td>
<td valign="top">Observaciones Iniciales</td>
<td colspan="3">
    <asp:TextBox ID="txtObservaciones" runat="server" Height="68px" Width="424px" 
        TextMode="MultiLine" ></asp:TextBox>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td colspan="3">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td class="style1">&nbsp;</td>
<td class="style2">&nbsp;</td>
</tr>

<tr>
<td></td>
<td></td>
<td colspan="3">
    <telerik:RadButton ID="btnImprimir" runat="server" Text="Imprimir" 
        Visible="False" onclick="btnImprimir_Click">
    </telerik:RadButton>
    <telerik:RadButton ID="btnEjecutar" runat="server" Text="Ejecutar" 
        Visible="False" onclick="btnEjecutar_Click">
    </telerik:RadButton>
    <telerik:RadButton ID="btnAprobar" runat="server" Text="Aprobar" 
        Visible="False" onclick="btnAprobar_Click">
    </telerik:RadButton>
    
     <asp:Button runat="server" onclick="btnCambiarEstado_Click" Visible="False"  ID="btnCambiarEstado"  Text="Cerrar" 
     OnClientClick= "return confirm('Esta seguro de Cerrar la actividad?');"/>
    
    <asp:Button runat="server" onclick="btnAnular_Click" Visible="False"  ID="btnAnular"  Text="Anular" OnClientClick= "return confirm('Esta seguro de anular la actividad');"/>
    
    <asp:Button runat="server" onclick="btnDetalles_Click"  ID="btnDetalles"  
        Text="Ver Detalles"/>

    <asp:Button runat="server" id="btnReabrir" Visible="false" Text="Reabrir" OnClick="btnReabrir_Click" OnClientClick="return confirm('Esta seguro de reabrir esta actividad?')" />
    <asp:CheckBox runat="server" Text="" Checked="false" ID="chkAlarmaFecha" Visible="False" />
    </td>
<td class="style2">&nbsp;</td>
</tr>

<tr>
<td></td>
<td></td>
<td colspan="2">
    <asp:Button ID="btnAceptarConConflicto" runat="server" onclick="btnAceptarConConflicto_Click" 
        Text="Acepta doble actividad" Visible="False" />
    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Guardar Cambios" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [login], [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    <asp:ObjectDataSource ID="odsTipoActividad" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_url" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="url" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="url" Type="String" />
            <asp:Parameter Name="Original_cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_url" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

</table>

</div>
</asp:Content>

