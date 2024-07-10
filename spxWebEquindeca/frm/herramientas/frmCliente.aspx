<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCliente.aspx.cs" Inherits="frm_herramientas_frmCliente" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<asp:Label runat="server" ID="lblPaginaAnterior" Visible="false"></asp:Label>
<div class="tab">Informacion del cliente</div>
<div class="Formulario">
<table>
<tr>
<td>Nit Cliente</td>
<td>
    <asp:TextBox ID="txtNitCliente" runat="server" Height="20px" ReadOnly="True"></asp:TextBox>
    </td>
<td>Socio de Negocio</td>
<td>
    <asp:TextBox ID="txtSocioNegocio" runat="server" ReadOnly="True"></asp:TextBox>
    </td>
</tr>
<tr>
<td>Nombre</td>
<td colspan="3">
    <asp:TextBox ID="txtNombreCliente" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
    <asp:Button ID="btnVolver" runat="server" onclick="btnVolver_Click" 
        Text="Volver" />
    </td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
</table>
<br />
Sucursales
    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="SqlDataSourceSucursal" GridLines="None">
<MasterTableView datakeynames="nitCliente,codSucursal" 
            datasourceid="SqlDataSourceSucursal">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="nitCliente" 
            FilterControlAltText="Filter nitCliente column" HeaderText="nitCliente" 
            ReadOnly="True" SortExpression="nitCliente" UniqueName="nitCliente" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="codSucursal" 
            FilterControlAltText="Filter codSucursal column" HeaderText="codSucursal" 
            ReadOnly="True" SortExpression="codSucursal" UniqueName="codSucursal" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombreSucursal" 
            FilterControlAltText="Filter nombreSucursal column" HeaderText="Sucursal" 
            SortExpression="nombreSucursal" UniqueName="nombreSucursal">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Direccion" 
            FilterControlAltText="Filter Direccion column" HeaderText="Direccion" 
            SortExpression="Direccion" UniqueName="Direccion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Telefono1" 
            FilterControlAltText="Filter Telefono1 column" HeaderText="Telefono 1" 
            SortExpression="Telefono1" UniqueName="Telefono1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Telefono2" 
            FilterControlAltText="Filter Telefono2 column" HeaderText="Telefono 2" 
            SortExpression="Telefono2" UniqueName="Telefono2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="codContacto" 
            FilterControlAltText="Filter codContacto column" HeaderText="codContacto" 
            SortExpression="codContacto" UniqueName="codContacto" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombrePais" 
            FilterControlAltText="Filter nombrePais column" HeaderText="Pais" 
            SortExpression="nombrePais" UniqueName="nombrePais">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreDepartamento" 
            FilterControlAltText="Filter NombreDepartamento column" 
            HeaderText="Departamento" SortExpression="NombreDepartamento" 
            UniqueName="NombreDepartamento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombreCiudad" 
            FilterControlAltText="Filter nombreCiudad column" HeaderText="Ciudad" 
            SortExpression="nombreCiudad" UniqueName="nombreCiudad">
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
    <asp:SqlDataSource ID="SqlDataSourceSucursal" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="select * from dbo.vistaSucursal where nitCliente=@nit">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtNitCliente" Name="nit" 
                PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
<br />
Contactos
    <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="SqlDataSourceContactos" GridLines="None">
<MasterTableView datasourceid="SqlDataSourceContactos">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="nombreContacto" 
            FilterControlAltText="Filter nombreContacto column" HeaderText="Nombres" 
            SortExpression="nombreContacto" UniqueName="nombreContacto">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="apellidosContacto" 
            FilterControlAltText="Filter apellidosContacto column" HeaderText="Apellidos" 
            SortExpression="apellidosContacto" UniqueName="apellidosContacto">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="telefono1" 
            FilterControlAltText="Filter telefono1 column" HeaderText="telefono 1" 
            SortExpression="telefono1" UniqueName="telefono1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="celular" 
            FilterControlAltText="Filter celular column" HeaderText="celular" 
            SortExpression="celular" UniqueName="celular">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="email" 
            FilterControlAltText="Filter email column" HeaderText="email" 
            SortExpression="email" UniqueName="email">
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
    <asp:SqlDataSource ID="SqlDataSourceContactos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="select nombreContacto,apellidosContacto,telefono1,celular,email from contactosClientes where nitCliente=@nitCliente">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtNitCliente" Name="nitCliente" 
                PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
</asp:Content>

