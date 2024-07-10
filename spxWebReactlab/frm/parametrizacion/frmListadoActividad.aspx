<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoActividad.aspx.cs" Inherits="frm_parametrizacion_frmListadoActividad" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Listado Actividades x Sub Tipo de Tarea&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsSubTipoTarea" 
        GridLines="None">
<MasterTableView datakeynames="cod_tipo_actividadxsubtipo_tarea_calendario" 
            datasourceid="odsSubTipoTarea">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Sub Tipo Actividad" UniqueName="TemplateColumn">

            <ItemTemplate>
            <asp:Label runat="server" Text='<%# versubTipo(Eval("cod_subtipo_tarea_calendario")) %>' ID="lblTitulo"></asp:Label>
            </ItemTemplate>


        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="descripcion"
            FilterControlAltText="Filter descripcion column" 
            HeaderText="descripcion" 
            SortExpression="descripcion" 
            UniqueName="descripcion">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="activo" DataType="System.Boolean" 
            FilterControlAltText="Filter activo column" HeaderText="activo" 
            SortExpression="activo" UniqueName="activo">
        </telerik:GridCheckBoxColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            HeaderText="Opciones" UniqueName="TemplateColumn1">
            <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("cod_tipo_actividadxsubtipo_tarea_calendario") %>' />
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/web/delete.gif" 
         OnClientClick="return confirm('Esta seguro de eliminar el registro?');"
        onclick="btnEliminar_Click" ToolTip="Eliminar Registro"
        ValidationGroup=' <%# Eval("cod_tipo_actividadxsubtipo_tarea_calendario") %>'
         />
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
    <asp:ObjectDataSource ID="odsSubTipoTarea" runat="server" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetData" 
        
        
        TypeName="SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter" 
        DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
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
    </div>

</asp:Content>




