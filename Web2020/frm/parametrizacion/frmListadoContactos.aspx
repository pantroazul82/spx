<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmListadoContactos.aspx.cs" Inherits="Web2020.frm.parametrizacion.frmListadoContactos" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />

Buscar por Cliente o Informacion de contacto 
<asp:TextBox runat="server" ID="txtBuscar"></asp:TextBox>   
 <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/img/lupa.png" Width="20px" 
         ToolTip="Buscar" />

<br />
<div class="tab">Listado Contactos clientes&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/insert.gif" 
        onclick="btnNuevo_Click" ToolTip="Nuevo Registro" />
&nbsp;</div>
<div  class="formulario">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlDataSource1" 
        GridLines="None">
<MasterTableView datakeynames="nitCliente,codContacto" 
            datasourceid="SqlDataSource1">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="nombreCLiente"
            FilterControlAltText="Filter nombreCLiente column" 
            HeaderText="Cliente" 
            SortExpression="nombreCLiente" 
            UniqueName="nombreCLiente">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nitCliente" 
            FilterControlAltText="Filter nitCliente column" HeaderText="Nit Cliente" SortExpression="nitCliente" 
            UniqueName="nitCliente" ReadOnly="True">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombreContacto" 
            FilterControlAltText="Filter nombreContacto column" HeaderText="Contacto" 
            SortExpression="nombreContacto" UniqueName="nombreContacto">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="apellidosContacto" 
            FilterControlAltText="Filter apellidosContacto column" HeaderText="Apellidos Contacto" 
            SortExpression="apellidosContacto" UniqueName="apellidosContacto">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="telefono1" 
            FilterControlAltText="Filter telefono1 column" 
            HeaderText="telefono" SortExpression="telefono1" 
            UniqueName="telefono1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="celular" 
            FilterControlAltText="Filter celular column" HeaderText="celular" 
            SortExpression="celular" UniqueName="celular">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="email" 
            FilterControlAltText="Filter email column" HeaderText="email" 
            SortExpression="email" UniqueName="email">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="es_activo" DataType="System.Boolean" 
            FilterControlAltText="Filter es_activo column" HeaderText="Activo" 
            SortExpression="es_activo" UniqueName="es_activo">
        </telerik:GridCheckBoxColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
             <ItemTemplate>
             <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/img/web/edit.gif" 
        onclick="btnEditar_Click" ToolTip="Editar Registro" ValidationGroup=' <%# Eval("codContacto")+"|"+Eval("nitCliente") %>' />
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
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select 
clientes.nombreCLiente,
contactosClientes.nitCliente, contactosClientes.codContacto, contactosClientes.nombreContacto, 
contactosClientes.apellidosContacto, contactosClientes.docContacto, 
 
contactosClientes.tituloContacto, contactosClientes.telefono1, contactosClientes.telefono2, 
contactosClientes.fax, contactosClientes.celular, contactosClientes.email, 
contactosClientes.paginaWeb, contactosClientes.cumpleanos, contactosClientes.es_activo

 from contactosClientes
 join clientes on clientes.nitCliente = contactosClientes.nitCliente
 where 
@parametro is null
or (
clientes.nitCliente like '%'+@parametro+'%' or
nombreCliente like '%'+@parametro+'%'
 or contactosClientes.nitCliente like '%'+@parametro+'%'
 or contactosClientes.nombreContacto like '%'+@parametro+'%'
 or contactosClientes.apellidosContacto like '%'+@parametro+'%'
)">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtBuscar" Name="parametro" 
                PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    </div>

</asp:Content>