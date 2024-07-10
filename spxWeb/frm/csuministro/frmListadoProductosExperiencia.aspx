<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoProductosExperiencia.aspx.cs" Inherits="frm_csuministro_frmListadoProductosExperiencia" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div class="tab">Listado productos experiencia&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlDataSource1" 
        GridLines="None" Culture="es-ES">
<MasterTableView datakeynames="cod_producto_experiencia_contrato" 
            datasourceid="SqlDataSource1">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>
<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="cod_producto_experiencia_contrato" 
            DataType="System.Int32"
            FilterControlAltText="Filter cod_producto_experiencia_contrato column" 
            HeaderText="Codigo" ReadOnly="True" 
            SortExpression="cod_producto_experiencia_contrato" 
            UniqueName="cod_producto_experiencia_contrato">
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="nombre_fabricante" 
            FilterControlAltText="Filter nombre_fabricante column" HeaderText="Fabricante" 
            SortExpression="nombre_fabricante" UniqueName="nombre_fabricante">
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="nombre_producto" 
            FilterControlAltText="Filter nombre_producto column" HeaderText="Producto" 
            SortExpression="nombre_producto" UniqueName="nombre_producto">
        </telerik:GridBoundColumn>

        
        <telerik:GridBoundColumn DataField="codigo_manual_referencia" 
            FilterControlAltText="Filter codigo_manual_referencia column" HeaderText="Codigo manual (referencia)" 
            SortExpression="codigo_manual_referencia" UniqueName="codigo_manual_referencia">
        </telerik:GridBoundColumn>

        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("cod_producto_experiencia_contrato") %>' />
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/web/delete.gif" 
         OnClientClick="return confirm('Esta seguro de eliminar el registro?');"
        onclick="btnEliminar_Click" ToolTip="Eliminar Registro"
        ValidationGroup=' <%# Eval("cod_producto_experiencia_contrato") %>'
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT 
        producto_experiencia_contrato.cod_producto_experiencia_contrato,
         fabricante.nombre_fabricante, producto_experiencia_contrato.nombre_producto, 
        producto_experiencia_contrato.codigo_manual_referencia
         FROM producto_experiencia_contrato INNER JOIN fabricante ON producto_experiencia_contrato.cod_fabricante = fabricante.cod_fabricante"></asp:SqlDataSource>
    </div>

</asp:Content>




