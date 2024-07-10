<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoMaestro.aspx.cs" Inherits="frm_capacitacion_frmListadoMaestro" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />


    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="tab">
    Listado Maestro de Capacitaciones
</div>

<div class="Formulario">
<table>

<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkFechas" runat="server" Checked="True" Text="Fechas" />
    </td>
<td>entre <telerik:RadDateTimePicker ID="calInicio" Runat="server">
        <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>

    y
    <telerik:RadDateTimePicker ID="calFin" Runat="server">
        <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>



</td>
<td>&nbsp;</td>
</tr>


<tr>
<td></td>
<td>
    &nbsp;<asp:CheckBox ID="chkTema" runat="server" Text="Tema" />
    </td>
<td><asp:TextBox runat="server" ID="txtNombre" Width="200px"></asp:TextBox> </td>
<td>&nbsp;</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkFabricante" runat="server" Text="Fabricante" />
    </td>
<td>
    <asp:DropDownList ID="cmbFabricante" Runat="server" 
        DataSourceID="SqlDataSource2" DataTextField="nombre_fabricante" DataValueField="codFabricante" 
        ></asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [codFabricante], [nombre_fabricante] FROM [fabricante] ORDER BY [nombre_fabricante]">
    </asp:SqlDataSource>
    </td>
<td>&nbsp;</td>
</tr>


<tr>
<td rowspan="4" valign="top">
    &nbsp;</td>
<td>
    <asp:CheckBox ID="chkModelo" runat="server" Text="Modelo" />
    </td>
<td>
    <asp:TextBox ID="txtModelo" runat="server" Width="250px"></asp:TextBox>
    </td>
<td>
    &nbsp;</td>
</tr>


<tr>
<td>
    <asp:CheckBox ID="chkReactivo" runat="server" Text="Reactivo" />
    </td>
<td>
    <asp:TextBox ID="txtReactivo" runat="server" Width="248px"></asp:TextBox>
    </td>
<td>
    &nbsp;</td>
</tr>


<tr>
<td>
    <asp:CheckBox ID="chkUsuario" runat="server" Text="Usuario" />
    </td>
<td>
    <asp:DropDownList ID="cmbDictadaPor" Runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_usuario" 
        ></asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    </td>
<td>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
        onclick="btnBuscar_Click" Width="120px" />
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>
    <asp:Button ID="btnGenerarExcel" runat="server" Text="Generar Excel" 
        onclick="btnGenerarExcel_Click" Width="120px" />
    </td>
</tr>


</table>
<br />
<br />
    <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Web20" 
        AutoGenerateColumns="False" CellSpacing="0" GridLines="None">
<MasterTableView>
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn" HeaderText="Nombre">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnl" Text='<%# Eval("nombre") %>' NavigateUrl='<%# "frmDetalleCurso.aspx?cod="+Eval("cod_usuario") %>'  ></asp:HyperLink>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1" HeaderText="Correo">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnl5" Text='<%# Eval("correo") %>'  NavigateUrl='<%# "frmDetalleCurso.aspx?cod="+Eval("cod_usuario") %>'></asp:HyperLink>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1" HeaderText="Capacitacion">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnl5" Text='<%# Eval("curso") %>'  NavigateUrl='<%# "frmDetalleCurso.aspx?cod="+Eval("cod_usuario") %>'></asp:HyperLink>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1" HeaderText="Fecha">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnl5" Text='<%# Eval("Dictada") %>'  NavigateUrl='<%# "frmDetalleCurso.aspx?cod="+Eval("cod_usuario") %>'></asp:HyperLink>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1" HeaderText="Modelo">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnl5" Text='<%# Eval("Modelo") %>'  NavigateUrl='<%# "frmDetalleCurso.aspx?cod="+Eval("cod_usuario") %>'></asp:HyperLink>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1" HeaderText="Fabricante">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnl5" Text='<%# Eval("nombre_fabricante") %>'  NavigateUrl='<%# "frmDetalleCurso.aspx?cod="+Eval("cod_usuario") %>'></asp:HyperLink>
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

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Web20">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</HeaderContextMenu>
    </telerik:RadGrid>
<br />
</div>
</asp:Content>


