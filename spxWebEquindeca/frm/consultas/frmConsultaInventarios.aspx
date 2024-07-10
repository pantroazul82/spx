<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmConsultaInventarios.aspx.cs" Inherits="frm_consultas_frmConsultaInventarios" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <p>
        &nbsp;</p>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <strong>Consulta de Inventarios</strong></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="3">
                <asp:DropDownList ID="cmbFiltros" runat="server">
                    <asp:ListItem>Serial</asp:ListItem>
                    <asp:ListItem>Cliente</asp:ListItem>
                    <asp:ListItem>Bodega</asp:ListItem>
                    <asp:ListItem>Seccion Bodega</asp:ListItem>
                    <asp:ListItem>Item</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="txtFiltros" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                    Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:CheckBox ID="chkIngrsos" runat="server" 
                    Text="Incluir solo registros ingresados en" />
            </td>
            <td>
                <telerik:RadDatePicker ID="calIni" Runat="server">
                </telerik:RadDatePicker>
            </td>
            <td>
                <telerik:RadDatePicker ID="calFin" Runat="server">
                </telerik:RadDatePicker>
            </td>
        </tr>
    
    </table>
    <p>    &nbsp;<telerik:RadGrid ID="RadGrid1" runat="server" 
        AutoGenerateColumns="False" CellSpacing="0" GridLines="None">
<MasterTableView DataKeyNames="cod_inventario">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="cod_inventario" DataType="System.Int32" 
            FilterControlAltText="Filter cod_inventario column" HeaderText="cod_inventario" 
            ReadOnly="True" SortExpression="cod_inventario" UniqueName="cod_inventario">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_item" 
            FilterControlAltText="Filter nombre_item column" HeaderText="nombre_item" 
            SortExpression="nombre_item" UniqueName="nombre_item">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cod_alterno" 
            FilterControlAltText="Filter cod_alterno column" HeaderText="cod_alterno" 
            SortExpression="cod_alterno" UniqueName="cod_alterno">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_ingreso" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_ingreso column" HeaderText="fecha_ingreso" 
            SortExpression="fecha_ingreso" UniqueName="fecha_ingreso">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ingresado_por" 
            FilterControlAltText="Filter ingresado_por column" HeaderText="ingresado_por" 
            SortExpression="ingresado_por" UniqueName="ingresado_por">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_seccion_bodega" 
            FilterControlAltText="Filter nombre_seccion_bodega column" 
            HeaderText="nombre_seccion_bodega" SortExpression="nombre_seccion_bodega" 
            UniqueName="nombre_seccion_bodega">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_bodega_logica" 
            FilterControlAltText="Filter nombre_bodega_logica column" 
            HeaderText="nombre_bodega_logica" SortExpression="nombre_bodega_logica" 
            UniqueName="nombre_bodega_logica">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="bodega_fisica" 
            FilterControlAltText="Filter bodega_fisica column" HeaderText="bodega_fisica" 
            SortExpression="bodega_fisica" UniqueName="bodega_fisica">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_estado_conservacion" 
            FilterControlAltText="Filter nombre_estado_conservacion column" 
            HeaderText="nombre_estado_conservacion" 
            SortExpression="nombre_estado_conservacion" 
            UniqueName="nombre_estado_conservacion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_estado_subproceso" 
            FilterControlAltText="Filter nombre_estado_subproceso column" 
            HeaderText="nombre_estado_subproceso" SortExpression="nombre_estado_subproceso" 
            UniqueName="nombre_estado_subproceso">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_estado_proceso_interno" 
            FilterControlAltText="Filter nombre_estado_proceso_interno column" 
            HeaderText="nombre_estado_proceso_interno" 
            SortExpression="nombre_estado_proceso_interno" 
            UniqueName="nombre_estado_proceso_interno">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cantidad" DataType="System.Int32" 
            FilterControlAltText="Filter cantidad column" HeaderText="cantidad" 
            SortExpression="cantidad" UniqueName="cantidad">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="cod_reserva_inventario" 
            DataType="System.Int32" 
            FilterControlAltText="Filter cod_reserva_inventario column" 
            HeaderText="cod_reserva_inventario" SortExpression="cod_reserva_inventario" 
            UniqueName="cod_reserva_inventario">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="serial" 
            FilterControlAltText="Filter serial column" HeaderText="serial" 
            SortExpression="serial" UniqueName="serial">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_vencimiento" 
            DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_vencimiento column" 
            HeaderText="fecha_vencimiento" SortExpression="fecha_vencimiento" 
            UniqueName="fecha_vencimiento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="numero_lote" 
            FilterControlAltText="Filter numero_lote column" HeaderText="numero_lote" 
            SortExpression="numero_lote" UniqueName="numero_lote">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_cliente" 
            FilterControlAltText="Filter nombre_cliente column" HeaderText="nombre_cliente" 
            SortExpression="nombre_cliente" UniqueName="nombre_cliente">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="documento" 
            FilterControlAltText="Filter documento column" HeaderText="documento" 
            SortExpression="documento" UniqueName="documento">
        </telerik:GridBoundColumn>
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
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select  inventario.cod_inventario, item.nombre_item,item.cod_alterno 
,inventario.fecha_ingreso, usuario.nombre 'ingresado_por',seccion_bodega.nombre_seccion_bodega, 
bodega_logica.nombre_bodega_logica,bodega_fisica= nombre_bodega_fisica, estado_conservacion.nombre_estado_conservacion, 
estado_subproceso.nombre_estado_subproceso,estado_proceso_interno.nombre_estado_proceso_interno, 
cantidad,cod_reserva_inventario,serial,fecha_vencimiento,numero_lote, cliente.nombre_cliente,cliente.documento  
from inventario   
left join usuario on usuario.cod_usuario=inventario.ingresado_por  
left join seccion_bodega on seccion_bodega.cod_seccion_bodega=inventario.cod_seccion_bodega    
left join bodega_logica on bodega_logica.cod_bodega_logica=inventario.cod_bodega_logica 
left join bodega_fisica on bodega_logica.cod_bodega_fisica = bodega_fisica.cod_bodega_fisica  
left join estado_conservacion on estado_conservacion.cod_estado_conservacion=inventario.cod_estado_conservacion   
left join estado_subproceso on estado_subproceso.cod_estado_subproceso=inventario.cod_estado_subproceso  
left join estado_proceso_interno on estado_proceso_interno.cod_estado_proceso_interno=inventario.cod_estado_proceso_interno   
left join item on item.cod_item=inventario.cod_item  
left join cliente on cliente.cod_cliente = inventario.cod_cliente 
">
</asp:SqlDataSource>
        &nbsp;</p>
    <p>
    </p>


</asp:Content>

