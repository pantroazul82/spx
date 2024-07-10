<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmEjectarTarea.aspx.cs" Inherits="frm_calendar_frmEjectarTarea" %>


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
                                                                                             .style3
                                                                                             {
                                                                                                 width: 100%;
                                                                                             }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div class="tab">Ejecucion de Actividad
    <asp:Label ID="lblCodACtividad" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;<telerik:RadButton ID="btnImprimir" runat="server" onclick="btnImprimir_Click" 
                                    Text="Imprimir">
                                </telerik:RadButton>
                                <asp:Button ID="btnCambiarEstado" runat="server" 
                                    onclick="btnCambiarEstado_Click" 
                                    OnClientClick="return confirm('Esta seguro de Cerrar la actividad?');" 
                                    Text="Cerrar" Visible="False" />
                                <asp:Button ID="btnVerdetalles" runat="server" 
                                    onclick="btnVerdetalles_Click" 
                                    Text="Ver Detalle" />
                                         <asp:Button ID="btnVolver" runat="server" 
                                    onclick="btnVolver_Click" 
                                    Text="Volver" />
    </div>
           <telerik:RadTabStrip ID="RadTabStrip2" runat="server" Skin="Web20" 
                MultiPageID="RadMultiPage1" SelectedIndex="0" >
                <Tabs>
                    <telerik:RadTab Text="Actividades" Selected="True"></telerik:RadTab>
                    <telerik:RadTab Text="Archivos Adjuntos" ></telerik:RadTab>
                    <telerik:RadTab Text="Informacion reactivos"></telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>
<div class="Formulario">
            <telerik:RadMultiPage ID="RadMultiPage1" runat="server" 
        SelectedIndex="0" >
                <telerik:RadPageView ID="rpvActividades" runat="server">
           
                    <table class="style3">
                        <tr>
                            <td>
                                <asp:Label ID="lblEstado" runat="server" Text="Estado" Visible="False"></asp:Label>
                            </td>
                            <td>
                            <asp:DropDownList
                                 ID="cmbEstado" Runat="server" 
                                    DataSourceID="ObjectDataSource1" DataTextField="nombre_estado_tarea" 
                                    DataValueField="cod_estado_tarea_calendario" Enabled="False" Visible="False" 
                                    Width="200px"
                                ></asp:DropDownList>
                            </td>
                            <td>
                                <asp:CheckBox ID="chkActiva" runat="server" Checked="true" Text="Activa" 
                                    Enabled="False" />
                            </td>
                            <td>
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
                                <asp:Label ID="lblConsecutivo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Tipo de Actividad</td>
                            <td>
                                <asp:DropDownList ID="cmbtipoActividad" runat="server" AutoPostBack="True" 
                                    DataSourceID="odsTipoActividad" DataTextField="descripcion" 
                                    DataValueField="cod_tipo_tarea_calendario">
                                </asp:DropDownList>
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
                            <td>
                                Sub tipo de Actividad</td>
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
                        </tr>
                        <tr>
                            <td>
                                Fecha de Inicio</td>
                            <td>
                                <telerik:RadDateTimePicker ID="calInicio" Runat="server" Enabled="False">
                               <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                                </telerik:RadDateTimePicker>
                            </td>
                            <td>
                                Fecha de Terminacion</td>
                            <td>
                                <telerik:RadDateTimePicker ID="calFin" Runat="server" Enabled="False">
                                <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                                </telerik:RadDateTimePicker>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                            <asp:Panel runat="server" ID="pnlReactivos" Visible="false">
                            
                            reactivos
                            </asp:Panel>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="3">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Actividad</td>
                            <td colspan="3">
                                <telerik:RadComboBox ID="cmbActividad" Runat="server" 
                                    DataSourceID="odsActividadesxSubtipo" DataTextField="descripcion" 
                                    DataValueField="cod_tipo_actividadxsubtipo_tarea_calendario" Width="200px">
                                </telerik:RadComboBox>
                                <asp:ObjectDataSource ID="odsActividadesxSubtipo" runat="server" 
                                    DeleteMethod="Delete" InsertMethod="Insert" 
                                    OldValuesParameterFormatString="original_{0}" 
                                    SelectMethod="GetDataByCod_subtipo_tarea_calendarioActivo" 
                                    TypeName="SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter" 
                                    UpdateMethod="Update">
                                    <DeleteParameters>
                                        <asp:Parameter Name="Original_cod_tipo_actividadxsubtipo_tarea_calendario" 
                                            Type="Int32" />
                                        <asp:Parameter Name="Original_cod_subtipo_tarea_calendario" Type="Int32" />
                                        <asp:Parameter Name="Original_descripcion" Type="String" />
                                        <asp:Parameter Name="Original_activo" Type="Boolean" />
                                    </DeleteParameters>
                                    <InsertParameters>
                                        <asp:Parameter Name="cod_subtipo_tarea_calendario" Type="Int32" />
                                        <asp:Parameter Name="descripcion" Type="String" />
                                        <asp:Parameter Name="activo" Type="Boolean" />
                                    </InsertParameters>
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="cmbSubtipoActividad" 
                                            Name="cod_subtipo_tarea_calendario" PropertyName="SelectedValue" Type="Int32" />
                                        <asp:Parameter DefaultValue="true" Name="activo" Type="Boolean" />
                                    </SelectParameters>
                                    <UpdateParameters>
                                        <asp:Parameter Name="cod_subtipo_tarea_calendario" Type="Int32" />
                                        <asp:Parameter Name="descripcion" Type="String" />
                                        <asp:Parameter Name="activo" Type="Boolean" />
                                        <asp:Parameter Name="Original_cod_tipo_actividadxsubtipo_tarea_calendario" 
                                            Type="Int32" />
                                        <asp:Parameter Name="Original_cod_subtipo_tarea_calendario" Type="Int32" />
                                        <asp:Parameter Name="Original_descripcion" Type="String" />
                                        <asp:Parameter Name="Original_activo" Type="Boolean" />
                                    </UpdateParameters>
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Observaciones Actividad</td>
                            <td colspan="3">
                                <asp:TextBox ID="txtObservacionesActividad" runat="server" Height="49px" 
                                    TextMode="MultiLine" Width="478px"></asp:TextBox>
                                <telerik:RadButton ID="btnAgregar" runat="server" Text="Agregar Actividad" 
                                    onclick="btnAgregar_Click">
                                </telerik:RadButton>
                                <asp:Label ID="lblErrorActividad" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                Actividades Ingresadas</td>
                        </tr>
                        <tr>
                            <td colspan="4">
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
                                            <telerik:GridTemplateColumn>
                                            <ItemTemplate>
                                            <asp:ImageButton runat="server" Visible='<%# validarEliminar( Eval("cod_usuario")) %>' ID="btnQuitar" ValidationGroup='<%# Eval("cod_actividadxtarea_calendario") %>'
                                            ImageUrl="~/img/web/delete.gif" OnClick="eliminarTarea" ToolTip="Quitar Actividad " OnClientClick="return confirm('Esta seguro de quitar la actividad?');"
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
                                <asp:ObjectDataSource ID="odsListadoActividades" runat="server" 
                                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                                    TypeName="SPControladoraDatos.dsPlantillasTableAdapters.pltListadoActividadesxTareasTableAdapter">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lblCodACtividad" Name="cod_tarea_calendario" 
                                            PropertyName="Text" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
           
                </telerik:RadPageView>                
                    
                <telerik:RadPageView ID="rpvArchivos" runat="server" >
                    &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
                    &nbsp;<telerik:RadButton ID="btnGuardarArchivo" runat="server" 
                        onclick="btnGuardarArchivo_Click" Text="Guardar Archivo">
                    </telerik:RadButton>
                    &nbsp;<asp:Label ID="lblErrorArchivo" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
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
                                    
                                    <asp:ImageButton runat="server" ID="btnEliminarArchivo" ImageUrl="~/img/web/delete.gif" 
                                    OnClientClick=" return confirm('Esta seguro de eliminar el archivo?');" 
                                    ValidationGroup='<%# Eval("codarchivosxtarea_calendario") %>' OnClick="eliminarArchivo"  />

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
                
               <telerik:RadPageView ID="rpvReactivos" runat="server" >
                    &nbsp;&nbsp;<telerik:RadButton ID="btnGuardarInformacionREactivos" runat="server" 
                        Text="Guardar Informacion Reactivos" 
                        onclick="btnGuardarInformacionREactivos_Click">
                    </telerik:RadButton>
                    &nbsp;<asp:Label ID="lblErrorREactivos" runat="server" ForeColor="Red"></asp:Label>
                  
                   
                    <br />
                    <br />
                    <telerik:RadGrid ID="grdReactivos" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None">
                        <MasterTableView 
                            DataSourceID="SqlDataSource1">
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
                                     Text='<%# Eval("lote") %>'
                                     ValidationGroup='<%# Eval("cod_reactivoxtarea") %>'
                                      runat="server"></asp:TextBox>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
                                    HeaderText="Fecha de Inicio" UniqueName="TemplateColumn1">
                                    <ItemTemplate>
                                      <telerik:RadDatePicker ID="calInicio" Runat="server"
                                     SelectedDate='<%#(Eval("fecha_inicio") == null || Eval("fecha_inicio") == System.DBNull.Value) ? ((DateTime?)null) : Eval("fecha_inicio")  %>'
                                      >
                                      <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                    </telerik:RadDatePicker>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn2 column" 
                                    HeaderText="Fecha Vencimiento" UniqueName="TemplateColumn2">
                                      <ItemTemplate>
                                      <telerik:RadDatePicker ID="calFin" Runat="server" 
                                      SelectedDate='<%#(Eval("fecha_vencimiento") == null || Eval("fecha_vencimiento") == System.DBNull.Value) ? ((DateTime?)null) : Eval("fecha_vencimiento")%>'
                                      >
                                      <Calendar ID="Calendar11" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
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
                
      
            </telerik:RadMultiPage>
            <telerik:RadFormDecorator runat="server" ID="RadFormDecorator1" DecoratedControls="Textarea" />


</div>
</asp:Content>

