<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoMotivosAnulacion.aspx.cs" Inherits="frm_csuministro_frmListadoMotivosAnulacion" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Listado Motivos de anulación&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlDataSource1" 
        GridLines="None" Culture="es-ES">
<MasterTableView datakeynames="cod_motivo_anulacion_suministro" 
            datasourceid="SqlDataSource1">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="cod_motivo_anulacion_suministro" 
            DataType="System.Int32"
            FilterControlAltText="Filter cod_motivo_anulacion_suministro column" 
            HeaderText="Codigo" ReadOnly="True" 
            SortExpression="cod_motivo_anulacion_suministro" 
            UniqueName="cod_motivo_anulacion_suministro">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_motivo_anulacion_suministro" 
            FilterControlAltText="Filter nombre_motivo_anulacion_suministro column" HeaderText="Motivo Anulacion" 
            SortExpression="nombre_motivo_anulacion_suministro" UniqueName="nombre_motivo_anulacion_suministro">
        </telerik:GridBoundColumn>

        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("cod_motivo_anulacion_suministro") %>' />
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/web/delete.gif" 
         OnClientClick="return confirm('Esta seguro de eliminar el registro?');"
        onclick="btnEliminar_Click" ToolTip="Eliminar Registro"
        ValidationGroup=' <%# Eval("cod_motivo_anulacion_suministro") %>'
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
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_motivo_anulacion_suministro], [nombre_motivo_anulacion_suministro] FROM [motivo_anulacion_suministro] ORDER BY [nombre_motivo_anulacion_suministro]"></asp:SqlDataSource>
    
    </div>

</asp:Content>



