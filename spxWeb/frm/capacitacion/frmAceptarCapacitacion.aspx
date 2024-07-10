<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmAceptarCapacitacion.aspx.cs" Inherits="frm_capacitacion_frmAceptarCapacitacion" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>


<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
  


    <style type="text/css">
        .style1
        {
            width: 245px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<div class="tab">
    Aceptacion de Capacitaciones
</div>

<div class="Formulario">
<table>
<tr>
<td></td>
<td>
    <asp:Label ID="lblTituloEstado" runat="server" Text="Estado"></asp:Label>
    <asp:Label ID="lblCod" runat="server" Visible="False"></asp:Label>
    </td>
<td>
    <asp:Label ID="lblNombreEstado" runat="server"></asp:Label><asp:Label runat="server" ID="lblPagPrev" Visible=false></asp:Label>
    </td>
<td class="style1">

    &nbsp;</td>
</tr>

<tr>
<td></td>
<td>Tema</td>
<td><asp:TextBox runat="server" ID="txtNombre" Width="200px" ReadOnly="True"></asp:TextBox> </td>
<td class="style1">&nbsp;</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Fecha de Inicio</td>
<td>
    <telerik:RadDatePicker ID="calInicio" Runat="server" Enabled="False" 
       >
       <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
    </td>
<td class="style1">
    Clases Programadas<br />
    <br />
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Fecha Final</td>
<td>
    <telerik:RadDatePicker ID="calFin" Runat="server" Enabled="False">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
    </td>
<td rowspan="10" valign="top" class="style1">
    <telerik:RadGrid ID="grdClases" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="odsClases" GridLines="None" Skin="Web20">
<MasterTableView DataKeyNames="cod_sesion_capacitacion" DataSourceID="odsClases">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="fecha_inicio" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_inicio column" HeaderText="Fecha inicio" 
            SortExpression="fecha_inicio" UniqueName="fecha_inicio">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="fecha_fin" DataType="System.DateTime" 
            FilterControlAltText="Filter fecha_fin column" HeaderText="Fecha fin" 
            SortExpression="fecha_fin" UniqueName="fecha_fin">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
            
             <asp:Button runat="server" Text="Aceptar" ID="btnAceptar" ValidationGroup='<%# Eval("cod_sesion_capacitacion") %>'  
             OnClick="btnAceptar_Click" Visible='<%#  false && verVisibleAceptar(Eval("cod_sesion_capacitacion"))  %>'/>
             <asp:Button runat="server" Text="Cancelar" ID="btnCancelarD" ValidationGroup='<%# Eval("cod_sesion_capacitacion") %>' 
             OnClick="btnRechazar_Click" Visible='<%#  false && verVisibleAceptar(Eval("cod_sesion_capacitacion"))  %>'/>
             <asp:Label runat="server" ID="lblEstatus" Text='<%# verTexto(Eval("cod_sesion_capacitacion")) %>' ></asp:Label>
             <asp:Button runat="server" Text='Cambiar Estado' ID="btnCambiarEstado" ValidationGroup='<%# Eval("cod_sesion_capacitacion") %>'
             OnClick="btnCambiar_Click" Visible='<%#  false && verVisibleCancelar(Eval("cod_sesion_capacitacion"))  %>' />

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
    <asp:ObjectDataSource ID="odsClases" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCod_capacitacion" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_sesion_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_fin" Type="DateTime" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="fecha_fin" Type="DateTime" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="lblCod" Name="cod_capacitacion" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="fecha_fin" Type="DateTime" />
            <asp:Parameter Name="Original_cod_sesion_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_fin" Type="DateTime" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:Button ID="btnAceptarTodos" runat="server" Text="Aceptar Todos" 
        onclick="btnAceptarTodos_Click" Width="115px" Visible="false" />
    <asp:Button ID="btnRechazartodas" runat="server" Text="Rechazar Todas" 
        onclick="btnRechazartodas_Click" Width="118px" Visible="false" />
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Modelo</td>
<td>
    <asp:TextBox ID="txtModelo" runat="server" Width="250px" Enabled="False"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Reactivo</td>
<td>
    <asp:TextBox ID="txtReactivo" runat="server" Width="248px" Enabled="False"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Dictada por</td>
<td>
    <asp:DropDownList ID="cmbDictadaPor" Runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_usuario" 
        OnPreRender="cmbDictadaPor_PreRender" Enabled="False"></asp:DropDownList>
    
    &nbsp;&nbsp; Otro: 
    <asp:TextBox ID="txtotro" runat="server" Width="250px" ReadOnly="True"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Observaciones</td>
<td>
    <asp:TextBox ID="txtObservaciones" runat="server" Height="101px" 
        TextMode="MultiLine" Width="375px" ReadOnly="True"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td colspan="2">

    <asp:Label ID="lblTituloEvaluacion" runat="server" Text="Evaluacion" 
        Font-Bold="True" Font-Size="14pt" Visible="False"></asp:Label>

&nbsp;<asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Size="15pt" 
        ForeColor="Red" Text="Aprobo" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="lblAsistencia" runat="server" Font-Size="12pt" Visible="False"></asp:Label>

</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblVerAsistencia" runat="server" Text="Ver Asistencia:" 
        Visible="False"></asp:Label>
&nbsp;
      <asp:ImageButton runat="server" OnClick="btnVerAsistencia_Click" 
        ID="btnVerAsistencia" Visible='False' ImageUrl="~/img/web/lookup.gif" 
        ToolTip="Ver Asistencia" ValidationGroup='<%# Eval("cod_usuario") %>' />
          <br />
    <asp:Label ID="lblVerEvaluacion" runat="server" Text="Ver Evaluacion:" 
        Visible="False"></asp:Label>
&nbsp;<asp:ImageButton runat="server" OnClick="btnVerEvaluacion_Click" 
        ID="btnVerEvaluacion" Visible='False' ImageUrl="~/img/web/lookup.gif" 
        ToolTip="Ver Evaluacion" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <br />
    <asp:Label ID="lblVerCertificado" runat="server" Text="Ver Certificado:" 
        Visible="False"></asp:Label>
&nbsp;<asp:ImageButton runat="server" OnClick="btnVerCertificado_Click" 
        ID="btnVerCertificado" Visible='False' ImageUrl="~/img/web/lookup.gif" 
        ToolTip="Ver Certificado" ValidationGroup='<%# Eval("cod_usuario") %>' />
      
    &nbsp;</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    <telerik:RadButton ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Volver">
    </telerik:RadButton>
    </td>
</tr>


</table>
</div>
</asp:Content>



