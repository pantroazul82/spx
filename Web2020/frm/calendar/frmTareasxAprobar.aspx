<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmTareasxAprobar.aspx.cs" Inherits="Web2020.frm.calendar.frmTareasxAprobar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../css/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <br />
  <br />
  <div class="tab">Tareas por aprobar</div>
    <telerik:RadGrid ID="grdDatos" runat="server" AllowFilteringByColumn="True" 
        AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="ObjectDataSource1" GridLines="None">
        <GroupingSettings CaseSensitive="false"  />
        <MasterTableView datasourceid="ObjectDataSource1">
            <CommandItemSettings ExportToPdfText="Export to PDF">
            </CommandItemSettings>
            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </RowIndicatorColumn>
            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </ExpandCollapseColumn>
            <Columns>
             <telerik:GridBoundColumn DataField="cod_tarea_calendario" 
                    FilterControlAltText="Filter column column" HeaderText="Consecutivo" 
                    UniqueName="column12">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="responsable" 
                    FilterControlAltText="Filter responsable column" HeaderText="responsable" 
                    SortExpression="responsable" UniqueName="responsable">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="inicio" DataType="System.DateTime" 
                    FilterControlAltText="Filter inicio column" HeaderText="inicio" 
                    SortExpression="inicio" UniqueName="inicio">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="fin" DataType="System.DateTime" 
                    FilterControlAltText="Filter fin column" HeaderText="fin" SortExpression="fin" 
                    UniqueName="fin" Visible="false">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="descripcion" 
                    FilterControlAltText="Filter descripcion column" HeaderText="descripcion" 
                    SortExpression="descripcion" UniqueName="descripcion">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="tipo_tarea" 
                    FilterControlAltText="Filter tipo_tarea column" HeaderText="tipo_tarea" 
                    SortExpression="tipo_tarea" UniqueName="tipo_tarea">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="nombreCliente" 
                    FilterControlAltText="Filter nombreCliente column" HeaderText="nombreCliente" 
                    SortExpression="Cliente" UniqueName="nombreCliente">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                    UniqueName="TemplateColumn">
                    <ItemTemplate>
                   <asp:HyperLink runat="server" ID="lnlTarea" Text="Ver Tarea" 
                   NavigateUrl= '<%# "frmNewTask.aspx?cod=tarea|"+Eval("cod_tarea_calendario") %>'></asp:HyperLink>
                   
                   
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByRequiere_aprobacion" 
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pltCalendarioTableAdapter">
    </asp:ObjectDataSource>
</asp:Content>


