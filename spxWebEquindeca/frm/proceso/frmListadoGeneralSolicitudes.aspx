<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoGeneralSolicitudes.aspx.cs" Inherits="frm_proceso_frmListadoGeneralSolicitudes" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="Formulario">
<table>
<tr>
    <td></td>
    <td></td>
</tr>
<tr>
    <td></td>
    <td></td>
</tr>

</table>
</div>

<br />
<div class="tab">Listado de solicitudes<asp:ImageButton ID="btnNuevaSolicutd" 
        runat="server" ImageUrl="~/img/web/insert.gif" onclick="btnNuevaSolicutd_Click" 
        ToolTip="Nueva Solicitud" />
&nbsp;<telerik:RadGrid ID="RadGrid1" 
        runat="server" CellSpacing="0" DataSourceID="odsSolicitudes" 
        GridLines="None" Skin="WebBlue">
<MasterTableView autogeneratecolumns="False" datakeynames="cod_solicitud_general" 
            datasourceid="odsSolicitudes">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="cod_solicitud_general" 
            DataType="System.Int32" 
            FilterControlAltText="Filter cod_solicitud_general column" 
            HeaderText="cod_solicitud_general" ReadOnly="True" 
            SortExpression="cod_solicitud_general" UniqueName="cod_solicitud_general">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cod_estado_solicitud_general" 
            DataType="System.Int32" 
            FilterControlAltText="Filter cod_estado_solicitud_general column" 
            HeaderText="cod_estado_solicitud_general" 
            SortExpression="cod_estado_solicitud_general" 
            UniqueName="cod_estado_solicitud_general">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="creado_por" DataType="System.Int32" 
            FilterControlAltText="Filter creado_por column" HeaderText="creado_por" 
            SortExpression="creado_por" UniqueName="creado_por">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="aprobado_por" DataType="System.Int32" 
            FilterControlAltText="Filter aprobado_por column" HeaderText="aprobado_por" 
            SortExpression="aprobado_por" UniqueName="aprobado_por">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ejecutado_por" DataType="System.Int32" 
            FilterControlAltText="Filter ejecutado_por column" HeaderText="ejecutado_por" 
            SortExpression="ejecutado_por" UniqueName="ejecutado_por">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_creacion" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_creacion column" HeaderText="fecha_creacion" 
            SortExpression="fecha_creacion" UniqueName="fecha_creacion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_aprobacion" 
            DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_aprobacion column" 
            HeaderText="fecha_aprobacion" SortExpression="fecha_aprobacion" 
            UniqueName="fecha_aprobacion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_ejecucion" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_ejecucion column" 
            HeaderText="fecha_ejecucion" SortExpression="fecha_ejecucion" 
            UniqueName="fecha_ejecucion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nitCliente" 
            FilterControlAltText="Filter nitCliente column" HeaderText="nitCliente" 
            SortExpression="nitCliente" UniqueName="nitCliente">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="codSucursal" 
            FilterControlAltText="Filter codSucursal column" HeaderText="codSucursal" 
            SortExpression="codSucursal" UniqueName="codSucursal">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="codContacto" 
            FilterControlAltText="Filter codContacto column" HeaderText="codContacto" 
            SortExpression="codContacto" UniqueName="codContacto">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="contrato_legalizado" 
            DataType="System.Boolean" 
            FilterControlAltText="Filter contrato_legalizado column" 
            HeaderText="contrato_legalizado" SortExpression="contrato_legalizado" 
            UniqueName="contrato_legalizado">
        </telerik:GridCheckBoxColumn>
        <telerik:GridCheckBoxColumn DataField="carta_aceptacion" 
            DataType="System.Boolean" FilterControlAltText="Filter carta_aceptacion column" 
            HeaderText="carta_aceptacion" SortExpression="carta_aceptacion" 
            UniqueName="carta_aceptacion">
        </telerik:GridCheckBoxColumn>
        <telerik:GridBoundColumn DataField="personas_entrenamiento" 
            DataType="System.Int32" 
            FilterControlAltText="Filter personas_entrenamiento column" 
            HeaderText="personas_entrenamiento" SortExpression="personas_entrenamiento" 
            UniqueName="personas_entrenamiento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fechaIng" DataType="System.DateTime" 
            FilterControlAltText="Filter fechaIng column" HeaderText="fechaIng" 
            SortExpression="fechaIng" UniqueName="fechaIng">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fechaCie" DataType="System.DateTime" 
            FilterControlAltText="Filter fechaCie column" HeaderText="fechaCie" 
            SortExpression="fechaCie" UniqueName="fechaCie">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="observaciones" 
            FilterControlAltText="Filter observaciones column" HeaderText="observaciones" 
            SortExpression="observaciones" UniqueName="observaciones">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="observacionesAprobacion" 
            FilterControlAltText="Filter observacionesAprobacion column" 
            HeaderText="observacionesAprobacion" SortExpression="observacionesAprobacion" 
            UniqueName="observacionesAprobacion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cal1" DataType="System.DateTime" 
            FilterControlAltText="Filter cal1 column" HeaderText="cal1" 
            SortExpression="cal1" UniqueName="cal1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cal2" DataType="System.DateTime" 
            FilterControlAltText="Filter cal2 column" HeaderText="cal2" 
            SortExpression="cal2" UniqueName="cal2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cal3" DataType="System.DateTime" 
            FilterControlAltText="Filter cal3 column" HeaderText="cal3" 
            SortExpression="cal3" UniqueName="cal3">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cal4" DataType="System.DateTime" 
            FilterControlAltText="Filter cal4 column" HeaderText="cal4" 
            SortExpression="cal4" UniqueName="cal4">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cal5" DataType="System.DateTime" 
            FilterControlAltText="Filter cal5 column" HeaderText="cal5" 
            SortExpression="cal5" UniqueName="cal5">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="num1" DataType="System.Decimal" 
            FilterControlAltText="Filter num1 column" HeaderText="num1" 
            SortExpression="num1" UniqueName="num1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="num2" DataType="System.Decimal" 
            FilterControlAltText="Filter num2 column" HeaderText="num2" 
            SortExpression="num2" UniqueName="num2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="num3" DataType="System.Decimal" 
            FilterControlAltText="Filter num3 column" HeaderText="num3" 
            SortExpression="num3" UniqueName="num3">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="num4" DataType="System.Decimal" 
            FilterControlAltText="Filter num4 column" HeaderText="num4" 
            SortExpression="num4" UniqueName="num4">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="num5" DataType="System.Decimal" 
            FilterControlAltText="Filter num5 column" HeaderText="num5" 
            SortExpression="num5" UniqueName="num5">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="txt1" 
            FilterControlAltText="Filter txt1 column" HeaderText="txt1" 
            SortExpression="txt1" UniqueName="txt1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="txt2" 
            FilterControlAltText="Filter txt2 column" HeaderText="txt2" 
            SortExpression="txt2" UniqueName="txt2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="txt3" 
            FilterControlAltText="Filter txt3 column" HeaderText="txt3" 
            SortExpression="txt3" UniqueName="txt3">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="txt4" 
            FilterControlAltText="Filter txt4 column" HeaderText="txt4" 
            SortExpression="txt4" UniqueName="txt4">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="txt5" 
            FilterControlAltText="Filter txt5 column" HeaderText="txt5" 
            SortExpression="txt5" UniqueName="txt5">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="ind1" DataType="System.Boolean" 
            FilterControlAltText="Filter ind1 column" HeaderText="ind1" 
            SortExpression="ind1" UniqueName="ind1">
        </telerik:GridCheckBoxColumn>
        <telerik:GridCheckBoxColumn DataField="ind2" DataType="System.Boolean" 
            FilterControlAltText="Filter ind2 column" HeaderText="ind2" 
            SortExpression="ind2" UniqueName="ind2">
        </telerik:GridCheckBoxColumn>
        <telerik:GridCheckBoxColumn DataField="ind3" DataType="System.Boolean" 
            FilterControlAltText="Filter ind3 column" HeaderText="ind3" 
            SortExpression="ind3" UniqueName="ind3">
        </telerik:GridCheckBoxColumn>
        <telerik:GridCheckBoxColumn DataField="ind4" DataType="System.Boolean" 
            FilterControlAltText="Filter ind4 column" HeaderText="ind4" 
            SortExpression="ind4" UniqueName="ind4">
        </telerik:GridCheckBoxColumn>
        <telerik:GridCheckBoxColumn DataField="ind5" DataType="System.Boolean" 
            FilterControlAltText="Filter ind5 column" HeaderText="ind5" 
            SortExpression="ind5" UniqueName="ind5">
        </telerik:GridCheckBoxColumn>
        <telerik:GridCheckBoxColumn DataField="es_anulada" DataType="System.Boolean" 
            FilterControlAltText="Filter es_anulada column" HeaderText="es_anulada" 
            SortExpression="es_anulada" UniqueName="es_anulada">
        </telerik:GridCheckBoxColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</HeaderContextMenu>
    </telerik:RadGrid>
    <asp:ObjectDataSource ID="odsSolicitudes" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.solicitud_generalTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_solicitud_general" Type="Int32" />
            <asp:Parameter Name="Original_cod_estado_solicitud_general" Type="Int32" />
            <asp:Parameter Name="Original_creado_por" Type="Int32" />
            <asp:Parameter Name="Original_aprobado_por" Type="Int32" />
            <asp:Parameter Name="Original_ejecutado_por" Type="Int32" />
            <asp:Parameter Name="Original_fecha_creacion" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_aprobacion" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_ejecucion" Type="DateTime" />
            <asp:Parameter Name="Original_nitCliente" Type="String" />
            <asp:Parameter Name="Original_codSucursal" Type="String" />
            <asp:Parameter Name="Original_codContacto" Type="String" />
            <asp:Parameter Name="Original_contrato_legalizado" Type="Boolean" />
            <asp:Parameter Name="Original_carta_aceptacion" Type="Boolean" />
            <asp:Parameter Name="Original_personas_entrenamiento" Type="Int32" />
            <asp:Parameter Name="Original_fechaIng" Type="DateTime" />
            <asp:Parameter Name="Original_fechaCie" Type="DateTime" />
            <asp:Parameter Name="Original_observaciones" Type="String" />
            <asp:Parameter Name="Original_observacionesAprobacion" Type="String" />
            <asp:Parameter Name="Original_cal1" Type="DateTime" />
            <asp:Parameter Name="Original_cal2" Type="DateTime" />
            <asp:Parameter Name="Original_cal3" Type="DateTime" />
            <asp:Parameter Name="Original_cal4" Type="DateTime" />
            <asp:Parameter Name="Original_cal5" Type="DateTime" />
            <asp:Parameter Name="Original_num1" Type="Decimal" />
            <asp:Parameter Name="Original_num2" Type="Decimal" />
            <asp:Parameter Name="Original_num3" Type="Decimal" />
            <asp:Parameter Name="Original_num4" Type="Decimal" />
            <asp:Parameter Name="Original_num5" Type="Decimal" />
            <asp:Parameter Name="Original_txt1" Type="String" />
            <asp:Parameter Name="Original_txt2" Type="String" />
            <asp:Parameter Name="Original_txt3" Type="String" />
            <asp:Parameter Name="Original_txt4" Type="String" />
            <asp:Parameter Name="Original_txt5" Type="String" />
            <asp:Parameter Name="Original_ind1" Type="Boolean" />
            <asp:Parameter Name="Original_ind2" Type="Boolean" />
            <asp:Parameter Name="Original_ind3" Type="Boolean" />
            <asp:Parameter Name="Original_ind4" Type="Boolean" />
            <asp:Parameter Name="Original_ind5" Type="Boolean" />
            <asp:Parameter Name="Original_es_anulada" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_estado_solicitud_general" Type="Int32" />
            <asp:Parameter Name="creado_por" Type="Int32" />
            <asp:Parameter Name="aprobado_por" Type="Int32" />
            <asp:Parameter Name="ejecutado_por" Type="Int32" />
            <asp:Parameter Name="fecha_creacion" Type="DateTime" />
            <asp:Parameter Name="fecha_aprobacion" Type="DateTime" />
            <asp:Parameter Name="fecha_ejecucion" Type="DateTime" />
            <asp:Parameter Name="nitCliente" Type="String" />
            <asp:Parameter Name="codSucursal" Type="String" />
            <asp:Parameter Name="codContacto" Type="String" />
            <asp:Parameter Name="contrato_legalizado" Type="Boolean" />
            <asp:Parameter Name="carta_aceptacion" Type="Boolean" />
            <asp:Parameter Name="personas_entrenamiento" Type="Int32" />
            <asp:Parameter Name="fechaIng" Type="DateTime" />
            <asp:Parameter Name="fechaCie" Type="DateTime" />
            <asp:Parameter Name="observaciones" Type="String" />
            <asp:Parameter Name="observacionesAprobacion" Type="String" />
            <asp:Parameter Name="cal1" Type="DateTime" />
            <asp:Parameter Name="cal2" Type="DateTime" />
            <asp:Parameter Name="cal3" Type="DateTime" />
            <asp:Parameter Name="cal4" Type="DateTime" />
            <asp:Parameter Name="cal5" Type="DateTime" />
            <asp:Parameter Name="num1" Type="Decimal" />
            <asp:Parameter Name="num2" Type="Decimal" />
            <asp:Parameter Name="num3" Type="Decimal" />
            <asp:Parameter Name="num4" Type="Decimal" />
            <asp:Parameter Name="num5" Type="Decimal" />
            <asp:Parameter Name="txt1" Type="String" />
            <asp:Parameter Name="txt2" Type="String" />
            <asp:Parameter Name="txt3" Type="String" />
            <asp:Parameter Name="txt4" Type="String" />
            <asp:Parameter Name="txt5" Type="String" />
            <asp:Parameter Name="ind1" Type="Boolean" />
            <asp:Parameter Name="ind2" Type="Boolean" />
            <asp:Parameter Name="ind3" Type="Boolean" />
            <asp:Parameter Name="ind4" Type="Boolean" />
            <asp:Parameter Name="ind5" Type="Boolean" />
            <asp:Parameter Name="es_anulada" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_estado_solicitud_general" Type="Int32" />
            <asp:Parameter Name="creado_por" Type="Int32" />
            <asp:Parameter Name="aprobado_por" Type="Int32" />
            <asp:Parameter Name="ejecutado_por" Type="Int32" />
            <asp:Parameter Name="fecha_creacion" Type="DateTime" />
            <asp:Parameter Name="fecha_aprobacion" Type="DateTime" />
            <asp:Parameter Name="fecha_ejecucion" Type="DateTime" />
            <asp:Parameter Name="nitCliente" Type="String" />
            <asp:Parameter Name="codSucursal" Type="String" />
            <asp:Parameter Name="codContacto" Type="String" />
            <asp:Parameter Name="contrato_legalizado" Type="Boolean" />
            <asp:Parameter Name="carta_aceptacion" Type="Boolean" />
            <asp:Parameter Name="personas_entrenamiento" Type="Int32" />
            <asp:Parameter Name="fechaIng" Type="DateTime" />
            <asp:Parameter Name="fechaCie" Type="DateTime" />
            <asp:Parameter Name="observaciones" Type="String" />
            <asp:Parameter Name="observacionesAprobacion" Type="String" />
            <asp:Parameter Name="cal1" Type="DateTime" />
            <asp:Parameter Name="cal2" Type="DateTime" />
            <asp:Parameter Name="cal3" Type="DateTime" />
            <asp:Parameter Name="cal4" Type="DateTime" />
            <asp:Parameter Name="cal5" Type="DateTime" />
            <asp:Parameter Name="num1" Type="Decimal" />
            <asp:Parameter Name="num2" Type="Decimal" />
            <asp:Parameter Name="num3" Type="Decimal" />
            <asp:Parameter Name="num4" Type="Decimal" />
            <asp:Parameter Name="num5" Type="Decimal" />
            <asp:Parameter Name="txt1" Type="String" />
            <asp:Parameter Name="txt2" Type="String" />
            <asp:Parameter Name="txt3" Type="String" />
            <asp:Parameter Name="txt4" Type="String" />
            <asp:Parameter Name="txt5" Type="String" />
            <asp:Parameter Name="ind1" Type="Boolean" />
            <asp:Parameter Name="ind2" Type="Boolean" />
            <asp:Parameter Name="ind3" Type="Boolean" />
            <asp:Parameter Name="ind4" Type="Boolean" />
            <asp:Parameter Name="ind5" Type="Boolean" />
            <asp:Parameter Name="es_anulada" Type="Boolean" />
            <asp:Parameter Name="Original_cod_solicitud_general" Type="Int32" />
            <asp:Parameter Name="Original_cod_estado_solicitud_general" Type="Int32" />
            <asp:Parameter Name="Original_creado_por" Type="Int32" />
            <asp:Parameter Name="Original_aprobado_por" Type="Int32" />
            <asp:Parameter Name="Original_ejecutado_por" Type="Int32" />
            <asp:Parameter Name="Original_fecha_creacion" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_aprobacion" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_ejecucion" Type="DateTime" />
            <asp:Parameter Name="Original_nitCliente" Type="String" />
            <asp:Parameter Name="Original_codSucursal" Type="String" />
            <asp:Parameter Name="Original_codContacto" Type="String" />
            <asp:Parameter Name="Original_contrato_legalizado" Type="Boolean" />
            <asp:Parameter Name="Original_carta_aceptacion" Type="Boolean" />
            <asp:Parameter Name="Original_personas_entrenamiento" Type="Int32" />
            <asp:Parameter Name="Original_fechaIng" Type="DateTime" />
            <asp:Parameter Name="Original_fechaCie" Type="DateTime" />
            <asp:Parameter Name="Original_observaciones" Type="String" />
            <asp:Parameter Name="Original_observacionesAprobacion" Type="String" />
            <asp:Parameter Name="Original_cal1" Type="DateTime" />
            <asp:Parameter Name="Original_cal2" Type="DateTime" />
            <asp:Parameter Name="Original_cal3" Type="DateTime" />
            <asp:Parameter Name="Original_cal4" Type="DateTime" />
            <asp:Parameter Name="Original_cal5" Type="DateTime" />
            <asp:Parameter Name="Original_num1" Type="Decimal" />
            <asp:Parameter Name="Original_num2" Type="Decimal" />
            <asp:Parameter Name="Original_num3" Type="Decimal" />
            <asp:Parameter Name="Original_num4" Type="Decimal" />
            <asp:Parameter Name="Original_num5" Type="Decimal" />
            <asp:Parameter Name="Original_txt1" Type="String" />
            <asp:Parameter Name="Original_txt2" Type="String" />
            <asp:Parameter Name="Original_txt3" Type="String" />
            <asp:Parameter Name="Original_txt4" Type="String" />
            <asp:Parameter Name="Original_txt5" Type="String" />
            <asp:Parameter Name="Original_ind1" Type="Boolean" />
            <asp:Parameter Name="Original_ind2" Type="Boolean" />
            <asp:Parameter Name="Original_ind3" Type="Boolean" />
            <asp:Parameter Name="Original_ind4" Type="Boolean" />
            <asp:Parameter Name="Original_ind5" Type="Boolean" />
            <asp:Parameter Name="Original_es_anulada" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </div>

</asp:Content>

