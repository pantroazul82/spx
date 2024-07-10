<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmDetallesTarea.aspx.cs" Inherits="frm_calendar_frmDetallesTarea" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
     <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />   <style type="text/css">
    
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
    <br />
                    <br />
<div class="tab">Resumen Actividad
    <asp:Label ID="lblCodACtividad" runat="server"></asp:Label>
    &nbsp;<telerik:RadButton ID="btnImprimir" runat="server" onclick="btnImprimir_Click" 
                                    Text="Impimir" >
                                </telerik:RadButton>
                               
    </div>
           <telerik:RadTabStrip ID="RadTabStrip2" runat="server" Skin="Web20" 
                MultiPageID="RadMultiPage1" SelectedIndex="0" >
                <Tabs>
                    <telerik:RadTab Text="Resumen" Selected="True"></telerik:RadTab>
                    <telerik:RadTab Text="Actividades" ></telerik:RadTab>
                    <telerik:RadTab Text="Reactivos"></telerik:RadTab>
                    <telerik:RadTab Text="Archivos Adjuntos"></telerik:RadTab>
                    <telerik:RadTab Text="Informacion Cierre"></telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>

            <telerik:RadMultiPage ID="RadMultiPage1" runat="server" 
        SelectedIndex="0" >
        
        <telerik:RadPageView ID="rpvInfGeneral" runat="server">
        <div class="Formulario">
<table>
<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkPendientes" runat="server" Text="Tiene Pendientes" 
         Enabled="False" />
    </td>
<td>
    <asp:RadioButton ID="rdInterna" runat="server" Checked="True"  Enabled="False" 
        GroupName="interna" Text="Interna" />
    <asp:RadioButton ID="rdExterna" runat="server" GroupName="interna"  Enabled="False" 
        Text="Externa" />
    </td>
<td>
    <asp:CheckBox ID="chkActiva" runat="server"  Enabled="False"  Text="Activa" />
    &nbsp;</td>
<td class="style1">

    <asp:Label ID="lblTittuloAceptacion" runat="server" Text="No Aceptada" 
        ></asp:Label>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblEstado" runat="server" Text="Estado" 
       ></asp:Label>
    </td>
<td>
    <telerik:RadComboBox ID="cmbEstado" Runat="server" 
        DataSourceID="ObjectDataSourceEstado" DataTextField="nombre_estado_tarea" 
        DataValueField="cod_estado_tarea_calendario" Enabled="False" Width="200px" 
        >
    </telerik:RadComboBox>
    <asp:ObjectDataSource ID="ObjectDataSourceEstado" runat="server" 
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
    &nbsp;</td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblResponsable" runat="server" Text="Responsable" 
       ></asp:Label>
    </td>
<td>
    <asp:DropDownList ID="cmbResponsable" Enabled="false" runat="server" 
        DataSourceID="ObjectDataSourceUser" DataTextField="nombre" 
        DataValueField="cod_usuario" >
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
        DataValueField="cod_tipo_tarea_calendario"  Enabled="False" >
    </asp:DropDownList>
    &nbsp;<asp:Label ID="lblConsecutivo" runat="server"></asp:Label>
    </td>
<td>
    <asp:CheckBox ID="chkRequiereAprobacion" runat="server"  Enabled="False" 
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
    <asp:DropDownList ID="cmbSubtipoActividad" runat="server"  Enabled="False" 
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
    <telerik:RadDateTimePicker ID="calInicio" Runat="server"  Enabled="False" >
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td>
    <asp:Label ID="lblFechaEjecucion" runat="server" Text="Fecha Ejecucion"></asp:Label>
    </td>
<td class="style1">
    <telerik:RadDateTimePicker ID="calEjecucion" Runat="server" 
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
<td>Fecha de Terminacion</td>
<td>
    <telerik:RadDateTimePicker ID="calFin" Runat="server"  Enabled="False" >
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
    <telerik:RadDateTimePicker ID="calFinEjecucion" Runat="server"
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
<td>Descripcion</td>
<td>
    <asp:TextBox ID="txtDescripcion" runat="server" Width="300px"  Enabled="False" ></asp:TextBox>
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
    <asp:CheckBox ID="chkAtadaCliente" runat="server" Text="Atada a Cliente"   Enabled="False" />
    </td>
<td colspan="4">
    <asp:TextBox ID="txtCliente" runat="server" style="visibility:hidden;" 
        Width="200px"></asp:TextBox>
&nbsp;<asp:Label ID="lblSucursal" runat="server" Text="Sucursal" style="visibility:hidden;"></asp:Label>
&nbsp;<asp:DropDownList Enabled="False" ID="cmbSucursal" runat="server" style="visibility:hidden;">
    </asp:DropDownList>
&nbsp;<asp:Label ID="lblContacto"  Enabled="False" runat="server" Text="Contacto" style="visibility:hidden;"></asp:Label>
&nbsp;
    <asp:DropDownList ID="cmbContacto" Enabled="false" runat="server" style="visibility:hidden;">
    </asp:DropDownList>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaModelo" runat="server" Text="Atada a Modelo(s)"  Enabled="False" />
    </td>
<td colspan="4">
  <br />&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblModelos" runat="server" style= "visibility:hidden;"></asp:Label>
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaSerial" runat="server" Text="Atada a Serial" Enabled="False"  />
    </td>
<td colspan="4">
    <asp:TextBox ID="txtSerial" runat="server" Enabled="False" />
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAtadaReactivo" runat="server" Text="Atada a Reactivo(s)"  Enabled="False"  />
    </td>
<td colspan="4">
<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Label ID="lblReactivo" runat="server"></asp:Label>
    <br />
    </td>
</tr>

<tr>
<td></td>
<td valign="top">Observaciones Iniciales</td>
<td colspan="3">
    <asp:TextBox ID="txtObservaciones" runat="server" Height="68px" Width="424px"  Enabled="False" 
        TextMode="MultiLine"></asp:TextBox>
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

<td class="style2">&nbsp;</td>
</tr>

<tr>
<td></td>
<td></td>
<td colspan="2">

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




                </telerik:RadPageView> 
                <telerik:RadPageView ID="rpvActividades" runat="server">
                                                <telerik:RadGrid ID="grdACtividad" runat="server" AutoGenerateColumns="False" 
                                    CellSpacing="0" DataSourceID="odsListadoActividades" GridLines="None">
                                    <MasterTableView DataKeyNames="cod_actividadxtarea_calendario" 
                                        DataSourceID="odsListadoActividades">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                                            Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                                            Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridBoundColumn DataField="nombre" 
                                                FilterControlAltText="Filter nombre column" HeaderText="nombre" 
                                                SortExpression="nombre" UniqueName="nombre">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="actividad" 
                                                FilterControlAltText="Filter actividad column" HeaderText="actividad" 
                                                SortExpression="actividad" UniqueName="actividad">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="fecha_creacion" DataType="System.DateTime" 
                                                FilterControlAltText="Filter fecha_creacion column" HeaderText="fecha_creacion" 
                                                SortExpression="fecha_creacion" UniqueName="fecha_creacion">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="descripcion_actividad" 
                                                FilterControlAltText="Filter descripcion_actividad column" 
                                                HeaderText="descripcion_actividad" SortExpression="descripcion_actividad" 
                                                UniqueName="descripcion_actividad">
                                                <ItemStyle Width="300px" />
                                            </telerik:GridBoundColumn>
                                        </Columns>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                    </MasterTableView>
                                    <FilterMenu EnableImageSprites="False">
                                        <WebServiceSettings>
                                            <ODataSettings InitialContainerName="">
                                            </ODataSettings>
                                        </WebServiceSettings>
                                    </FilterMenu>
                                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                        <WebServiceSettings>
                                            <ODataSettings InitialContainerName="">
                                            </ODataSettings>
                                        </WebServiceSettings>
                                    </HeaderContextMenu>
                                </telerik:RadGrid>
                                <asp:ObjectDataSource ID="odsListadoActividades" runat="server" 
                                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                                    TypeName="SPControladoraDatos.dsPlantillasTableAdapters.pltListadoActividadesxTareasTableAdapter">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lblCodACtividad" Name="cod_tarea_calendario" 
                                            PropertyName="Text" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                </telerik:RadPageView>     
                           
                   

                 <telerik:RadPageView ID="rpvReactivos" runat="server">

                  <telerik:RadGrid ID="grdReactivos" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" DataSourceID="SqlDataSourceR" GridLines="None">
                        <MasterTableView 
                            DataSourceID="SqlDataSourceR">
                            <CommandItemSettings ExportToPdfText="Export to PDF" />
                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                                Visible="True">
                                <HeaderStyle Width="20px" />
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                                Visible="True">
                                <HeaderStyle Width="20px" />
                            </ExpandCollapseColumn>
                            <Columns>
                               <telerik:GridBoundColumn DataField="cod_reactivoxtarea" 
                                    FilterControlAltText="Filter column column" UniqueName="column" 
                                    Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="nombre_fabricante" 
                                    FilterControlAltText="Filter nombre_fabricante column" HeaderText="Fabricante" 
                                    SortExpression="nombre_fabricante" UniqueName="nombre_fabricante">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="nombre_referencia_reactivo" 
                                    FilterControlAltText="Filter nombre_referencia_reactivo column" 
                                    HeaderText="Referencia reactivo" SortExpression="nombre_referencia_reactivo" 
                                    UniqueName="nombre_referencia_reactivo">
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                    HeaderText="Lote" UniqueName="TemplateColumn">
                                    <ItemTemplate>
                                     <asp:TextBox ID="txtLote"
                                     Text='<%# Eval("lote") %>' ReadOnly="true"
                                     ValidationGroup='<%# Eval("cod_reactivoxtarea") %>'
                                      runat="server"></asp:TextBox>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
                                    HeaderText="Fecha de Inicio" UniqueName="TemplateColumn1">
                                    <ItemTemplate>
                                      <telerik:RadDatePicker ID="calInicio" Runat="server" Enabled="False"
                                     SelectedDate='<%#(Eval("fecha_inicio") == null || Eval("fecha_inicio") == System.DBNull.Value) ? ((DateTime?)null) : Eval("fecha_inicio")  %>'
                                      >
                    </telerik:RadDatePicker>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn2 column" 
                                    HeaderText="Fecha Vencimiento" UniqueName="TemplateColumn2">
                                      <ItemTemplate>
                                      <telerik:RadDatePicker ID="calFin" Runat="server"  Enabled="False"
                                      SelectedDate='<%#(Eval("fecha_vencimiento") == null || Eval("fecha_vencimiento") == System.DBNull.Value) ? ((DateTime?)null) : Eval("fecha_vencimiento")%>'
                                      >
                    </telerik:RadDatePicker>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                            </Columns>
                            <EditFormSettings>
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                            <WebServiceSettings>
                                <ODataSettings InitialContainerName="">
                                </ODataSettings>
                            </WebServiceSettings>
                        </FilterMenu>
                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                            <WebServiceSettings>
                                <ODataSettings InitialContainerName="">
                                </ODataSettings>
                            </WebServiceSettings>
                        </HeaderContextMenu>
                    </telerik:RadGrid>
                    <asp:SqlDataSource ID="SqlDataSourceR" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select cod_tarea_calendario,
referencia_reactivo.cod_referencia_reactivo,cod_reactivoxtarea,
lote,fecha_inicio,fecha_vencimiento,
nombre_referencia_reactivo,
fabricante.nombre_fabricante
from reactivoxtarea
join dbo.referencia_reactivo on 
referencia_reactivo.cod_referencia_reactivo=reactivoxtarea.cod_referencia_reactivo
join fabricante on fabricante.codfabricante = referencia_reactivo.codfabricante
where reactivoxtarea.cod_tarea_calendario=@cod_tarea_calendario">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="lblCodACtividad" Name="cod_tarea_calendario" 
                                PropertyName="Text" />
                        </SelectParameters>
                    </asp:SqlDataSource>

                </telerik:RadPageView>    
                     
                <telerik:RadPageView ID="rpvArchivos" runat="server" >
                
                    <telerik:RadGrid ID="grdArchivos" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" DataSourceID="SqlArchivos" GridLines="None">
                        <MasterTableView DataKeyNames="codarchivosxtarea_calendario" 
                            DataSourceID="SqlArchivos">
                            <CommandItemSettings ExportToPdfText="Export to PDF" />
                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                                Visible="True">
                                <HeaderStyle Width="20px" />
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                                Visible="True">
                                <HeaderStyle Width="20px" />
                            </ExpandCollapseColumn>
                            <Columns>
                               <telerik:GridBoundColumn DataField="nombreArchivo" 
                                    FilterControlAltText="Filter nombreArchivo column" HeaderText="nombreArchivo" 
                                    SortExpression="nombreArchivo" UniqueName="nombreArchivo">
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                    UniqueName="TemplateColumn" HeaderText="Opciones">
                                    <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="btnBajarArchivo" ImageUrl="~/img/web/lookup.gif" 
                                    ValidationGroup='<%# Eval("codarchivosxtarea_calendario") %>' OnClick="bajarArchivo"
                                     />

                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                            </Columns>
                            <EditFormSettings>
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                            <WebServiceSettings>
                                <ODataSettings InitialContainerName="">
                                </ODataSettings>
                            </WebServiceSettings>
                        </FilterMenu>
                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                            <WebServiceSettings>
                                <ODataSettings InitialContainerName="">
                                </ODataSettings>
                            </WebServiceSettings>
                        </HeaderContextMenu>
                    </telerik:RadGrid>
                    <asp:SqlDataSource ID="SqlArchivos" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select 
codarchivosxtarea_calendario, nombreArchivo
from archivosxtarea_calendario
where cod_tarea_calendario=@cod_tarea_calendario">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="lblCodACtividad" Name="cod_tarea_calendario" 
                                PropertyName="Text" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </telerik:RadPageView>
                
                <telerik:RadPageView ID="rpvInformacionCierre" runat="server" >
 <div class="Formulario">
<table>

    <tr>
        <td>
            &nbsp;</td>
        <td>
            Fecha Cierre Parcial&nbsp;&nbsp;&nbsp;
            <telerik:RadDateTimePicker ID="calCierreParcial" Runat="server" Enabled="False">
            </telerik:RadDateTimePicker>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha Cierre Total
            <telerik:RadDateTimePicker ID="calCierre" Runat="server" Enabled="False">
            </telerik:RadDateTimePicker>
        </td>
    </tr>

<tr>
<td></td>
<td>
    Pendientes&nbsp;
        <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="ObjectDataSourcePen" GridLines="None">
<MasterTableView DataKeyNames="cod_pendiente_tarea" DataSourceID="ObjectDataSourcePen">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="pendiente" 
            FilterControlAltText="Filter pendiente column" HeaderText="pendiente" 
            SortExpression="pendiente" UniqueName="pendiente">
        </telerik:GridBoundColumn>
        
        
        
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>  
            <asp:Label runat="server" ID="lblUser" Text='<%# verNombreUsuario(Eval("usuario_ejecucion")) %>'
            ></asp:Label>
            
    
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        

        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>  
            <telerik:RadDateTimePicker ID="RadDateTimePicker1" Runat="server" 
            SelectedDate='<%# ((Eval("fecha_ejecucion_pendiente") == null || Eval("fecha_ejecucion_pendiente") == System.DBNull.Value)?((DateTime?)null):(DateTime?)Eval("fecha_ejecucion_pendiente")) %>'
            Enabled='<%# (Eval("fecha_ejecucion_pendiente") == null || Eval("fecha_ejecucion_pendiente") == System.DBNull.Value) %>'
              >
    </telerik:RadDateTimePicker>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        
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
    <asp:ObjectDataSource ID="ObjectDataSourcePen" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCod_tarea_calendario" 
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_pendiente_tarea" Type="Int32" />
            <asp:Parameter Name="Original_cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_pendiente" Type="String" />
            <asp:Parameter Name="Original_fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="Original_usuario_ejecucion" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="pendiente" Type="String" />
            <asp:Parameter Name="fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="usuario_ejecucion" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="lblCodActividad" Name="cod_tarea_calendario" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="pendiente" Type="String" />
            <asp:Parameter Name="fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="usuario_ejecucion" Type="Int32" />
            <asp:Parameter Name="Original_cod_pendiente_tarea" Type="Int32" />
            <asp:Parameter Name="Original_cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_pendiente" Type="String" />
            <asp:Parameter Name="Original_fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="Original_usuario_ejecucion" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
</tr>

    <tr>
        <td>
            &nbsp;</td>
        <td>
            Contacto Cierre
            <asp:TextBox ID="txtContactoCierre" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>

<tr>
<td>&nbsp;</td>
<td rowspan="3">
    Observaciones Cierre parcial</td>
</tr>



    <tr>
        <td>
            &nbsp;</td>
    </tr>



<tr>
<td>&nbsp;</td>
</tr>

<tr>
<td></td>
<td>
    <asp:TextBox ID="txtObservacionesCierreParcial" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px" Enabled="False"></asp:TextBox>
    </td>

</tr>

<tr>
<td>&nbsp;</td>
<td>
    Solucionado
     <asp:RadioButton ID="rdSi" runat="server" GroupName="d" Text="Si" 
        Enabled="False" />
    <asp:RadioButton ID="rdNo" runat="server" GroupName="d" Text="No" 
        Enabled="False" />
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    Razon?</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:TextBox ID="txtRazon" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px" Enabled="False"></asp:TextBox>
    </td>
</tr>

<tr>
<td>
    &nbsp;</td>
<td>
       
           
    Cierre Final:</td>
</tr>


    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:TextBox ID="txtCierreFinal" runat="server" Enabled="False" Height="129px" 
                TextMode="MultiLine" Width="443px"></asp:TextBox>
        </td>
    </tr>


</table>

</div>           
             
                </telerik:RadPageView>
      
            </telerik:RadMultiPage>
            <telerik:RadFormDecorator runat="server" ID="RadFormDecorator1" DecoratedControls="Textarea" />



</asp:Content>



