<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmDetalleCurso.aspx.cs" Inherits="frm_capacitacion_frmDetalleCurso" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />

<div class="tab">Cursos Tomados por
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
    </div>
<telerik:RadGrid ID="RadGrid1" runat="server" 
        CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None">
<MasterTableView autogeneratecolumns="False" datakeynames="cod_capacitacion" 
        datasourceid="SqlDataSource1">
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
        <asp:HyperLink runat="server" ID="lnk" Text='<%# Eval("nombre") %>' NavigateUrl='<%# "frmAceptarCapacitacion.aspx?cod="+Eval("cod_capacitacion") %>'></asp:HyperLink>
        </ItemTemplate>
        
        </telerik:GridTemplateColumn>
       
        <telerik:GridBoundColumn DataField="descripcion" 
            FilterControlAltText="Filter descripcion column" HeaderText="Descripcion" 
            SortExpression="descripcion" UniqueName="descripcion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_inicio" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_inicio column" HeaderText="Fecha inicio" 
            SortExpression="fecha_inicio" UniqueName="fecha_inicio">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_fin" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_fin column" HeaderText="Fecha fin" 
            SortExpression="fecha_fin" UniqueName="fecha_fin">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="dictada_por" 
            FilterControlAltText="Filter dictada_por column" HeaderText="Dictada por" 
            ReadOnly="True" SortExpression="dictada_por" UniqueName="dictada_por">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_fabricante" 
            FilterControlAltText="Filter nombre_fabricante column" 
            HeaderText="Fabricante" SortExpression="nombre_fabricante" 
            UniqueName="nombre_fabricante">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreModelo" 
            FilterControlAltText="Filter NombreModelo column" HeaderText="Modelo" 
            SortExpression="NombreModelo" UniqueName="NombreModelo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="nombre_referencia_reactivo" 
            FilterControlAltText="Filter nombre_referencia_reactivo column" 
            HeaderText="Referencia reactivo" 
            SortExpression="nombre_referencia_reactivo" 
            UniqueName="nombre_referencia_reactivo">
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
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select distinct capacitacion.cod_capacitacion,
capacitacion.nombre,
capacitacion.descripcion,capacitacion.fecha_inicio,
capacitacion.fecha_fin,case
when dictada_por is null 
then dictada_por_otro 
else usuario.nombre
end 'dictada_por',
nombre_fabricante,NombreModelo,
referencia_reactivo.nombre_referencia_reactivo
from asistentexsession
join usuario on usuario.cod_usuario = asistentexsession.cod_usuario
join session_capacitacion on session_capacitacion.cod_sesion_capacitacion = asistentexsession.cod_session
join capacitacion on capacitacion.cod_capacitacion = session_capacitacion.cod_capacitacion
left join fabricante on fabricante.codFabricante = capacitacion.cod_fabricante
left join Modelos on modelos.codModelo = capacitacion.cod_modelo and 
fabricante.codFabricante = modelos.codFabricante
left join referencia_reactivo on referencia_reactivo.cod_referencia_reactivo = capacitacion.cod_referencia_reactivo
left join usuario u on u.cod_usuario = dictada_por
where usuario.cod_usuario = @cod_usuario and asistentexsession.aceptada=1
order by capacitacion.fecha_fin desc
">
        <SelectParameters>
            <asp:QueryStringParameter Name="cod_usuario" QueryStringField="cod" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    

</asp:Content>


