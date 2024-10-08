﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmListadoControlesCalidad.aspx.cs" Inherits="Web2020.frm.parametrizacion.frmListadoControlesCalidad" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Listado Controles Calidad&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsSubTipoTarea" 
        GridLines="None">
<MasterTableView datakeynames="cod_controles_calidad" 
            datasourceid="odsSubTipoTarea">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="cod_controles_calidad" 
            DataType="System.Int32" Visible="false"
            FilterControlAltText="Filter cod_controles_calidad column" 
            HeaderText="cod_controles_calidad" ReadOnly="True" 
            SortExpression="cod_controles_calidad" 
            UniqueName="cod_controles_calidad">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="controles_calidad" 
            FilterControlAltText="Filter controles_calidad column" HeaderText="controles_calidad" 
            SortExpression="controles_calidad" UniqueName="controles_calidad">
        </telerik:GridBoundColumn>      
        <telerik:GridCheckBoxColumn DataField="activo" DataType="System.Boolean" 
            FilterControlAltText="Filter activo column" HeaderText="activo" 
            SortExpression="activo" UniqueName="activo">
        </telerik:GridCheckBoxColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("cod_controles_calidad") %>' />
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/web/delete.gif" 
         OnClientClick="return confirm('Esta seguro de eliminar el registro?');"
        onclick="btnEliminar_Click" ToolTip="Eliminar Registro"
        ValidationGroup=' <%# Eval("cod_controles_calidad") %>'
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
        
        
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.controles_calidadTableAdapter" 
        DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_controles_calidad" Type="Int32" />
            <asp:Parameter Name="Original_controles_calidad" Type="String" />
            <asp:Parameter Name="Original_activo" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="controles_calidad" Type="String" />
            <asp:Parameter Name="activo" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="controles_calidad" Type="String" />
            <asp:Parameter Name="activo" Type="Boolean" />
            <asp:Parameter Name="Original_cod_controles_calidad" Type="Int32" />
            <asp:Parameter Name="Original_controles_calidad" Type="String" />
            <asp:Parameter Name="Original_activo" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </div>

</asp:Content>