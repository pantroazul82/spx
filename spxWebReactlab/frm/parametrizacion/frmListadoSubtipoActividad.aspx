<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoSubtipoActividad.aspx.cs" Inherits="frm_parametrizacion_frmListadoSubtipoActividad" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div class="tab">Listado Sub Tipos de Tarea&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsSubTipoTarea" 
        GridLines="None">
<MasterTableView datakeynames="cod_subtipo_tarea_calendario" 
            datasourceid="odsSubTipoTarea">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1" HeaderText="Tipo Actividad">

             <ItemTemplate>
             <asp:Label runat="server" ID="lblTipoActvidad" Text=' <%# verTipo(Eval("cod_tipo_tarea_calendario")) %>'></asp:Label>

             
            </ItemTemplate>

        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="descripcion"
            FilterControlAltText="Filter descripcion column" 
            HeaderText="descripcion" 
            SortExpression="descripcion" 
            UniqueName="descripcion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="url" 
            FilterControlAltText="Filter url column" HeaderText="url" SortExpression="url" 
            UniqueName="url">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="activo" DataType="System.Boolean" 
            FilterControlAltText="Filter activo column" HeaderText="activo" 
            SortExpression="activo" UniqueName="activo">
        </telerik:GridCheckBoxColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
             <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("cod_subtipo_tarea_calendario") %>' />
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/web/delete.gif" 
         OnClientClick="return confirm('Esta seguro de eliminar el registro?');"
        onclick="btnEliminar_Click" ToolTip="Eliminar Registro"
        ValidationGroup=' <%# Eval("cod_subtipo_tarea_calendario") %>'
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
        
        TypeName="SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter">
    </asp:ObjectDataSource>
    </div>

</asp:Content>



