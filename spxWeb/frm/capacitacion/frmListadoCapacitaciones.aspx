<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoCapacitaciones.aspx.cs" Inherits="frm_capacitacion_frmListadoCapacitaciones" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<div class="tab">Listado de capacitaciones&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nueva Capacitacion" />
    </div>
<div class="Formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="ObjectDataSource1" GridLines="None" 
        Skin="Web20">
<MasterTableView DataKeyNames="cod_capacitacion" DataSourceID="ObjectDataSource1">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
    <telerik:GridTemplateColumn>
    <ItemTemplate>
    <asp:HyperLink runat="server" ID="lnk" Text='<%# Eval("nombre") %>' NavigateUrl='<%# "frmCapacitacion.aspx?cod="+Eval("cod_capacitacion") %>'></asp:HyperLink>
    </ItemTemplate>
    </telerik:GridTemplateColumn>

      <telerik:GridTemplateColumn HeaderText="Inicia" SortExpression="fecha_inicio">
    <ItemTemplate>
    <asp:HyperLink runat="server" ID="lnk2" Text='<%# Eval("fecha_fin").ToString().Substring(0,10) %>' NavigateUrl='<%# "frmCapacitacion.aspx?cod="+Eval("cod_capacitacion") %>'></asp:HyperLink>
    </ItemTemplate>
    </telerik:GridTemplateColumn>

      <telerik:GridTemplateColumn HeaderText="Termina" SortExpression="fecha_fin">
    <ItemTemplate>
    <asp:HyperLink runat="server" ID="lnk3" Text='<%# Eval("fecha_inicio").ToString().Substring(0,10) %>' NavigateUrl='<%# "frmCapacitacion.aspx?cod="+Eval("cod_capacitacion") %>'></asp:HyperLink>
    </ItemTemplate>
    </telerik:GridTemplateColumn>
       
      
       
        
        <telerik:GridBoundColumn DataField="nombreModelo" 
            FilterControlAltText="Filter nombreModelo column" HeaderText="nombreModelo" 
            SortExpression="nombreModelo" UniqueName="nombreModelo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_referencia_reactivo" 
            FilterControlAltText="Filter nombre_referencia_reactivo column" 
            HeaderText="Reactivo" 
            SortExpression="nombre_referencia_reactivo" 
            UniqueName="nombre_referencia_reactivo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre1" 
            FilterControlAltText="Filter nombre1 column" HeaderText="Dictada Por" 
            UniqueName="nombre1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="estado_capacitacion" 
            FilterControlAltText="Filter estado_capacitacion column" 
            HeaderText="estado" SortExpression="estado_capacitacion" 
            UniqueName="estado_capacitacion">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn>
        <ItemTemplate>
          <asp:HyperLink Text="Ver Participacion" runat="server" ID="linkEditarParticipacion" 
          NavigateUrl='<%# "frmAceptarCapacitacion.aspx?cod="+Eval("cod_capacitacion") %>'
          Visible='<%# verLinkEditarParticipacion( Eval("cod_capacitacion")) %>' >
          
          </asp:HyperLink>
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pltCapacitacionTableAdapter">
    </asp:ObjectDataSource>
<br />

</div>
</asp:Content>

