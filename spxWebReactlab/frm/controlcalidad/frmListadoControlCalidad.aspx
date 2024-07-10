<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoControlCalidad.aspx.cs" Inherits="frm_controlcalidad_frmListadoControlCalidad" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
 <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Listado Control Calidad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <br />
    Desde
    <telerik:raddatepicker ID="calInicio" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:raddatepicker>
&nbsp;hasta
    <telerik:raddatepicker ID="calFin" Runat="server">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:raddatepicker>
    <asp:DropDownList ID="cmbEstados" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="estado_control_calidad" 
        DataValueField="cod_manual" AppendDataBoundItems="true">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_manual], [estado_control_calidad] FROM [estado_control_calidad] ORDER BY [estado_control_calidad]">
    </asp:SqlDataSource>
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Actualizar" />
&nbsp;<asp:Button ID="btnNuevo" runat="server" Text="Nuevo" 
        onclick="btnBuscar_Click" />
</div>

  <telerik:radgrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
        AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="odsTareas" GridLines="None">
        <MasterTableView datasourceid="odsTareas">
            <CommandItemSettings ExportToPdfText="Export to PDF">
            </CommandItemSettings>
            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </RowIndicatorColumn>
            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridTemplateColumn HeaderText="Cod" SortExpression="cod_control_calidad" DataField="cod_control_calidad" >
                <ItemTemplate>
                <asp:HyperLink runat="server" Text='<%# Eval("cod_control_calidad") %>'
                NavigateUrl= '<%# "frmResumenDetalladoControl.aspx?cod="+Eval("cod_control_calidad") %>'
                ></asp:HyperLink>
                </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn HeaderText="Estado"  SortExpression="estado_control_calidad" DataField="estado_control_calidad" >
                <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("estado_control_calidad") %>'
                NavigateUrl= '<%# "frmResumenDetalladoControl.aspx?cod="+Eval("cod_control_calidad") %>'
                ></asp:HyperLink>
                </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="fecha_creacion" DataType="System.DateTime" 
                    FilterControlAltText="Filter fecha_creacion column" 
                    HeaderText="Fecha creacion" SortExpression="fecha_creacion" 
                    UniqueName="fecha_creacion">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="creado_por" 
                    FilterControlAltText="Filter creado_por column" HeaderText="Creado por" 
                    SortExpression="creado_por" UniqueName="creado_por">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn HeaderText="Cliente"   SortExpression="nitCliente" DataField="nitCliente"  >
                <ItemTemplate>
                

                <asp:Label ID ="lblNit" runat="server" Text='<%# Eval("nitCliente") %>'></asp:Label>
                <br />
                <asp:Label ID="lblnombreCliente" runat="server" Text='<%# Eval("nombreCliente") %>'></asp:Label>
                </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="nombre_referencia_reactivo" 
                    FilterControlAltText="Filter nombre_referencia_reactivo column" 
                    HeaderText="Referencia reactivo" 
                    SortExpression="nombre_referencia_reactivo" 
                    UniqueName="nombre_referencia_reactivo">
                </telerik:GridBoundColumn>       
                <telerik:GridBoundColumn DataField="motivo" 
                    FilterControlAltText="Filter motivo column" HeaderText="motivo" 
                    SortExpression="motivo" UniqueName="motivo">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="entregado_por" 
                    FilterControlAltText="Filter entregado_por column" HeaderText="entregado_por" 
                    SortExpression="entregado_por" UniqueName="entregado_por">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="lote_reactivo" 
                    FilterControlAltText="Filter lote_reactivo column" HeaderText="lote_reactivo" 
                    SortExpression="lote_reactivo" UniqueName="lote_reactivo">
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
    </telerik:radgrid>
    <asp:ObjectDataSource ID="odsTareas" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByEstadoFechas" 
        
    
        
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pltControlCalidadTableAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="calInicio" Name="fechaIni" 
                PropertyName="SelectedDate" Type="DateTime" />
            <asp:ControlParameter ControlID="calFin" Name="fechaFin" PropertyName="SelectedDate" 
                Type="DateTime" />
            <asp:ControlParameter ControlID="cmbEstados" Name="codManual" 
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

