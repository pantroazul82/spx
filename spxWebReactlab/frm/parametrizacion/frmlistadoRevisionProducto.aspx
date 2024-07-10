<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmlistadoRevisionProducto.aspx.cs" Inherits="frm_parametrizacion_frmlistadoRevisionProducto" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Listado estado de Revision Producto&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsSubTipoTarea" 
        GridLines="None">
<MasterTableView datakeynames="cod_revision_estado_producto" 
            datasourceid="odsSubTipoTarea">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="cod_revision_estado_producto" 
            DataType="System.Int32" Visible="false"
            FilterControlAltText="Filter cod_revision_estado_producto column" 
            HeaderText="cod_revision_estado_producto" ReadOnly="True" 
            SortExpression="cod_revision_estado_producto" 
            UniqueName="cod_revision_estado_producto">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="descripcion" 
            FilterControlAltText="Filter descripcion column" HeaderText="descripcion" 
            SortExpression="descripcion" UniqueName="descripcion">
        </telerik:GridBoundColumn>      
        <telerik:GridCheckBoxColumn DataField="activo" DataType="System.Boolean" 
            FilterControlAltText="Filter activo column" HeaderText="activo" 
            SortExpression="activo" UniqueName="activo">
        </telerik:GridCheckBoxColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("cod_revision_estado_producto") %>' />
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/web/delete.gif" 
         OnClientClick="return confirm('Esta seguro de eliminar el registro?');"
        onclick="btnEliminar_Click" ToolTip="Eliminar Registro"
        ValidationGroup=' <%# Eval("cod_revision_estado_producto") %>'
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
        
        
        
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter">
    </asp:ObjectDataSource>
    </div>

</asp:Content>

